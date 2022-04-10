using System.Collections.Generic;
using System.Linq;

namespace ConroleAcesso.ViewModels
{
    public class PilotoViewModel
    {
        private List<string> _idsNaves;

        public string Name { get; set; }
        public string Birth_Year { get; set; }
        public string Homeworld { get; set; }
        public IReadOnlyList<string> Starships { get; set; }
        public string Url { get; set; }

        public int IdPlaneta
        {
            get
            {
                return int.Parse(Homeworld?.Split('/').Where(u => !string.IsNullOrEmpty(u)).LastOrDefault());
            }
        }

        public IReadOnlyList<string> IdNaves
        {
            get
            {
                if (_idsNaves == null)
                    _idsNaves = Starships.Select(nave => nave?.Split('/').Where(u => !string.IsNullOrEmpty(u)).LastOrDefault()).ToList();

                return _idsNaves;
            }
        }

        public int IdPiloto
        {
            get
            {
                return int.Parse(Url?.Split('/').Where(u => !string.IsNullOrEmpty(u)).LastOrDefault());
            }
        }
    }
}