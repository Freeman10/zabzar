using System;

namespace jop
{
    public abstract class Výhybka<TStav> where TStav : struct
	{
        public Výhybka()
        {
        }

        public TStav Stav
        {
            get
            {
                return ZjistiStav();
            }
        }

        private TStav ZjistiStav()  // Komunikace s HW zde!
        {
            throw new NotImplementedException();
        }

        public void Přehoď(TStav poloha)  // Komunikace s HW zde
        {
            
        }
	}
}

