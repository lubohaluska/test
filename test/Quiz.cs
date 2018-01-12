using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Quiz
    {
        private Otazka[] otazky;

        public void Quiz()
        {

            Random r = new Random();

            DBOtazek() db = new DBOtazek();

            for (int i = 0; i < 3; i++)
            {
                int index = r.Next(2);
                db[index];


            }

        }


    }
}
