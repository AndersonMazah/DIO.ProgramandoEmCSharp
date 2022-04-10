using ConroleAcesso.Dao;
using ConroleAcesso.Entidades;
using ConroleAcesso.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ConroleAcesso.Servicos
{
    public class SincronizadorService
    {
        private const string URL_PLANETAS = "http://swapi.dev/api/planets/";
        private const string URL_NAVES = "http://swapi.dev/api/starships/";
        private const string URL_PILOTOS = "http://swapi.dev/api/people/";

        public Task Sincronizar()
        {
            var tasks = new List<Task>();

            tasks.Add(SincronizarPlanetas());
            tasks.Add(SincronizarNaves());

            Task.WhenAll(tasks);

            return SincronizarPilotos();
        }

        private async Task SincronizarPlanetas()
        {
            var httpClient = new HttpClient();
            var lista = new List<PlanetaViewModel>();
            ResultadoApi<PlanetaViewModel> resultadoApi = null;

            do
            {
                resultadoApi = await httpClient.GetFromJsonAsync<ResultadoApi<PlanetaViewModel>>(resultadoApi?.Next ?? URL_PLANETAS);
                lista.AddRange(resultadoApi.Results);
            } while (resultadoApi.Next != null);

            var planetas = lista.Select(item => new Planeta
            {
                IdPlaneta = item.IdPlaneta,
                Nome = item.Name,
                Clima = item.Climate,
                Diametro = item.Diametro,
                Orbita = item.Orbita,
                Rotacao = item.Rotacao,
                Populacao = item.Populacao
            }).ToList();

            using (var dao = new PlanetaDao())
                await dao.InserirPlanetas(planetas);
        }

        private async Task SincronizarNaves()
        {
            var httpClient = new HttpClient();
            var lista = new List<NaveViewModel>();
            ResultadoApi<NaveViewModel> resultadoApi = null;

            do
            {
                resultadoApi = await httpClient.GetFromJsonAsync<ResultadoApi<NaveViewModel>>(resultadoApi?.Next ?? URL_NAVES);
                lista.AddRange(resultadoApi.Results);
            } while (resultadoApi.Next != null);

            var naves = lista.Select(item => new Nave
            {
                IdNave = item.IdNave,
                Nome = item.Name,
                Carga = item.Carga,
                Classe = item.Starship_Class,
                Modelo = item.Model,
                Passageiros = item.Passageiros
            }).ToList();

            using (var dao = new NaveDao())
                await dao.InserirNaves(naves);
        }

        private async Task SincronizarPilotos()
        {
            var httpClient = new HttpClient();
            var lista = new List<PilotoViewModel>();
            ResultadoApi<PilotoViewModel> resultadoApi = null;

            do
            {
                resultadoApi = await httpClient.GetFromJsonAsync<ResultadoApi<PilotoViewModel>>(resultadoApi?.Next ?? URL_PILOTOS);
                lista.AddRange(resultadoApi.Results.Where(p => p.Starships.Any()).ToList());
            } while (resultadoApi.Next != null);

            var pilotos = lista.Select(item => new Piloto
            {
                IdPiloto = item.IdPiloto,
                Nome = item.Name,
                AnoNascimento = item.Birth_Year,
                IdPlaneta = item.IdPlaneta,
                Naves = item.IdNaves.Select(idNave => new Nave
                {
                    IdNave = int.Parse(idNave)
                }).ToList()
            }).ToList();

            using (var pilotoDao = new PilotoDao())
            {
                await pilotoDao.InserirPilotos(pilotos);
                await pilotoDao.InserirPilotosNaves(pilotos);
            }
        }

    }
}
