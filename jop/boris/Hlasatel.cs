using System;
using System.Collections;
using System.Collections.Generic;
using System.Media;
using System.Threading;

namespace Boris
{
    public abstract class Hlasatel
    {
        public Hlasatel()
        {
            Přehrávač = new SoundPlayer();
            Zpráva = new List<string>();
            FrontaHlášení = new Queue<Hlášení>();
            SeznamFrází = new Dictionary<string, string>();
            // Přidání frází z XML souboru ošetřeno v potomcích
        }

        protected SoundPlayer Přehrávač
        {
            get;
            set;
        }

        protected List<string> Zpráva
        {
            get;
            set;
        }

        protected Dictionary<string, string> SeznamFrází
        {
            get;
            set;
        }

        public Queue<Hlášení> FrontaHlášení
        {
            get;
            set;
        }

        protected void PřehrajZnělku(DruhZnělky druh)
        {
            switch (druh)
            {
                case DruhZnělky.ÚvodníZnělka:
                    {
                        Přehrávač.SoundLocation = "/media/Media/Audacity/Andula zvon/ding_on.wav";
                        break;
                    }
                case DruhZnělky.ZávěrečnáZnělka:
                    {
                        Přehrávač.SoundLocation = "/media/Media/Audacity/Andula zvon/ding_off.wav";
                        break;
                    }
                case DruhZnělky.Předěl:
                    {
                        Přehrávač.SoundLocation = "/media/Media/Audacity/Andula předěl.wav";
                        break;
                    }
                default:
                    break;
            }
            Přehrávač.PlaySync();
            Thread.Sleep(500);
        }

        public void OhlašVše()
        {
            PřehrajZnělku(DruhZnělky.ÚvodníZnělka);
            while (FrontaHlášení.Count > 0)
            {
                Ohlaš(false);
                if (FrontaHlášení.Count > 0)
                {
                    PřehrajZnělku(DruhZnělky.Předěl);
                }
            }
            PřehrajZnělku(DruhZnělky.ZávěrečnáZnělka);
        }

        public void Ohlaš(bool znělka)
        {
            Hlášení hlášení = FrontaHlášení.Dequeue();
            Ohlaš(hlášení.Tvar, znělka);
        }

        public void Ohlaš(List<string> zpráva, bool znělka)
        {
            Zpráva = zpráva;
            Ohlaš(Zpráva.ToArray(), znělka);
        }

        public void Ohlaš(string[] zpráva, bool znělka)
        {
            Zpráva.Clear();
            foreach (string slovo in zpráva)
            {
                Zpráva.Add(slovo);
            }
            if (znělka)
            {
                PřehrajZnělku(DruhZnělky.ÚvodníZnělka);
            }
            foreach (string slovo in Zpráva)
            {
                Přehrávač.SoundLocation = "/media/junkyard/Github/zabzar" + SeznamFrází[slovo];
                Přehrávač.PlaySync();
                Thread.Sleep(500);
            }
            if (znělka)
            {
                PřehrajZnělku(DruhZnělky.ZávěrečnáZnělka);
            }
        }
    }
}

