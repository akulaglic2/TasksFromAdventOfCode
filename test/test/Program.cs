using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using test.CetvrtiTask;

namespace test
{
    class Program
    {
        static List<String>  readFile(string zadatak)
        {
            //citanje iz file-ova, po redovima
            //svaki file je nazvan zadBrojZadatka
            string[] lines = File.ReadAllLines(zadatak +".txt");
            List<String> inputString = new List<String>();
            lines.ToArray();

            foreach (string line in lines)
                inputString.Add(line);

            return inputString;
        }


      


        static void Main(string[] args)
        {
            List<String> inputList2 = readFile("zad2");
            List<String> inputList3 = readFile("zad3");
            List<String> inputList4 = readFile("zad4");
            List<String> inputList5 = readFile("zad5");


            //Drugi zadatak, ali drugi dio
            int howMany = DrugiTask.secondTask(inputList2);
            Console.WriteLine("Drugi: " + howMany);

            //Treci zadatak, drugi dio
            long f1 = TreciTask.thirdTask(inputList3, 1, 1);
            long f2 = TreciTask.thirdTask(inputList3, 3, 1);
            long f3 = TreciTask.thirdTask(inputList3, 5, 1);
            long f4 = TreciTask.thirdTask(inputList3, 7, 1);
            long f5 = TreciTask.thirdTask(inputList3, 1, 2);
            Console.WriteLine("Treci: " + f1*f2*f3*f4*f5);

            //Cetvrti zadatak, i prvi i drugi dio
            CetvrtiTask.CetvrtiTask.fourthTask( inputList4);

            //Peti zadatak, prvi dio
            int seatID = PetiTask.fifthTask(inputList5);
            Console.WriteLine("Peti: " + seatID);


            return;
        }

        
    }
}
