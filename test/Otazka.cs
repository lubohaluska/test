﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Otazka
    {
        public string Text;


// toto je funkcia properties
        public Moznost[] Moznosti
        {
            get;
            set;
        }

        public Moznost[] Odpovedi;
    }
    class SingleOtazka : Otazka
    {

    }
    class MultiOtazka : Otazka
    {

    }

}
