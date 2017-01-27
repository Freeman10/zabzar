using System;
using System.Collections;
using System.Collections.Generic;

namespace Boris
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var h = new StaničníHlasatel();
            /*Hlášení hl = new StaničníHlášení.PozorVlak("20000");
            Console.WriteLine(hl.ToString());
            h.FrontaHlášení.Enqueue(hl);
            h.FrontaHlášení.Enqueue(new StaničníHlášení.PozorVlak("8700"));
            h.FrontaHlášení.Enqueue(new StaničníHlášení.PozorVlak("27553"));
            h.OhlašVše();*/
            ParserXml xml = new ParserXml("/media/junkyard/Github/zabzar/jop/boris/bin/Debug/phrases.xml", "sound");
            foreach (KeyValuePair<string, string> kvp in xml.Výsledky)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value + "/" + kvp.Key + ".wav");
            }
            List<string> seznam = new List<string>();
            /*foreach (KeyValuePair<string, string> kvp in xml.Výsledky)
            {
                seznam.Add(kvp.Key);
            }*/
            h.Ohlaš(true);
            Console.ReadLine();
        }
    }
}
