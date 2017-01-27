using System;
using System.Collections;
using System.Collections.Generic;

namespace jop
{
	public class IzolovanýÚsek
	{
		public IzolovanýÚsek()
		{
            
		}

        public IzolovanýÚsek NásledujícíÚsek
        {
            get;
        }

        public IzolovanýÚsek PředchozíÚsek
        {
            get;
        }

        public bool Obsazený
        {
            get;
        }

        public bool Závěr
        {
            get;
        }
	}
}

