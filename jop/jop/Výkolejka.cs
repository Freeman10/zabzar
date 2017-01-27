using System;

namespace jop
{
    public class Výkolejka
    {
        public Výkolejka(uint číslo)
        {
            Označení = "Vk" + číslo.ToString();
        }

        public string Označení
        {
            get;
        }

        public bool NaKoleji
        {
            get;
            set;
        }
    }
}

