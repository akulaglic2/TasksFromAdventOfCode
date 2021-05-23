using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace test.CetvrtiTask
{
    class ECL:PassportField
    {
        public override bool validate(string value)
        {
            Regex reg1 = new Regex(@"amb$");
            Regex reg2 = new Regex(@"blu$");
            Regex reg3 = new Regex(@"brn$");
            Regex reg4 = new Regex(@"gry$");
            Regex reg5 = new Regex(@"grn$");
            Regex reg6 = new Regex(@"hzl$");
            Regex reg7 = new Regex(@"oth$");

            if (reg1.IsMatch(value) ||
                reg2.IsMatch(value) ||
                reg3.IsMatch(value) ||
                reg4.IsMatch(value) ||
                reg5.IsMatch(value) ||
                reg6.IsMatch(value) ||
                reg7.IsMatch(value)) return true;

            return false;
        }
    }
}
