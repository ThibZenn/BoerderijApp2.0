using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoerderijApp_BL.Domein;
using BoerderijApp_BL.Enums;

namespace BoerderijAppBL.Cui
{
    public class BoerderijApplication
    {
        public void Run()
        {
            List<Persoon> personen = new List<Persoon>
            {
                new Boer("Emzara",new DateTime(1960,02,29), 40.90),
                new Boer("Japheth", new DateTime(1985,12,21), 9.00),
                new Boer("Japheth", new DateTime(1955, 06, 21), 9.00),
                new Werknemer("Michaël", new DateTime(1989, 11, 09), 2610),
                new Werknemer("Pieter", new DateTime(2006, 05, 12)),
                new Werknemer("Samaël", new DateTime(1990, 08, 02), 2415.7)

            };
            List<Eigendom> eigendommen = new List<Eigendom>
            {
                new Akker("Achteraan",4000,300, GewasEnum.Aardappel),
                new Akker("Oostkant",12000,600, GewasEnum.Hop),
                new Melkerij("Melkerij 1", 21000, 500),
                new Melkerij("Melkerij 2", 17000, 300)
            };
            Boerderij boerderij = new Boerderij("De Ark", "BE012345567", personen, eigendommen);

            Console.WriteLine(boerderij.ToString());
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Overzicht van personen:");
            foreach (Persoon persoon in boerderij.Personen)
            {
                Console.WriteLine(persoon.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Overzicht van eigendommen:");
            foreach (Eigendom eigendom in boerderij.Eigendommen)
            {
                Console.WriteLine(eigendom.ToString());
            }
        }
    }
}
