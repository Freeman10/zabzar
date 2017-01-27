using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Boris
{
    public class ParserHlášení
    {
        public ParserHlášení(string soubor)
        {
            
        }

        protected Dictionary<string, ŠablonaHlášení> SeznamHlášení
        {
            get;
            set;
        }

        protected Dictionary<string, Type> SeznamTypů
        {
            get;
            set;
        }

        public ŠablonaHlášení ZískejŠablonuHlášení(string název)
        {
            return SeznamHlášení[název];
        }

        protected void NačtiHlášení()
        {
            
        }

        private void NačtiTypy()
        {
            StreamReader f = new StreamReader("types.csv");
            foreach (string řádek in f.ReadToEnd().Split('\n'))
            {
                string[] hodnoty = řádek.Split(':');
                SeznamTypů.Add(hodnoty[0], Type.GetType(hodnoty[1]));
            }
        }
    }
}

