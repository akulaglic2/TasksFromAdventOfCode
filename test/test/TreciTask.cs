using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class TreciTask
    {

        static public long thirdTask(List<String> inputList, int stepRight, int stepDown)
        {
            int indexToCheck = stepRight;
            long treeCount = 0;

            //petlja se povecava za onoliko koliko treba ici dole/down,
            //jer se ne ide ispocetka linije kada se predje na liniju ispod, nego se nastavlja
            //gdje se i stalo u gornjoj liniji
            for (int i = 0; i < inputList.Count; i += stepDown)
            {
                string str = inputList[i];

                //ovaj uslov je stavljen, jer se ne broji od prvog karaktera u liniji
                if (i > 0)
                {
                    //uslov kada se dodje do kraja reda u file-u, da se korak desno
                    //smanji za duzinu reda, jer je indexToCheck veci nego sto bi trebao biti
                    //i to bi bilo out of range error
                    if (indexToCheck >= str.Length)
                    {
                        indexToCheck -= str.Length;
                    }
                   
                    indexToCheck %= str.Length;

                    if (str[indexToCheck] == '#')
                    {
                        treeCount++;
                    }
                    
                    indexToCheck += stepRight;
                }
            }

            return treeCount;
        }
    }
}
