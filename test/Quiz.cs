using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Quiz
    {
        private Otazka[] otazky;

        public Quiz()
        {
            otazky = new Otazka[2];

            Random r = new Random();
            DBOtazek db = new DBOtazek();
            ArrayList vybranaCisla = new ArrayList();


            for (int i = 0; i < 2; i++)
            {
                int index;

                //kontorla aby neboli dve rovnake otzky
                do
                {
                    index = r.Next(2);
                }
                while (vybranaCisla.Contains(index));

                otazky[i] = (Otazka) db.Otazky[index];
                vybranaCisla.Add(index);
            }

        }

        //konstruktor pre spustenie
        public void SpustQuiz()
        {
            foreach (Otazka o in otazky)
            {
                o.VypisOtazku();
            }

            Console.ReadLine();
        }
        

    }
}
