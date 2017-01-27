using System;

namespace jop
{
    public struct NávěstHlavníhoNávěstidla
    {
        public NávěstHlavníhoNávěstidla(NávěstiHlavníhoNávěstidla návěst1, NávěstRychlostníSoustavy návěst2)
        {
            Návěst = návěst1;
            RychlostníSoustava = návěst2;
        }
        public NávěstiHlavníhoNávěstidla Návěst;
        public NávěstRychlostníSoustavy RychlostníSoustava;
    }
}

