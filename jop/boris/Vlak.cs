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

        public Vlak(DruhVlaku druh, int číslo, string jméno, JízdníŘád<Stanice> jízdníŘád)
        {
            Jméno = jméno;
            Druh = druh;
            Číslo = číslo;  // Výchozí hodnota
            Trasa = jízdníŘád;
            Zpoždění = TimeSpan.Zero;
        }

        public Vlak(DruhVlaku druh, int číslo, string jméno, JízdníŘád<Stanice> jízdníŘád, TimeSpan zpoždění)
        {
            Jméno = jméno;
            Druh = druh;
            Číslo = číslo;  // Výchozí hodnota
            Trasa = jízdníŘád;
            Zpoždění = TimeSpan.Zero;
        }
            

        public int Číslo  // Číslo vlaku. Není lepší typ než int?
        {
            get;
            set;
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

        public JízdníŘád<Stanice> Trasa  // Možná vymyslet lepší jméno...
        {
            get;
            set;
        }

//        public Stanice SměrDo
//        {
//            get
//            {
//                return Trasa;
//            }
//        }

//        public Stanice SměrZ
//        {
//            get
//            {
//                return Trasa[0];
//            }
//        }
            

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

