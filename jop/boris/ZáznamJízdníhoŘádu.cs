using System;

namespace Boris
{
    public class ZáznamJízdníhoŘádu<T>
    {
        public ZáznamJízdníhoŘádu(T klíčZáznamu)
        {
            Klíč = klíčZáznamu;
            Příjezd = null;
            Odjezd = null;
        }

        public ZáznamJízdníhoŘádu(T klíčZáznamu, DateTime příjezd, DateTime odjezd, bool stavíZde, bool naZnamení)
        {
            Klíč = klíčZáznamu;
            Příjezd = příjezd;
            Odjezd = odjezd;
            StavíZde = stavíZde;
            NaZnamení = naZnamení;
        }

        public T Klíč
        {
            get;
            set;
        }

        public DateTime? Příjezd
        {
            get;
            set;
        }

        public DateTime? Odjezd
        {
            get;
            set;
        }

        public bool StavíZde
        {
            get;
            set;
        }

        public bool NaZnamení
        {
            get;
            set;
        }
    }
}

