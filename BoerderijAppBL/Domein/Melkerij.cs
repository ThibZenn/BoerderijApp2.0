using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoerderijApp_BL.Domein
{
    public class Melkerij : Eigendom
    {
        public Melkerij(string naam, double maandelijkseKost, int aantalKoeien) : base(naam, maandelijkseKost)
        {
            AantalKoeien = aantalKoeien;
        }

        public int AantalKoeien { get; init; }

        public override double BerekenOpbrengst()
        {
            return (AantalKoeien * 300) - Kost;
        }
    }
}
