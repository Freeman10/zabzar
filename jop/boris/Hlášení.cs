using System;
using System.Media;
using System.Threading;
using System.Xml;
using System.Collections;
using System.Collections.Generic;

namespace Boris
{
    public abstract class Hlášení
    {
        public Hlášení()
        {
            SeznamFrází = new ParserXml("/media/junkyard/Github/zabzar/jop/boris/bin/Debug/phrases.xml", "text").Výsledky;
        }

        protected Dictionary<string, string> SeznamFrází
        {
            get;
            set;
        }

        public string[] Tvar
        {
            get;
            set;
        }

        protected abstract void SložHlášení();

        public string[] VypišČíslo(uint číslo)  // Nechce se mi všude psát .ToString();
        {
            return VypišČíslo(číslo.ToString());
        }

        protected string[] VypišČíslo(string číslo)  // Parsuje čísla
        {
            List<string> parsát = new List<string>();

            if (číslo.Length <= 3)
            {
                return VypišČíslo(číslo.ToCharArray());
            }
            switch (číslo.Length % 3)
            {
                case 0:
                    {
                        foreach (string slovo in VypišČíslo(číslo.Substring(0, 3)))
                        {
                            parsát.Add(slovo);
                        }
                        foreach (string slovo in VypišČíslo(číslo.Remove(0, 3)))
                        {
                            parsát.Add(slovo);
                        }
                        return parsát.ToArray();
                    }
                case 1:
                case 2:
                    {
                        foreach (string slovo in VypišČíslo(číslo.Substring(0, 2)))
                        {
                            parsát.Add(slovo);
                        }
                        foreach (string slovo in VypišČíslo(číslo.Remove(0, 2)))
                        {
                            parsát.Add(slovo);
                        }
                        return parsát.ToArray();
                    }
                default:
                    break;
            }

            return parsát.ToArray();
        }

