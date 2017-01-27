using System;

namespace jop
{
    public class VjezdovéNávěstidlo : HlavníNávěstidlo
    {
        public VjezdovéNávěstidlo(Směr směr)  // Pro jednokolejné tratě.
        {
            ZakázanéNávěsti = new NávěstiHlavníhoNávěstidla[]
            {
                NávěstiHlavníhoNávěstidla.JízdaPodleRozhledovýchPoměrů,
                NávěstiHlavníhoNávěstidla.JízdaPodleRozhledovýchPoměrůARychlost40,
                NávěstiHlavníhoNávěstidla.OdjezdovéNávěstidloDovolujeJízdu,
                NávěstiHlavníhoNávěstidla.PosunZakázán
            };
            //ZákladníNávěst = NávěstiHlavníhoNávěstidla.Stůj;
            if (směr == Směr.Lichý)
            {
                Označení = "L";
            }
            if (směr == Směr.Sudý)
            {
                Označení = "S";
            }
        }

        public VjezdovéNávěstidlo(Směr směr, Kolej kolej)  // Pro vícekolejné tratě
        {
            ZakázanéNávěsti = new NávěstiHlavníhoNávěstidla[]
            {
                NávěstiHlavníhoNávěstidla.JízdaPodleRozhledovýchPoměrů,
                NávěstiHlavníhoNávěstidla.JízdaPodleRozhledovýchPoměrůARychlost40,
                NávěstiHlavníhoNávěstidla.OdjezdovéNávěstidloDovolujeJízdu,
                NávěstiHlavníhoNávěstidla.PosunZakázán
            };
            //ZákladníNávěst = NávěstiHlavníhoNávěstidla.Stůj;
            if (směr == Směr.Lichý)
            {
                Označení = kolej.Číslo.ToString() + "L";
            }
            if (směr == Směr.Sudý)
            {
                Označení = kolej.Číslo.ToString() + "S";
            }
        }

        public VjezdovéNávěstidlo(Směr směr, string jménoSousedníDopravny)  // Pro jednokolejné tratě s odbočkou
        {
            ZakázanéNávěsti = new NávěstiHlavníhoNávěstidla[]
            {
                NávěstiHlavníhoNávěstidla.JízdaPodleRozhledovýchPoměrů,
                NávěstiHlavníhoNávěstidla.JízdaPodleRozhledovýchPoměrůARychlost40,
                NávěstiHlavníhoNávěstidla.OdjezdovéNávěstidloDovolujeJízdu,
                NávěstiHlavníhoNávěstidla.PosunZakázán
            };
            //ZákladníNávěst = NávěstiHlavníhoNávěstidla.Stůj;
            if (směr == Směr.Lichý)
            {
                Označení = jménoSousedníDopravny.ToCharArray()[0] + "L";
            }
            if (směr == Směr.Sudý)
            {
                Označení = jménoSousedníDopravny.ToCharArray()[0] + "S";
            }
        }

        public VjezdovéNávěstidlo(Směr směr, Kolej kolej, string jménoSousedníDopravny)  // Pro vícekolejné tratě s odbočkou
        {
            ZakázanéNávěsti = new NávěstiHlavníhoNávěstidla[]
            {
                NávěstiHlavníhoNávěstidla.JízdaPodleRozhledovýchPoměrů,
                NávěstiHlavníhoNávěstidla.JízdaPodleRozhledovýchPoměrůARychlost40,
                NávěstiHlavníhoNávěstidla.OdjezdovéNávěstidloDovolujeJízdu,
                NávěstiHlavníhoNávěstidla.PosunZakázán
            };
            //ZákladníNávěst = NávěstiHlavníhoNávěstidla.Stůj;
            if (směr == Směr.Lichý)
            {
                Označení = (kolej.Číslo.ToString() + jménoSousedníDopravny.ToCharArray()[0] + "L").ToUpper();
            }
            if (směr == Směr.Sudý)
            {
                Označení = (kolej.Číslo.ToString() + jménoSousedníDopravny.ToCharArray()[0] + "S").ToUpper();
            }
        }
    }
}

