namespace BoerderijApp_BL.Domein
{
    public abstract class Persoon
    {
        private string? _naam;

        public Persoon(string naam, DateTime geboorteDatum)
        {
            Naam = naam;
            if (geboorteDatum > (DateTime.Now.AddYears(-18)))
            {
                throw new ArgumentException("Persoon - de persoon is jonger dan 18 jaar.");
            }
            GeboorteDatum = geboorteDatum;
        }

        public string Naam
        {
            get {return _naam; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Persoon - Een persoon moet een naam hebben");
                _naam = value;
            }
        }
        public DateTime GeboorteDatum { get; init; }

        public override string ToString()
        {
            return $" {GetType().Name} {Naam} ({GeboorteDatum.ToShortDateString()})";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public virtual double BerekenLoonKost()
        {
            return 0.0;
        }
    }
}