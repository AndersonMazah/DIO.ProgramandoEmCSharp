using ConroleAcesso.Dao;
using ConroleAcesso.Extensions;
using System;
using System.Windows.Forms;

namespace ConroleAcesso.Forms
{
    public partial class frmControleNaves : Form
    {
        private readonly PilotoDao _pilotoDao;
        private readonly NaveDao _naveDao;

        public frmControleNaves()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _pilotoDao = new PilotoDao();
            _naveDao = new NaveDao();
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if(!rdbChegando.Checked && !rdbSaindo.Checked)
            {
                MessageBox.Show("É preciso informar se a nave está chegando ou saindo da Estrela da Morte!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvNaves.Rows.Count == 0 || dgvNaves.Rows.GetCountRowsChecked(1) != 1)
            {
                MessageBox.Show("É preciso selecionar apenas uma nave!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvPilotos.Rows.Count == 0 || dgvPilotos.Rows.GetCountRowsChecked(1) != 1)
            {
                MessageBox.Show("É preciso selecionar apenas um piloto da nave!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idPiloto = int.Parse(dgvPilotos.Rows[dgvPilotos.Rows.GetFirstIndexChecked(1)].Cells[0].Value.ToString());
            var idNave = int.Parse(dgvNaves.Rows[dgvNaves.Rows.GetFirstIndexChecked(1)].Cells[0].Value.ToString());
            var frm = new frmRegistrarEntradaSaida(idNave, idPiloto, rdbChegando.Checked);
            frm.ShowDialog();
        }

        private void frmControleNaves_FormClosing(object sender, FormClosingEventArgs e)
        {
            _naveDao?.Dispose();
            _pilotoDao?.Dispose();
            Dispose();
        }

        private async void btnBuscarNave_Click(object sender, EventArgs e)
        {
            dgvNaves.Rows.Clear();
            dgvNaves.Columns.Clear();

            if (string.IsNullOrEmpty(txtNomeNave.Text))
                return;

            Cursor = Cursors.WaitCursor;
            DataGridViewTextBoxColumn idNaveColumn = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn checkNaveColumn = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn nomeNaveColumn = new DataGridViewTextBoxColumn();

            idNaveColumn.Visible = false;

            idNaveColumn.ReadOnly = true;
            checkNaveColumn.ReadOnly = false;
            nomeNaveColumn.ReadOnly = true;

            nomeNaveColumn.Width = 500;

            dgvNaves.RowHeadersVisible = false;
            dgvNaves.ColumnHeadersVisible = false;
            dgvNaves.Columns.Add(idNaveColumn);
            dgvNaves.Columns.Add(checkNaveColumn);
            dgvNaves.Columns.Add(nomeNaveColumn);

            var naves = await _naveDao.ObterPorNomeLike(txtNomeNave.Text);
            foreach (var nave in naves)
                dgvNaves.Rows.Add(nave.IdNave, false, nave.Nome);

            dgvNaves.PerformLayout();
            Cursor = Cursors.Default;
        }

        private async void btnBuscarPiloto_Click(object sender, EventArgs e)
        {
            dgvPilotos.Rows.Clear();
            dgvPilotos.Columns.Clear();

            if (string.IsNullOrEmpty(txtNomePiloto.Text))
                return;

            Cursor = Cursors.WaitCursor;
            DataGridViewTextBoxColumn idPilotoColumn = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn checkPilotoColumn = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn nomePilotoColumn = new DataGridViewTextBoxColumn();

            idPilotoColumn.Visible = false;

            idPilotoColumn.ReadOnly = true;
            checkPilotoColumn.ReadOnly = false;
            nomePilotoColumn.ReadOnly = true;

            nomePilotoColumn.Width = 500;

            dgvPilotos.RowHeadersVisible = false;
            dgvPilotos.ColumnHeadersVisible = false;
            dgvPilotos.Columns.Add(idPilotoColumn);
            dgvPilotos.Columns.Add(checkPilotoColumn);
            dgvPilotos.Columns.Add(nomePilotoColumn);

            var pilotos = await _pilotoDao.ObterPorNomeLike(txtNomePiloto.Text);
            foreach (var piloto in pilotos)
                dgvPilotos.Rows.Add(piloto.IdPiloto, false, piloto.Nome);

            dgvNaves.PerformLayout();
            Cursor = Cursors.Default;
        }
    }
}
