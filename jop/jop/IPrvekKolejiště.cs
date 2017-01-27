using System;

namespace jop
{
    public interface IPrvekKolejiště
    {
        IPrvekKolejiště[] PředchozíPrvky
        {
            get;
            set;
        }

        IPrvekKolejiště[] NásledujícíPrvky
        {
            get;
            set;
        }
    }
}

