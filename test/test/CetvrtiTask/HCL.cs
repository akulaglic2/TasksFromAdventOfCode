using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace test.CetvrtiTask
{
    class HCL:PassportField
    {
        public override bool validate(string value)
        {
            Regex reg = new Regex(@"^#[0-9a-f]{6}$");
            if (reg.IsMatch(value) ) return true;

            return false;
        }
    }
}
