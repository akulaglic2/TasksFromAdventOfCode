using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class PetiTask
    {

        static public int takeBFRL(char[] BFsequence, char characterFL, char characterBR, int max)
        {
            int  min = 0;
            foreach (char element in BFsequence)
            {
                //ukoliko je karakter jednak F/L onda se nadje aritmeticka sredina za max/min
                if (element == characterFL)
                {
                    //max se mijenja jer se uzima prva polovina, min ostaje isti 
                    //jer je pocetak isti a kraj se mijenja
                    max = (min + max) / 2;
                }
                else if (element == characterBR)
                {
                    //min se mijenja jer se uzima prva polovina, max ostaje isti, 
                    //jer je kraj isti a pocetak se mijenja
                    min = (min + max) / 2 + 1;
                }
            }
            return max;
        }


        static public int fifthTask(List<String> inputList)
        {
            List<int> listSeatID = new List<int>();

            foreach (string element in inputList)
            {
                //BF je odvojeni string od npr stringa BFFFBBFRRR, BF je BFFFBBF
                //posto je fiksno da je 7 slova onda se odsijeca od prvog do sedmog
                //karaktera u stringu, takodjer i za RL, od 7. (gdje zavrsava BF) do kraja
                //a zna se da su tu tri slova
                char[] BF = element.Substring(0, 7).ToCharArray();
                char[] RL = element.Substring(7, 3).ToCharArray();

                //napravljena je jedna metoda, jer im je posao isti, samo drugaciji parametri
                int row = takeBFRL(BF, 'F', 'B', 127);
                int column = takeBFRL(RL, 'L', 'R', 7);

                int seatID = row * 8 + column;
                listSeatID.Add(seatID);
            }
            return listSeatID.Max();

        }



    }
}
