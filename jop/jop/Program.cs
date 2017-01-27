using System;

namespace jop
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            Console.WriteLine(new Přejezd(7328).ToString());
            Kolej kolej = new Kolej(1);
            kolej.PřipojenáVýkolejka[1] = new Výkolejka(kolej.Číslo);
            VjezdovéNávěstidlo vn = new VjezdovéNávěstidlo(Směr.Sudý);
            OdjezdovéNávěstidlo on = new OdjezdovéNávěstidlo(Směr.Lichý, kolej);
            Console.WriteLine(kolej.PřipojenáVýkolejka[1].Označení);
            Console.WriteLine(vn.Označení);
            Console.WriteLine(on.Označení);
            var v = new JednostrannáVýhybka();
		}
	}
}
