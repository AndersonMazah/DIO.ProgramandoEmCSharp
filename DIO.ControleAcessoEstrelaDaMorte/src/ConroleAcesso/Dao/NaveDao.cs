using ConroleAcesso.Entidades;
using ConroleAcesso.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConroleAcesso.Dao
{
    public class NaveDao : DaoBase
    {
        public async Task InserirNaves(List<Nave> naves)
        {
            if (!naves.Any())
                return;

            var check = "if (not exists(select 1 from Naves where IdNave = {0}))\n";
            var insert = "insert Naves (IdNave, Nome, Modelo, Passageiros, Carga, Classe) values({0}, '{1}', '{2}', {3}, {4}, '{5}');\n";
            var comandos = naves.Select(nave => string.Format(check, nave.IdNave) + string.Format(insert, nave.IdNave, nave.Nome, nave.Modelo, nave.Passageiros, nave.Carga, nave.Classe));

            await Insert(string.Join('\n', comandos));
        }

        public async Task<List<Nave>> ObterPorNomeLike(string nome)
        {
            var naves = new List<Nave>();
            var comando = $"select * from Naves where nome like '%{nome.Replace(' ', '%')}%'";

            await Select(comando, resultadoSQL =>
            {
                while (resultadoSQL.Read())
                {
                    naves.Add(new Nave
                    {
                        IdNave = resultadoSQL.GetValueOrDefault<int>("IdNave"),
                        Nome = resultadoSQL.GetValueOrDefault<string>("Nome")
                    });
                }
            });

            return naves;
        }

        public async Task<Nave> ObterPorId(int idNave)
        {
            Nave nave = null;
            var comando = @$"
                                select	t1.*
                                from	Naves t1
                                where	t1.IdNave = {idNave}";

            await Select(comando, resultadoSQL =>
            {
                while (resultadoSQL.Read())
                {
                    nave = new Nave
                    {
                        IdNave = resultadoSQL.GetValueOrDefault<int>("IdNave"),
                        Nome = resultadoSQL.GetValueOrDefault<string>("Nome"),
                        Modelo = resultadoSQL.GetValueOrDefault<string>("Modelo"),
                        Passageiros = resultadoSQL.GetValueOrDefault<int>("Passageiros"),
                        Carga = resultadoSQL.GetValueOrDefault<double>("Carga"),
                        Classe = resultadoSQL.GetValueOrDefault<string>("Classe")
                    };
                }
            });

            return nave;
        }

        public async Task<int?> ObterComandante(int idNave)
        {
            int? idPiloto = null;
            var comando = $"select IdPiloto from HistoricoViagens t1 where t1.IdNave = {idNave} and t1.DtChegada is null";

            await Select(comando, resultadoSQL =>
            {
                while(resultadoSQL.Read())
                {
                    idPiloto = resultadoSQL.GetValueOrDefault<int?>("IdPiloto");
                }
            });

            return idPiloto;
        }
    }
}
