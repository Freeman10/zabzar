using System;
using System.Collections;
using System.Collections.Generic;

namespace Boris
{
    public class VlakovýHlasatel : Hlasatel
    {
        /*public VlakovýHlasatel() : base()
        {
        }

        public VlakovýHlasatel(Vlak vlak)
        {
            foreach (ZáznamJízdníhoŘádu<Stanice> záznam in vlak.Trasa.Záznamy)
            {
                if (záznam.StavíZde == true)
                {
                    FrontaHlášení.Enqueue(new VlakovéHlášení.PříštíStanice(záznam.Klíč));
                    FrontaHlášení.Enqueue(new VlakovéHlášení.PříjezdDoStanice(záznam.Klíč));
                }
            }
            VyberDalší();
        }

        private Hlášení VybranéHlášení
        {
            get;
            set;
        }

        public void VyberDalší()
        {
            VybranéHlášení = FrontaHlášení.Dequeue();
        }

        public void OhlašPříští(Stanice stanice)  // Ohlášení zadané příští stanice.
        {
            //Ohlaš(new VlakovéHlášení.PříštíStanice(stanice));
        }

        public void Ohlaš(Stanice stanice)  // Ohlášení příjezdu do zadané stanice.
        {
            //Ohlaš(new VlakovéHlášení.PříjezdDoStanice(stanice));
        }

        /*protected override void SložHlášení(Hlášení hlášení)
        {
            throw new NotImplementedException();
        }*/
    }
}

