using System;
using System.Collections.Generic;
using System.Text;

namespace test.CetvrtiTask
{
    class EYR : PassportField
    {

        public override bool validate(string value)
        {
            try
            {
                int number = Int32.Parse(value);
                if (number >= 2020 && number <= 2030)
                    return true;

            }
            catch (Exception e)
            {
                return false;
            }

            return false;
        }
    }
}
