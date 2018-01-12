using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Moznost
    {
        public Moznost(string text, bool spravnost)
        {
            this.Spravnost = spravnost;
            this.Text = text;
        }
        public string Text;
        public bool Spravnost;
    }
}
