using ConroleAcesso.Dao;
using ConroleAcesso.Entidades;
using ConroleAcesso.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConroleAcesso.Forms
{
    public partial class frmRegistrarEntradaSaida : Form
    {
        private Piloto _piloto;
        private Piloto _pilotoComandante;
        private Nave _nave;
        private int _idNave;
        private int _idPiloto;
        private bool _chegada;
        private bool _pilotoViajando;

        public frmRegistrarEntradaSaida(int idNave, int idPiloto, bool chegada)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _idNave = idNave;
            _idPiloto = idPiloto;
            _chegada = chegada;            

            InitializeComponent();
        }

        private async void frmRegistrarEntradaSaida_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int? idPilotoComandante;
            using (var naveDao = new NaveDao())
            {
                _nave = await naveDao.ObterPorId(_idNave);
                idPilotoComandante = await naveDao.ObterComandante(_idNave);
            }

            using (var pilotoDao = new PilotoDao())
            {
                _piloto = await pilotoDao.ObterPorId(_idPiloto);
                _pilotoViajando = await pilotoDao.PilotoEstaViajando(_idPiloto);

                if(idPilotoComandante.HasValue)
                    _pilotoComandante = await pilotoDao.ObterPorId(idPilotoComandante.Value);
            }

            lvAlertas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvAlertas.PerformLayout();

            PreencherDadosNave();
            PreencherDadosPiloto();

            if (EhValido())
            {
                btnRegistrar.Enabled = true;
                this.Height = 228;
            }
            else
            {
                btnRegistrar.Enabled = false;
                this.Height = 490;
            }

            if (_chegada)
                btnRegistrar.Text = "Registrar Chegada";
            else
                btnRegistrar.Text = "Registrar Saída";

            Cursor = Cursors.Default;
        }

        private void PreencherDadosNave()
        {
            lblNomeNave.Text = _nave.Nome;
            lblModelo.Text = _nave.Modelo;
            lblClasse.Text = _nave.Classe;
        }

        private void PreencherDadosPiloto()
        {
            lblNomePiloto.Text = _piloto.Nome;
            lblAnoNacimento.Text = _piloto.AnoNascimento;
            lblPlaneta.Text = _piloto.Planeta.Nome;
        }

        private bool EhValido()
        {
            bool ehValido = PilotoEhValido();
            ehValido = NaveEhValida() && ehValido;

            return ehValido;
        }

        private bool PilotoEhValido()
        {
            bool ehValido = true;
            
            //Saindo
            if (!_chegada)
            {
                if (_pilotoViajando)
                {
                    ehValido = false;
                    lvAlertas.Items.Add(new ListViewItem("PERIGO - PILOTO AINDA NÃO CHEGOU DE VIAGEM, DEVE SER UM IMPOSTOR"));
                }

                if(!_piloto.Naves.Any(nave => nave.IdNave == _nave.IdNave))
                {
                    ehValido = false;
                    lvAlertas.Items.Add(new ListViewItem("Este piloto não está habilitado para esta nave"));
                }
            }

            //Chegando
            if (_chegada && !_pilotoViajando)
            {
                ehValido = false;
                lvAlertas.Items.Add(new ListViewItem("PERIGO - PILOTO NÃO SAIU PARA VIAGEM, DEVE SER UM IMPOSTOR"));
            }
            
            return ehValido;
        }

        private bool NaveEhValida()
        {
            bool ehValido = true;

            //Saindo
            if(!_chegada && _pilotoComandante != null)
            {
                ehValido = false;
                lvAlertas.Items.Add(new ListViewItem("Nave já está em viagem"));
            }

            //Chegando
            if (_chegada)
            {
                if (_pilotoComandante == null)
                {
                    ehValido = false;
                    lvAlertas.Items.Add(new ListViewItem("PERIGO - NAVE NÃO SAIU, PODE SER UMA NAVE IMPOSTORA"));
                }

                if(_pilotoComandante != null && _pilotoComandante.IdPiloto != _piloto.IdPiloto)
                {
                    ehValido = false;
                    lvAlertas.Items.Add(new ListViewItem($"PERIGO - PILOTO QUE RETIROU A NAVE FOI '{_pilotoComandante.Nome.ToUpper()}'"));
                }
            }

            return ehValido;
        }

        private void frmRegistrarEntradaSaida_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_chegada)
                await RegistrarEntrada();
            else
                await RegistrarSaida();

            btnRegistrar.Enabled = false;
            MessageBox.Show("Registro efetuado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task RegistrarEntrada()
        {
            using (var pilotoDao = new PilotoDao())
                await pilotoDao.RegistrarFimViagem(_idPiloto, _idNave);
        }

        private async Task RegistrarSaida()
        {
            using (var pilotoDao = new PilotoDao())
                await pilotoDao.RegistrarInicioViagem(_idPiloto, _idNave);
        }
    }
}
