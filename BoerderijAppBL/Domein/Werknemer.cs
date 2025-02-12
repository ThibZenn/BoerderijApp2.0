using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoerderijApp_BL.Domein
{
    public class Werknemer : Persoon
    {
        public Werknemer(string naam, DateTime geboorteDatum ,double basisLoon) :base(naam, geboorteDatum)
        {
            BasisLoon = basisLoon;
            WerknemersNummer = GenereerWerknemersNummer(Naam);
        }

        public Werknemer(string naam, DateTime geboorteDatum) : base(naam, geboorteDatum)
        {
            BasisLoon = 0.0;
            WerknemersNummer = GenereerWerknemersNummer(Naam);
        }

        public double BasisLoon { get; set; }
        public string WerknemersNummer { get; set; }

        public override double BerekenLoonKost()
        {
            return Math.Round((BasisLoon * 1.45),2);
        }

        private string GenereerWerknemersNummer(string naam)
        {
            Random rnd = new Random();

            return $"{naam.Substring(0,3)}{DateTime.Now.ToString("yyyyMMdd")}{rnd.Next(100,1000)}";
        }

        public override string ToString() 
        {
            return $"{GetType().Name} {Naam} ({GeboorteDatum.ToShortDateString()}) met nummer {WerknemersNummer} kost {BerekenLoonKost()}.";
        }
    }
}
