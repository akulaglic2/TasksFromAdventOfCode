using System;
using System.Collections.Generic;
using System.Text;

namespace test.CetvrtiTask
{
    class IYR : PassportField
    {

        public override bool validate(string value)
        {
            try
            {
                int number = Int32.Parse(value);
                if (number >= 2010 && number <= 2020)
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
