using System;
using System.Collections.Generic;

namespace Boris
{
    public class JízdníŘád<T>
    {
        public JízdníŘád()
        {
            Záznamy = new List<ZáznamJízdníhoŘádu<T>>();
        }

        public List<ZáznamJízdníhoŘádu<T>> Záznamy
        {
            get;
            set;
        }

        public void OvěřIntegritu()  // Metoda zjišťuje, zda-li je takový jízdní řád možný.
        {
            foreach (ZáznamJízdníhoŘádu<T> záznam in Záznamy)
            {
                if (záznam.Odjezd.HasValue && záznam.Příjezd.HasValue)
                {
                    if (záznam.Odjezd < záznam.Příjezd)
                    {
                        throw new DataMisalignedException();
                    }
                }
            }
        }
    }
}

