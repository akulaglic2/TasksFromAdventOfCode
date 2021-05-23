using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace test.CetvrtiTask
{
    class PID: PassportField
    {
       
        public override bool validate(string value)
        {
            Regex reg = new Regex(@"^[0-9]{9}$");

            if (reg.IsMatch(value)) return true;

            return false;
        }
    }
}
