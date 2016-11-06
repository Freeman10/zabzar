using System;

namespace jop
{
	public class Kolej  //Základní třída mající jen nejdůležitější věci
	{
		public Kolej()
        {
			
        }
		public bool Výkolejka
		{
			get;
			set;
		}
        public Kolej LicháNávaznost
        {
            get;
            set;
        }
        public Kolej SudáNávaznost
        {
            get;
            set;
        }
	}
}

