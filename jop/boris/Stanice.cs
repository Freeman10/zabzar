using System;

namespace Boris
{
    public class Stanice : Dopravna
    {
        public Stanice(string název) : base(název)
        {
            Název = název;
            Spoje = new JízdníŘád<Vlak>();
        }

        public JízdníŘád<Vlak> Spoje
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
            var stanice = obj as Stanice;
            if (stanice != null)
            {
                return this.Název == stanice.Název;
            }
            return false;
        }
    }
}

