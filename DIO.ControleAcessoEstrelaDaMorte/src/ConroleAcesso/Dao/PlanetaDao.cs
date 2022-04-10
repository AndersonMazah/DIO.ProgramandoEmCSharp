using ConroleAcesso.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConroleAcesso.Dao
{
    public class PlanetaDao : DaoBase
    {
        public async Task InserirPlanetas(List<Planeta> planetas)
        {
            if (!planetas.Any())
                return;

            var check = "if (not exists(select 1 from Planetas where IdPlaneta = {0}))\n";
            var insert = "insert Planetas (IdPlaneta, Nome, Rotacao, Orbita, Diametro, Clima, Populacao) values({0}, '{1}', {2}, {3}, {4}, '{5}', {6});\n";
            var comandos = planetas.Select(planeta => string.Format(check, planeta.IdPlaneta) + string.Format(insert, planeta.IdPlaneta, planeta.Nome, planeta.Rotacao, planeta.Orbita, planeta.Diametro, planeta.Clima, planeta.Populacao));

            await Insert(string.Join('\n', comandos));
        }
    }
}
