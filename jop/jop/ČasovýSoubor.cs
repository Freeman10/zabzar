using System;
using System.Threading;

namespace jop
{
    public class ČasovýSoubor
    {
        protected ČasovéSoubory? _vybranýSoubor;  // Tohle je nutné, kvůli definovanému setteru a getteru vlastnosti VybranýSoubor.

        public ČasovýSoubor()
        {
            VybranýSoubor = null;
        }

        public event EventHandler ČasVypršel;  // Událost vyvolaná při vyprčení časového souboru.

        protected virtual void KdyžČasVypršel(EventArgs e)  // Handler pro událost ČasVypršel.
        {
            EventHandler handler = ČasVypršel;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public ČasovéSoubory? VybranýSoubor  // Musí být nullable, protože nemusí být vybraný žádný časový soubor.
        {
            get
            {
                return _vybranýSoubor;  // Tohle je nutné kvůli vlastnímu setteru.
            }
            set
            {
                _vybranýSoubor = value;
                if (value != null)  // Ochrana proti nekonečné smyčce. Navíc nemá smysl počítat "žádnou" dobu.
                {
                    PočítejDobu();
                }
            }
        }

        protected void PočítejDobu()
        {
            switch (VybranýSoubor)
            {
                case ČasovéSoubory.PětSekund:
                    {
                        Thread.Sleep(5 * 1000); // 5 * 1000 ms = 5 s
                        KdyžČasVypršel(EventArgs.Empty);
                        VybranýSoubor = null;
                        break;
                    }
                case ČasovéSoubory.JednaMinuta:
                    {
                        Thread.Sleep(60 * 1000); // 60 * 1000 ms = 60 s = 1 min
                        KdyžČasVypršel(EventArgs.Empty);
                        VybranýSoubor = null;
                        break;
                    }
                case ČasovéSoubory.TřiMinuty:
                    {
                        Thread.Sleep(3 * 60 * 1000); // 3 * 60 * 1000 ms = 3 * 60 s = 3 * 1 min = 3 min
                        KdyžČasVypršel(EventArgs.Empty);
                        VybranýSoubor = null;
                        break;
                    }
            }
        }
    }
}

