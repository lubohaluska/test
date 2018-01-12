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

                do
                {
                    string uzivOdpoved = Console.ReadLine();

                } while ();



            }

            Console.ReadLine();
        }

        // kontrola vstupu, kym to nebude ok
        private bool zkontrolujVstup(string uzivVstup,Otazka otazka)
        {
            if (otazka is SingleOtazka)
            {
                int indexOdpovedi;
                bool jeCislo = int.TryParse(uzivVstup, out indexOdpovedi);
                if (!jeCislo)
                {
                    return false;
                }
                else
                {
                    return indexOdpovedi > 0 && indexOdpovedi < otazka.Moznosti.Length;
                    
                }
            }
            else
            {

            }

        }
        

    }
}
