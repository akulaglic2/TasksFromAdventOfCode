using System;
using System.Collections.Generic;
using System.Text;

namespace test.CetvrtiTask
{
     class BYR : PassportField
    {
      

        public override bool validate(string value)
        {
            try
            {
                int number = Int32.Parse(value);
                if (number >= 1920 && number <= 2002)
                    return true;

            }
            catch(Exception e)
            {
                return false;
            }

            return false;
        }
    }
}
