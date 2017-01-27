using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Boris
{
    public partial class StaničníHlášení : Hlášení
    {
        public StaničníHlášení(string druh, ArrayList proměnné)
        {
            Předloha = new ParserHlášení("whatever.abc").ZískejŠablonuHlášení(druh);
            Proměnné = proměnné;
            ZkontrolujTypParametrů();
            Vykonávač = new ParserPříkazů(Předloha, Proměnné);
            SložHlášení();
        }

        public StaničníHlášení(ŠablonaHlášení šablona, ArrayList proměnné)
        {
            Předloha = šablona;
            Proměnné = proměnné;
            ZkontrolujTypParametrů();
            Vykonávač = new ParserPříkazů(Předloha, Proměnné);
            SložHlášení();
        }

        private ParserPříkazů Vykonávač
        {
            get;
            set;
        }

        protected ŠablonaHlášení Předloha
        {
            get;
            set;
        }

        protected ArrayList Proměnné
        {
            get;
            set;
        }

        protected void ZkontrolujTypParametrů()
        {
            for (int i = 0; i < Předloha.TypyProměnných.Count; i++)
            {
                Type typ = Předloha.TypyProměnných[i];
                if (typ != Proměnné[i].GetType())
                {
                    throw new ArrayTypeMismatchException();
                }
            }
        }

        protected override void SložHlášení()
        {
            List<string> tvar = new List<string>();

            foreach (string příkaz in Předloha.Tvar)
            {
                Vykonávač.Příkaz = příkaz;
                tvar.AddRange(Vykonávač.Výsledek);  
            }

            Tvar = tvar.ToArray();
        }












        sealed class ParserPříkazů  // Pouze vnitřní třída pro potřeby třídy StaničníHlasatel.
        {
            public ParserPříkazů(ŠablonaHlášení šablona, ArrayList proměnné)
            {
                Předloha = šablona;
                Proměnné = proměnné;
            }

            private ŠablonaHlášení Předloha
            {
                get;
            }

            private ArrayList Proměnné
            {
                get;
            }

            public string Příkaz  // Parsovaný příkaz
            {
                get;
                set;
            }

            public string[] Výsledek  // Výsledek provedení příkazu
            {
                get
                {
                    return ProveďPříkaz();
                }
            }

            private string[] ProveďPříkaz()
            {
                string[] parametry = Příkaz.Split(':')[1].Split('.');
                switch (Příkaz.Split(':')[0])
                {
                    case "phrase":
                        {
                            return new string[] {Příkaz.Split(':')[1]};
                        }
                    case "var":
                        {
                            return PracujSHodnotou(parametry);
                        }
                }
                return new string[]{ };
            }

            private string[] PracujSHodnotou(string[] parametry)  // Metoda vykonává operace s proměnnými
            {
                Type typ = Předloha.TypyProměnných[Convert.ToInt32(parametry[0])];

                switch (typ.ToString())
                {
                    case "Boris.Vlak()":
                        {
                            return ParsujVlak(parametry);
                        }
                    case "System.Int32()":
                        {
                            break;
                        }
                }
                return new string[]{ };
            }

            private string[] ParsujVlak(string[] parametry)  // Metoda vykonává operace s třídou Vlak
            {
                switch (parametry[1])
                {
                    case "Název":
                        {
                            return Hlášení.ParsujVlak((Vlak)Proměnné[0]);   //Jiné ParsujVlak, než toto!
                        }
                    case "ZeSměru":
                        {
                            Vlak vlak = (Vlak)Proměnné[0];
                            return new string[] {vlak.SměrZ.ToString()};
                        }
                    case "VeSměru":
                        {
                            Vlak vlak = (Vlak)Proměnné[0];
                            return new string[] {vlak.SměrDo.ToString()};
                        }
                    case "Příjezd":
                        {
                            Vlak vlak = (Vlak)Proměnné[0];
                            return ParsujČas(vlak.Trasa.Záznamy[0].Příjezd);
                        }
                }
                return new string[]{ };
            }

            private string[] ParsujČas(DateTime? čas)  // Metoda parsuje čas (přidává slova hodin(a/y) a minut(a/y).
            {
                List<string> fráze = new List<string>();
                if (čas != null)
                {
                    DateTime nenulovýčas = (DateTime)čas;
                    fráze.Add("hodina-");  // TUHLE ČÁST NUTNO SPRAVIT PRO INTERNACIONALIZACI!
                    fráze.Add("číslo-" + nenulovýčas.Hour.ToString());  // TUHLE TAKY!
                    switch (nenulovýčas.Hour)
                    {
                        case 1:
                            {
                                fráze.Add("hodina-j");  // TADY TAKY...
                                break;
                            }
                        case 2:
                        case 3:
                        case 4:
                            {
                                fráze.Add("hodina-m1");  // A TADY
                                break;
                            }
                        default:
                            {
                                fráze.Add("hodina-m2");  // A TADY
                                break;
                            }
                    }
                    fráze.Add("číslo-" + nenulovýčas.Minute.ToString());
                    switch (nenulovýčas.Minute)
                    {
                        case 1:
                            {
                                fráze.Add("minuta-j");  // A TADY
                                break;
                            }
                        case 2:
                        case 3:
                        case 4:
                            {
                                fráze.Add("minuta-m1");  // A TADY
                                break;
                            }
                        default:
                            {
                                fráze.Add("minuta-m2");  // A KONEČNĚ I TADY
                                break;
                            }
                    }
                    return fráze.ToArray();
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }

    }
}

