using System;

namespace jop
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            Console.WriteLine(new Přejezd(7328).ToString());
            var p = new Přejezd(6845);
            Console.WriteLine(p.Stav);
		}
	}
}
