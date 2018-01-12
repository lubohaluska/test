using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class DBOtazek
    {
        public DBOtazek()
        {
            SingleOtazka o = new SingleOtazka();
            o.Text = "Kolik je 1+1?";
            o.Moznosti = new Moznost[]
            {
                new Moznost("1", false),
                new Moznost("2", true),
                new Moznost("3", false)
            };

            Otazky.Add(o);

            // tu Moznosti netreba, kedze je vyssie definovana
            o = new SingleOtazka();
            o.Text = "Kolik je 2+2?";
            o.Moznosti = new Moznost[]
            {
                new Moznost("5", false),
                new Moznost("4", true),
                new Moznost("6", false)
            };

            Otazky.Add(o);

            o = new SingleOtazka();
            o.Text = "Kolik je 3+3?";
            o.Moznosti = new Moznost[]
            {
                new Moznost("5", false),
                new Moznost("4", false),
                new Moznost("6", true)
            };

            Otazky.Add(o);



            MultiOtazka m = new MultiOtazka();
            m.Text = "Ktery z nich je operacni system?";
            m.Moznosti = new Moznost[]
            {
                new Moznost("OS X", false),
                new Moznost("OS Z", false),
                new Moznost("Ubuntu", true)
            };

            Otazky.Add(m);


        }

        public static ArrayList Otazky = new ArrayList();

    }
}
