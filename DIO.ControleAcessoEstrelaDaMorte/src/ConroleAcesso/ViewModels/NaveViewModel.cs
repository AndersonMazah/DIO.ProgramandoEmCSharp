using System.Linq;

namespace ConroleAcesso.ViewModels
{
    public class NaveViewModel
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Passengers { get; set; }
        public string Cargo_Capacity { get; set; }
        public string Starship_Class { get; set; }
        public string Url { get; set; }

        public int Passageiros
        {
            get
            {
                int.TryParse(Passengers, out var retorno);
                return retorno;
            }
        }

        public double Carga
        {
            get
            {
                double.TryParse(Cargo_Capacity, out var retorno);
                return retorno;
            }
        }

        public int IdNave
        {
            get
            {
                return int.Parse(Url?.Split('/').Where(u => !string.IsNullOrEmpty(u)).LastOrDefault());
            }
        }
    }
}
