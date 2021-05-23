using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test.CetvrtiTask
{
    class CetvrtiTask
    {
        static bool checkExists(string passport)
        {
            List<string> requiredFields = new List<string>() { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };
            List<string> fieldsNames = new List<string>();

            foreach (string element in passport.Split(" "))
            {
                //elementi za string "hcl:#cfa07d byr:1929" su hcl:#cfa07d i  byr:1929
                //dok su field-ovi hcl i byr, jer se odvaja po : i uzima se prvi item tog niza
                string field = element.Split(":")[0];
              
                if (!requiredFields.Contains(field) && field != "cid")
                {
                    return false;
                }
                
                //listi requiredField nema cid-a, pa se ignorise
                //kako bi se moglo provjeriti da li ta lista ima iste elemente kao i requiredField lista
                if (field != "cid")
                {
                    fieldsNames.Add(field);
                }
            }

            bool q1 = fieldsNames.All(itm2 => requiredFields.Contains(itm2));
            bool q2 = requiredFields.All(itm2 => fieldsNames.Contains(itm2));

            //ukoliko su oba booleana true onda se moze reci da postoje,
            //jer itemi iz prve liste moraju postojati u drugoj, a takodjer mora
            //vaziti i obrnuto, jer moze se desiti da u prvoj ima 6 a u drugoj 7 elemenata
            //i da q1 bude true, dok bi q2 bio false, jer bi nedostajao taj sedmi element
            if (q1 == true && q2 == true) return true;
            return false;
        }

        static bool checkValidity(string passport)
        {
            bool valid = true;
            //passport koji je proslijedjen je npr string "hcl:#cfa07d byr:1929"
            //pa odvajajuci sa space-om se dobije da su field-ovi hcl:#cfa07d i byr:1929
            foreach (string field in passport.Split(" "))
            {
                //iz npr stringa "hcl:#cfa07d" za fieldName se uzima hcl, a za
                //fieldValue #cfa07d, odvajajuci sa :
                string fieldName = field.Split(':')[0];
                string fieldValue = field.Split(':')[1];

             
                //ukoliko je polje jedno od 7 navedenih, te ukoliko im je validnost dobra
                //onda se valid postavlja na true, a ukoliko barem jedna nije zadovoljena u jednom
                //pasosu onda je isti neispravan
                switch (fieldName)
                {
                    case "byr":
                        valid = new BYR().validate(fieldValue);
                        break;
                    case "eyr":
                        valid = new EYR().validate(fieldValue);
                        break;
                    case "hgt":
                        valid = new HGT().validate(fieldValue);
                        break;
                    case "iyr":
                        valid = new IYR().validate(fieldValue);
                        break;
                    case "hcl":
                        valid = new HCL().validate(fieldValue);
                        break;
                    case "ecl":
                        valid = new ECL().validate(fieldValue);
                        break;
                    case "pid":
                        valid = new PID().validate(fieldValue);
                        break;
                }
                //ako je u switchu bio neki case false onda ne treba dalje 
                //nista provjeravati, odmah citav passport nije validan
                if (!valid) return false;

            }

            return valid;
        }

        public static void fourthTask(List<string> inputList)
        {
            List<string> passports = new List<string>();
            StringBuilder passport = new StringBuilder();

            foreach (string element in inputList)
            {
                //u passport se dodjeljuje element sa space-om, da bi se jedan passport 
                //sjedinio u jedan item liste, jer se zna da je kraj prazan red
                passport.Append(element + " ");

                //ako je duzina elementa kada se trimuje 0, znaci da nema nista u tom redu,
                //tjt to je znak da je kraj passporta
                if (element.Trim().Length == 0)
                {
                    string trimmedPassport = passport.ToString().Trim();
                    passports.Add(trimmedPassport);
                    //passport se cisti da bi se mogao dodijeliti novi passport u sljedecim redovima
                    passport.Clear();
                }
            }

            //izracunava se koliko ima passporta u listi passports koji zadovoljavaju 
            //i to da postoje polja zadana u zadatku i to da je njihova validnost tacna
            //za to se pozivaju dvije metode checkExists i checkValidity koje vracaju bool,
            //a uzimaju svaki clan iz liste passports
            Console.WriteLine("Cetvrti: " + passports.Count(it => checkExists(it) && checkValidity(it)));
        }
    }
}
