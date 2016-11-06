using System;

namespace jop
{
	public class Přejezd
	{
        public Přejezd(int číslo)
		{
            Číslo = číslo;
		}

        public int Číslo
        {
            get;
        }
		
        public StavPřejezdu Stav
        {
            get
            {
                return ZjistiStav();
            }
        }

        public bool Uzavřen  // Je přejezd uzavřen, tzn. jsou stažené závory nebo uplynulá předzváněcí doba u přejezdu bez závor?
        {
            get
            {
                return ZjistiUzavření();
            }
        }

        private bool ZjistiUzavření()  // Komunikace s HW zde!
        {
            return false;
        }

        private StavPřejezdu ZjistiStav()  // Komunikace s HW zde!
        {
            return StavPřejezdu.Základní;
        }

        public void UzavřiPřejezd()  // Komunikace s HW zde!
        {
            
        }

        public void OtevřiPřejezd()  // Komunikace s HW zde!
        {
            
        }

        public override string ToString()
        {
            return "P" + Číslo.ToString();
        }

        public override int GetHashCode()
        {
            return Číslo.GetHashCode();
        }
	}
}

