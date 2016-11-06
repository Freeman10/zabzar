using System;

namespace Boris
{
    public abstract class Dopravna  // Obecná dopravna
    {
        public Dopravna(string název)
        {
            Název = název;
            Rozpis = new JízdníŘád<Vlak>();
        }

        public Dopravna(string název, JízdníŘád<Vlak> rozpis)
        {
            Název = název;
            Rozpis = rozpis;
        }

        public string Název  // Název dopravny
        {
            get;
            set;
        }

        public JízdníŘád<Vlak> Rozpis  // Rozpis dopravny
        {
            get;
            set;
        }

        public double Poloha  // Kilometrická poloha dopravny
        {
            get;
            set;
        }

        public override int GetHashCode()
        {
            return Název.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var dopravna = obj as Dopravna;
            if (dopravna != null)
            {
                return this.Název == dopravna.Název;
            }
            return false;
        }
    }
}

