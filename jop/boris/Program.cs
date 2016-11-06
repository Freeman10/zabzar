using System;

namespace Boris
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var s1 = new Stanice("A");
            var s2 = new Stanice("B");
            var s3 = new Stanice("C");
            var jr = new JízdníŘád<Stanice>();
//            jr.PřidejPrvek(s1, DateTime.Now, DateTime.Now + TimeSpan.Parse("00:10"), true);
            jr.PřidejPrvek(s2, DateTime.Now + TimeSpan.Parse("00:15"), DateTime.Now + TimeSpan.Parse("00:20"), true);
            jr.PřidejPrvek(s3, DateTime.Now + TimeSpan.Parse("00:22"), DateTime.Now + TimeSpan.Parse("00:22"), true);
            var vlak = new Vlak(DruhVlaku.MOs, 4766, null, jr);
            jr.Příjezd.Add(s1, DateTime.Now);
        }
    }
}
