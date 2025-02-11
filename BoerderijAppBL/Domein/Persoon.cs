namespace BoerderijApp_BL.Domein
{
    public abstract class Persoon
    {
        private string? _naam; //waarom een ? als het niet leeg mag zijn?

        protected Persoon(string naam, DateTime geboorteDatum)
        {
            Naam = naam;
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
        public DateTime GeboorteDatum { get; init; } //TODO: minstens 18 jaar oud

        public override string ToString()
        {
            return $" {typeof(Persoon)} {Naam} ({GeboorteDatum})";
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