using System;

namespace jop
{
    public class VloženéNávěstidlo : HlavníNávěstidlo
    {
        public VloženéNávěstidlo()
        {
            ZakázanéNávěsti = new NávěstiHlavníhoNávěstidla[]  // Těch teda je...
            {
                    NávěstiHlavníhoNávěstidla.Volno,
                    NávěstiHlavníhoNávěstidla.Výstraha,
                    NávěstiHlavníhoNávěstidla.Očekávej40,
                    NávěstiHlavníhoNávěstidla.Očekávej60,
                    NávěstiHlavníhoNávěstidla.Očekávej80,
                    NávěstiHlavníhoNávěstidla.Očekávej100,
                    NávěstiHlavníhoNávěstidla.VolnoARychlost40,
                    NávěstiHlavníhoNávěstidla.VolnoARychlost60,
                    NávěstiHlavníhoNávěstidla.VolnoARychlost80,
                    NávěstiHlavníhoNávěstidla.VolnoARychlost100,
                    NávěstiHlavníhoNávěstidla.VýstrahaARychlost40,
                    NávěstiHlavníhoNávěstidla.VýstrahaARychlost60,
                    NávěstiHlavníhoNávěstidla.VýstrahaARychlost80,
                    NávěstiHlavníhoNávěstidla.VýstrahaARychlost100,
                    NávěstiHlavníhoNávěstidla.Očekávej40ARychlost40,
                    NávěstiHlavníhoNávěstidla.Očekávej40ARychlost60,
                    NávěstiHlavníhoNávěstidla.Očekávej40ARychlost80,
                    NávěstiHlavníhoNávěstidla.Očekávej40ARychlost100,
                    NávěstiHlavníhoNávěstidla.Očekávej60ARychlost40,
                    NávěstiHlavníhoNávěstidla.Očekávej60ARychlost60,
                    NávěstiHlavníhoNávěstidla.Očekávej60ARychlost80,
                    NávěstiHlavníhoNávěstidla.Očekávej60ARychlost100,
                    NávěstiHlavníhoNávěstidla.Očekávej80ARychlost40,
                    NávěstiHlavníhoNávěstidla.Očekávej80ARychlost60,
                    NávěstiHlavníhoNávěstidla.Očekávej80ARyhclost80,
                    NávěstiHlavníhoNávěstidla.Očekávej80ARychlost100,
                    NávěstiHlavníhoNávěstidla.Očekávej100ARychlost40,
                    NávěstiHlavníhoNávěstidla.Očekávej100ARychlost60,
                    NávěstiHlavníhoNávěstidla.Očekávej100ARychlost80,
                    NávěstiHlavníhoNávěstidla.Očekávej100ARychlost100,
                    NávěstiHlavníhoNávěstidla.JízdaPodleRozhledovýchPoměrů,
                    NávěstiHlavníhoNávěstidla.JízdaPodleRozhledovýchPoměrůARychlost40
            };
        }
    }
}

