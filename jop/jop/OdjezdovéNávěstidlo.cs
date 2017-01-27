using System;

namespace jop
{
    public class OdjezdovéNávěstidlo : HlavníNávěstidlo
    {
        public OdjezdovéNávěstidlo(Směr směr, Kolej kolej)
        {
            if (směr == Směr.Lichý)
            {
                Označení = ("L" + kolej.Číslo.ToString()).ToUpper();
            }
            if (směr == Směr.Sudý)
            {
                Označení = ("S" + kolej.Číslo.ToString()).ToUpper();
            }
        }

        public OdjezdovéNávěstidlo(Směr směr, string jménoSousedníDopravny)
        {
            if (směr == Směr.Lichý)
            {
                Označení = ("L" + jménoSousedníDopravny.ToCharArray()[0]).ToUpper();
            }
            if (směr == Směr.Sudý)
            {
                Označení = ("S" + jménoSousedníDopravny.ToCharArray()[0]).ToUpper();
            }
        }

        public OdjezdovéNávěstidlo(Směr směr, Kolej kolej, string jménoSousedníDopravny)
        {
            if (směr == Směr.Lichý)
            {
                Označení = ("L" + jménoSousedníDopravny.ToCharArray()[0] + kolej.Číslo.ToString()).ToUpper();
            }
            if (směr == Směr.Sudý)
            {
                Označení = ("S" + jménoSousedníDopravny.ToCharArray()[0] + kolej.Číslo.ToString()).ToUpper();
            }
        }
    }
}

