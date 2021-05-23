using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class DrugiTask
    {

        public static int secondTask(List<String> inputList)
        {
            int howMany = 0;
            foreach (string element in inputList)
            {
                //u primjeru "1-3 a: abcde" stringToCheck je " abcde", gdje Trim funkcija brise 
                //whitespace i ostaje "abcde"
                string stringToCheck = element.Split(':')[1].Trim();

                //ako je linija "1-3 a: abcde"prvo se odvoji string sa : i prvi clan je "1-3 a", 
                //zatim se opet odvoji taj sa - i uzme se prvi clan koji je 1, dok je drugi 3 - secondIndex
                int firstIndex = Int32.Parse(element.Split(':')[0].Split(' ')[0].Split('-')[0]);
                int secondIndex = Int32.Parse(element.Split(':')[0].Split(' ')[0].Split('-')[1]);

                //checkCharacter je u primejru "1-3 a: abcde", karakter koji se provjerava tjt slovo a
                //koji se odvaja sa razmakom i uzima se drugi clan, gdje je prvi  "1-3", a drugi a
                string checkCharacter = element.Split(':')[0].Split(' ')[1];

             
                bool firstIndexOccupied = false;
                if (stringToCheck[firstIndex - 1] == checkCharacter.ToCharArray()[0]) firstIndexOccupied = true;

                bool secondIndexOccupied = false;
                if (stringToCheck[secondIndex - 1] == checkCharacter.ToCharArray()[0]) secondIndexOccupied = true;
                

                if (firstIndexOccupied ^ secondIndexOccupied) howMany++;
            }

            return howMany;

        }
    }
}
