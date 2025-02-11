using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoerderijApp_BL.Domein
{
    public class Boerderij
    {
        public Boerderij(string naam, string BTWNummer, List<Persoon> personen, List<Eigendom> eigendommen)
        {
            Naam = naam;
            this.BTWNummer = BTWNummer;
            Personen = personen;
            Eigendommen = eigendommen;
        }

        public string Naam { get; set; }
        public string BTWNummer { get; set; }
        public List<Persoon> Personen { get; set; }
        public List<Eigendom> Eigendommen { get; set; }

        public double BerekenWinst()
        {
            double opbrengstVanAlleEigendommen = 0;
            double loonkostVanAllePersonen = 0;

            foreach (Eigendom eigendom in Eigendommen)
            {
                opbrengstVanAlleEigendommen += eigendom.BerekenOpbrengst();
            }

            foreach (Persoon persoon in Personen)
            {
                loonkostVanAllePersonen += persoon.BerekenLoonKost();
            }

            return opbrengstVanAlleEigendommen - loonkostVanAllePersonen;
        }

        public override string ToString()
        {
            return $"{Naam} ({BTWNummer}) met winst {BerekenWinst()}.";
        }
    }
}
