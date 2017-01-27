using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.XPath;

namespace Boris
{
    public class ParserXml
    {
        public ParserXml(string soubor)
        {
            XMLSoubor = new XmlDocument();
            XMLSoubor.Load(soubor);
            KořenovýUzel = XMLSoubor.DocumentElement;
            Výsledky = new Dictionary<string, string>();
        }

        public ParserXml(string soubor, string dotaz)
        {
            XMLSoubor = new XmlDocument();
            XMLSoubor.Load(soubor);
            KořenovýUzel = XMLSoubor.DocumentElement;
            Výsledky = new Dictionary<string, string>();
            NajdiVšechnyVýsledky(dotaz);
        }

        protected XmlDocument XMLSoubor
        {
            get;
            set;
        }

        protected XmlNode KořenovýUzel
        {
            get;
        }

        public Dictionary<string, string> Výsledky
        {
            get;
            set;
        }

        public void NajdiVšechnyVýsledky(string názevHodnoty)  // Jedinná metoda, kterou je třeba vidět zvenku.
        {
            Výsledky.Clear();
            foreach (XmlNode uzel in NajdiPoduzly(KořenovýUzel, "phrase"))
            {
                NajdiVýsledky(uzel, null, názevHodnoty);
            }
        }

        protected void NajdiVýsledky(XmlNode uzel, string předponaKlíče, string názevHodnoty)
        {
            string klíč;
            string hodnota;
            if (předponaKlíče == null)
            {
                klíč = uzel.Attributes.GetNamedItem("name").Value;
            }
            else
            {
                klíč = předponaKlíče + "-" + uzel.Attributes.GetNamedItem("name").Value;
            }
                
            if (NajdiPoduzly(uzel, názevHodnoty).Length == 1)
            {
                hodnota = NajdiPoduzly(uzel, názevHodnoty)[0].InnerText;
                Výsledky.Add(klíč, hodnota);
            }
            foreach (XmlNode poduzel in NajdiPoduzly(uzel, "version"))
            {
                NajdiVýsledky(poduzel, klíč, názevHodnoty);
            }
        }

        protected XmlNode[] NajdiPoduzly(XmlNode uzel, string názevUzlu)
        {
            List<XmlNode> seznamUzlů = new List<XmlNode>();
            foreach (XmlNode poduzel in uzel.ChildNodes)
            {
                if (poduzel.Name == názevUzlu)
                {
                    seznamUzlů.Add(poduzel);
                }
            }
            return seznamUzlů.ToArray();
        }
    }
}

