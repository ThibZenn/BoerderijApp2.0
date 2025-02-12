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

        public override string ToString()
        {
            return $"{GetType().Name} {Naam} ({GeboorteDatum.ToShortDateString()}) bezit {AandeelInDeOnderneming:0.00}% van de onderneming.";
        }
    }
}