        protected string[] VypišČíslo(char[] číslo)  // Parsuje dílčí skupiny čísel (max. velikost 3 číslice).
        {
            List<string> parsát = new List<string>();
            switch (číslo.Length)
            {
                case 1:
                    {
                        parsát.Add(SeznamFrází[číslo[0].ToString()]);
                        break;
                    }
                case 2:
                    {
                        switch (číslo[0])
                        {
                            case '0':
                                {
                                    parsát.Add(SeznamFrází["0"]);
                                    parsát.Add(SeznamFrází[číslo[1].ToString()]);  // Pro přehlednost: Metoda VypišČíslo je typu string[] a jako parametr má char[].
                                    break;
                                }
                            case '1':
                                {
                                    parsát.Add(SeznamFrází[(Convert.ToInt32(číslo[0].ToString()) * 10 + Convert.ToInt32(číslo[1].ToString())).ToString()]);
                                    // Ach jo, to je zase nudlepříkaz, kdo se v tom má vyznat?!
                                    // Prostě se sčítá hodnota číslice desítek * 10 a hodota číslice jednotek.
                                    break;
                                }
                            default:
                                {
                                    parsát.Add(SeznamFrází[(Convert.ToInt32(číslo[0].ToString()) * 10).ToString()]);  // Vážně bych s těma nudlema měl přestat.
                                    if (číslo[1] != '0')
                                    {
                                        parsát.Add(SeznamFrází[(Convert.ToInt32(číslo[1].ToString())).ToString()]);  // Tak třeba příště. :)
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        parsát.Add(SeznamFrází[(Convert.ToInt32(číslo[0].ToString()) * 100).ToString()]);
                        if (číslo[1] == '0' && číslo[0] != '0')
                        {
                            foreach (string slovo in VypišČíslo(new char[] {číslo[2]}))  // Řešení dvojciferného čísla už existuje.
                            {
                                parsát.Add(slovo);
                            }
                        }
                        else
                        {
                            foreach (string slovo in VypišČíslo(new char[] {číslo[1], číslo[2]}))  // Řešení dvojciferného čísla už existuje.
                            {
                                parsát.Add(slovo);
                            }
                        }
                        break;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException();
                    }
            }
            return parsát.ToArray();
        }

        public static string[] ParsujČíslo(uint číslo)  // Nechce se mi všude psát .ToString();
        {
            return ParsujČíslo(číslo.ToString());
        }

        protected static string[] ParsujČíslo(string číslo)  // Parsuje čísla
        {
            List<string> parsát = new List<string>();

            if (číslo.Length <= 3)
            {
                return ParsujČíslo(číslo.ToCharArray());
            }
            switch (číslo.Length % 3)
            {
                case 0:
                    {
                        foreach (string slovo in ParsujČíslo(číslo.Substring(0, 3)))
                        {
                            parsát.Add(slovo);
                        }
                        foreach (string slovo in ParsujČíslo(číslo.Remove(0, 3)))
                        {
                            parsát.Add(slovo);
                        }
                        return parsát.ToArray();
                    }
                case 1:
                case 2:
                    {
                        foreach (string slovo in ParsujČíslo(číslo.Substring(0, 2)))
                        {
                            parsát.Add(slovo);
                        }
                        foreach (string slovo in ParsujČíslo(číslo.Remove(0, 2)))
                        {
                            parsát.Add(slovo);
                        }
                        return parsát.ToArray();
                    }
                default:
                    break;
            }

            return parsát.ToArray();
        }

        protected static string[] ParsujČíslo(char[] číslo)  // Parsuje dílčí skupiny čísel (max. velikost 3 číslice).
        {
            List<string> parsát = new List<string>();
            switch (číslo.Length)
            {
                case 1:
                    {
                        parsát.Add(číslo[0].ToString());
                        break;
                    }
                case 2:
                    {
                        switch (číslo[0])
                        {
                            case '0':
                                {
                                    parsát.Add("0");
                                    parsát.Add(číslo[1].ToString());  // Pro přehlednost: Metoda ParsujČíslo je typu string[] a jako parametr má char[].
                                    break;
                                }
                            case '1':
                                {
                                    parsát.Add((Convert.ToInt32(číslo[0].ToString()) * 10 + Convert.ToInt32(číslo[1].ToString())).ToString());
                                    // Ach jo, to je zase nudlepříkaz, kdo se v tom má vyznat?!
                                    // Prostě se sčítá hodnota číslice desítek * 10 a hodota číslice jednotek.
                                    break;
                                }
                            default:
                                {
                                    parsát.Add((Convert.ToInt32(číslo[0].ToString()) * 10).ToString());  // Vážně bych s těma nudlema měl přestat.
                                    if (číslo[1] != '0')
                                    {
                                        parsát.Add((Convert.ToInt32(číslo[1].ToString())).ToString());  // Tak třeba příště. :)
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        parsát.Add((Convert.ToInt32(číslo[0].ToString()) * 100).ToString());
                        if (číslo[1] == '0' && číslo[0] != '0')
                        {
                            foreach (string slovo in ParsujČíslo(new char[] {číslo[2]}))  // Řešení dvojciferného čísla už existuje.
                            {
                                parsát.Add(slovo);
                            }
                        }
                        else
                        {
                            foreach (string slovo in ParsujČíslo(new char[] {číslo[1], číslo[2]}))  // Řešení dvojciferného čísla už existuje.
                            {
                                parsát.Add(slovo);
                            }
                        }
                        break;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException();
                    }
            }
            return parsát.ToArray();
        }

        protected static string[] ParsujVlak(Vlak vlak)  // Metoda parsuje informace o vlaku do názvu souboru.
        {
            List<string> parsát = new List<string>();
            parsát.Add("vlak-" + vlak.Druh.ToString() + "-1");  // Druh vlaku, "-1" je přípona prvního pádu.
            parsát.Add("číslo");  // Explicitně řekni číslo. TUHLE ČÁST SPRAVIT PRO INTERNACIONALIZACI!!!
            foreach (string slovo in ParsujČíslo(vlak.Číslo))
            {
                parsát.Add(slovo);
            }
            return parsát.ToArray();
        }

        public override string ToString()
        {
            string zpráva = null;
            foreach (string fráze in Tvar)
            {
                zpráva += (" " + SeznamFrází[fráze]);  //  Přidej mezeru mezi slovy a další frázi.
            }
            return zpráva.TrimStart(' ');  // Ořež mezeru přidanou na začátku.
        }
    }
}

