using System;

namespace jop
{
    public abstract class HlavníNávěstidlo : Návěstidlo<NávěstiHlavníhoNávěstidla>
    {
        public HlavníNávěstidlo()
        {
        }

        protected NávěstiHlavníhoNávěstidla[] ZakázanéNávěsti
        {
            get;
            set;
        }

        public override NávěstiHlavníhoNávěstidla Návěst
        {
            get
            {
                return base.Návěst;
            }
            set
            {
                foreach (NávěstiHlavníhoNávěstidla návěst in ZakázanéNávěsti)
                {
                    if (value == návěst)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        public bool PřívolávacíNávěst
        {
            get;
            set;
        }
    }
}

