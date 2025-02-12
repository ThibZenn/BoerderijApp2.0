using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoerderijApp_BL.Enums;

namespace BoerderijApp_BL.Domein
{
    public class Akker : Eigendom
    {
        public Akker(string naam, double kost, double oppervlakteM2, GewasEnum gewas)
        : base(naam, kost)
        {
            if (oppervlakteM2 <= 0)
            {
                throw new ArgumentException("Akker - Oppervlakte moet positief zijn");
            }
            OppervlakteM2 = oppervlakteM2;
            Gewas = gewas;
        }

        public double OppervlakteM2 { get; init; }
        public GewasEnum Gewas { get; set; }

        public override double BerekenOpbrengst()
        {
            switch (Gewas)
            {
                case GewasEnum.Aardappel:
                    return (OppervlakteM2 * 0.32) - Kost;
                case GewasEnum.Prei:
                    return (OppervlakteM2 * 0.43) - Kost;
                case GewasEnum.Hop:
                    return (OppervlakteM2 * 0.91) - Kost;
                default:
                    return -1;
            }
        }
    }
}
