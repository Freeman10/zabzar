using System;
using System.Collections;
using System.Collections.Generic;

namespace jop
{
    public class VlakováCesta
    {
        public VlakováCesta(IzolovanýÚsek počátek, IzolovanýÚsek konec)
        {
            Počátek = počátek;
            Konec = konec;
        }

        public VlakováCesta(IzolovanýÚsek počátek, IzolovanýÚsek konec, IzolovanýÚsek[] variantníBody)
        {
            
        }

        public IzolovanýÚsek Počátek
        {
            get;
        }

        protected IzolovanýÚsek[] VariantníBody
        {
            get;
        }

        public IzolovanýÚsek Konec
        {
            get;
        }

        /*public IzolovanýÚsek[] Trasa
        {
            get
            {
                if (VariantníBody.GetLength(1) == 0)
                {
                    NajdiTrasu();
                }
                else
                {
                    NajdiTrasu(VariantníBody);
                }
            }
        }*/

        /*protected IzolovanýÚsek[] NajdiTrasu()
        {
            
        }*/

        protected IzolovanýÚsek[] NajdiTrasu(IzolovanýÚsek[] variantníBody)
        {
            List<IzolovanýÚsek> trasa = new List<IzolovanýÚsek>();
            IzolovanýÚsek odsud;
            IzolovanýÚsek sem = Počátek;
            for (int i = 0; i < variantníBody.GetLength(1); i++)
            {
                odsud = sem;
                sem = variantníBody[i];
                /*foreach (IzolovanýÚsek úsek in new VlakováCesta(odsud, sem))
                {
                    trasa.Add(úsek);
                }*/
            }

            odsud = sem;
            sem = Konec;
            /*foreach (IzolovanýÚsek úsek in new VlakováCesta(odsud, sem))
            {
                trasa.Add(úsek);
            }*/
            return trasa.ToArray();
        }
    }
}

