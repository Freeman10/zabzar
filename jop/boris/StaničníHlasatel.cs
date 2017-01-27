using System;
using System.Collections;
using System.Collections.Generic;

namespace Boris
{
    public partial class StaničníHlasatel : Hlasatel
    {
        public StaničníHlasatel() : base()
        {
            foreach (var kvp in new ParserXml("/media/junkyard/Github/zabzar/jop/boris/bin/Debug/phrases.xml", "sound").Výsledky)
            {
                SeznamFrází.Add(kvp.Key, kvp.Value + "/" + kvp.Key + ".wav");
            }
        }

        public StaničníHlasatel(Stanice stanice)
        {
            
        }

        private bool PřipravenHlásit
        {
            set
            {
                Ohlaš(true);
            }
        }

        private bool JeCoHlásit
        {
            get
            {
                return !(FrontaHlášení.Count == 0);
            }
            set
            {
                if (value == true)
                {
                    //SložHlášení(FrontaHlášení.Dequeue());
                }
            }
        }

        /*protected override void SložHlášení(Hlášení hlášení)
        {
            foreach (string slovo in hlášení.Tvar)
            {
                string[] příkaz = slovo.Split(new char[]{'=', ';'});
                switch (příkaz[0])
                {
                    case "explicit":
                        {
                            Zpráva.Add(SeznamFrází[příkaz[1]]);
                            break;
                        }
                    case "train":
                        {
                            break;
                        }
                    case "time":
                        {
                            var čas = TimeSpan.Parse(příkaz[1]);
                            try
                            {
                                foreach (string číslo in ParsujČíslo(Convert.ToUInt32(čas.Hours)))
                                {
                                    Zpráva.Add(číslo);
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Aj, chyba!");
                            }

                            Zpráva.Add(SeznamFrází["hodin"]);

                            try
                            {
                                foreach (string číslo in ParsujČíslo(Convert.ToUInt32(čas.Minutes)))
                                {
                                    Zpráva.Add(číslo);
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Aj, chyba!");
                            }

                            Zpráva.Add(SeznamFrází["minut"]);

                            break;
                        }
                    default:
                        break;
                }
            }
            PřipravenHlásit = true;
        }*/
    }
}

