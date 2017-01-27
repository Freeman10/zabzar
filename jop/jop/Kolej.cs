using System;

namespace jop
{
    public class Kolej : IPrvekKolejiště //Základní třída mající jen nejdůležitější věci
	{
        public Kolej(uint číslo)
        {
            PřipojenáVýkolejka = new Výkolejka[2] { null, null };
            Číslo = číslo;
        }
        public Výkolejka[] PřipojenáVýkolejka
		{
			get;
			set;
		}

        public IzolovanýÚsek[] Úseky
        {
            get;
            set;
        }

        public uint Číslo
        {
            get;
        }





        // Implementace rozhraní IPrvekKolejiště



        public IPrvekKolejiště[] PředchozíPrvky
        {
            get;
            set;
        }
        public IPrvekKolejiště[] NásledujícíPrvky
        {
            get;
            set;
        }
	}
}

