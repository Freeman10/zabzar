using System;

namespace Boris
{
    public partial class StaničníHlasatel
    {
        class ParserPříkazů  // Pouze vnitřní třída pro potřeby třídy StaničníHlasatel.
        {
            public ParserPříkazů(string příkaz)
            {
                Příkaz = příkaz;
            }

            public string Příkaz  // Parsovaný příkaz
            {
                get;
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
                return new string[]{};
            }

            private string[] PracujSHodnotou(string[] parametry)
            {
                Type typ = Předloha.TypyProměnných[parametry[0]];

                switch (typ)
                {
                    case Boris.Vlak:
                        {
                            return ParsujVlak(parametry);
                        }
                    case System.Int32:
                        {
                            
                            break;
                        }
                    default:
                        break;
                }
            }

            private string[] ParsujVlak(string[] parametry)
            {
                switch (parametry[1])
                {
                    case "":
                        {
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}

