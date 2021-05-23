using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace test.CetvrtiTask
{
     class HGT : PassportField
    
    {
        public override bool validate(string value)
        {
            Regex cmReg = new Regex(@"^[0-9]+cm$");
            Regex inReg = new Regex(@"^[0-9]+in$");

            //measure je npr od "175cm" stringa cm, dakle zadnja dva karaktera
            string measure = value.Substring(value.Length - 2);
            //hight je 175, tjt cijeli string do cm, odnosno do predzadnjeg karaktera
            string hight = value.Substring(0, value.Length - 2);

            try
            {
                if (measure == "cm" && Int32.Parse(hight) >= 150 && Int32.Parse(hight) <= 193)
                {
                    return true;
                }
                else if (measure == "in" && Int32.Parse(hight) >= 59 && Int32.Parse(hight) <= 76)
                {
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return false;
        }
    }

}
