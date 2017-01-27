using System;
using System.Collections;
using System.Collections.Generic;

namespace Boris
{
    public struct ŠablonaHlášení
    {
        public ŠablonaHlášení(List<Type> typyProměnných, string[] tvar)
        {
            TypyProměnných = typyProměnných;
            Tvar = tvar;
        }

        public List<Type> TypyProměnných
        {
            get;
        }

        public string[] Tvar
        {
            get;
        }
    }
}

