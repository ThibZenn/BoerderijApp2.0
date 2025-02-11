using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoerderijApp_BL.Domein
{
    public class Boer : Persoon
    {
        private double _aandeelInDeOnderneming;

        public Boer(string naam, DateTime geboorteDatum, double aandeelInDeOnderneming) : base(naam, geboorteDatum)
        {
            AandeelInDeOnderneming = aandeelInDeOnderneming;
        }

        public double AandeelInDeOnderneming { get; set; }
        public override double BerekenLoonKost()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString(); // TODO: Afwerken
        }
    }
}
