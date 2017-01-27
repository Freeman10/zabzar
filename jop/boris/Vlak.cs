using System;

namespace Boris
{
    public class Vlak
    {
        public Vlak()  // Má smysl deklarovat vlak, aniž bych o něm něco věděl?
        {
            Jméno = null;
            Druh = DruhVlaku.Os;
            Číslo = 0;  // Výchozí hodnota
            Trasa = null;
            Zpoždění = TimeSpan.Zero;
        }

        public Vlak(DruhVlaku druh, uint číslo, string jméno, SlužbyVlaku služby, JízdníŘád<Stanice> jízdníŘád)
        {
            Jméno = jméno;
            Druh = druh;
            Číslo = číslo;  // Výchozí hodnota
            Trasa = jízdníŘád;
            Zpoždění = TimeSpan.Zero;
            Služby = služby;
        }
        public Vlak(DruhVlaku druh, uint číslo, string jméno, string linka, SlužbyVlaku služby, JízdníŘád<Stanice> jízdníŘád)
        {
            Jméno = jméno;
            Druh = druh;
            Číslo = číslo;  // Výchozí hodnota
            Trasa = jízdníŘád;
            Zpoždění = TimeSpan.Zero;
            Služby = služby;
            Linka = linka;
        }

        public Vlak(DruhVlaku druh, uint číslo, string jméno, SlužbyVlaku služby, JízdníŘád<Stanice> jízdníŘád, TimeSpan zpoždění)
        {
            Jméno = jméno;
            Druh = druh;
            Číslo = číslo;  // Výchozí hodnota
            Trasa = jízdníŘád;
            Zpoždění = TimeSpan.Zero;
            Služby = služby;
        }

        public Vlak(DruhVlaku druh, uint číslo, string jméno, SlužbyVlaku služby, string linka, JízdníŘád<Stanice> jízdníŘád, TimeSpan zpoždění)
        {
            Jméno = jméno;
            Druh = druh;
            Číslo = číslo;  // Výchozí hodnota
            Trasa = jízdníŘád;
            Zpoždění = TimeSpan.Zero;
            Služby = služby;
            Linka = linka;
        }
            

        public uint Číslo  // Číslo vlaku. Není lepší typ než int?
        {
            get;
        }

        public string Jméno  // Nějak ošetřit, aby jméno vlaku nebylo jfhgůjdfvbflv-spúfls)úůf)dúf-sú
        {
            get;
            private set;
        }

        public DruhVlaku Druh
        {
            get;
            set;
        }

        public SlužbyVlaku? Služby
        {
            get;
            set;
        }

        public string Linka
        {
            get;
            set;
        }

        public string Dopravce
        {
            get;
            set;
        }

        public JízdníŘád<Stanice> Trasa  // Možná vymyslet lepší jméno...
        {
            get;
            set;
        }

        public Stanice SměrDo
        {
            get
            {
                return Trasa.Záznamy[Trasa.Záznamy.Count - 1].Klíč;
            }
        }

        public Stanice SměrZ
        {
            get
            {
                return Trasa.Záznamy[0].Klíč;
            }
        }
            

        public TimeSpan Zpoždění
        {
            get;
            set;
        }

        public bool Mimořádný
        {
            get;
            set;
        }

        public override int GetHashCode()
        {
            return Číslo.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var vlak = obj as Vlak;
            if (vlak != null)
            {
                return this.Číslo == vlak.Číslo;
            }
            return false;
        }
    }
}

