using System.Linq;

namespace ConroleAcesso.ViewModels
{
    public class PlanetaViewModel
    {
        public string Name { get; set; }
        public string Rotation_Period { get; set; }
        public string Orbital_Period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Population { get; set; }
        public string Url { get; set; }

        public double Rotacao
        {
            get
            {
                double.TryParse(Rotation_Period, out var retorno);
                return retorno;
            }
        }

        public double Orbita
        {
            get
            {
                double.TryParse(Orbital_Period, out var retorno);
                return retorno;
            }
        }

        public double Diametro
        {
            get
            {
                double.TryParse(Diameter, out var retorno);
                return retorno;
            }
        }

        public int Populacao
        {
            get
            {
                int.TryParse(Population, out var retorno);
                return retorno;
            }
        }

        public int IdPlaneta
        {
            get
            {
                return int.Parse(Url?.Split('/').Where(u => !string.IsNullOrEmpty(u)).LastOrDefault());
            }
        }
    }
}
