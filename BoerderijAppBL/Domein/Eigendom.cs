namespace BoerderijApp_BL.Domein
{
    public abstract class Eigendom
    {
        public Eigendom(string naam, double kost)
        {
            Naam = naam;
            Kost = kost;
        }

        public string Naam { get; set; }
        protected double Kost { get; set; }

        public abstract double BerekenOpbrengst();

        public override string ToString()
        {
            return $"{typeof(Eigendom)} \" {Naam} \" met kost {Kost}";
        }
    }
}