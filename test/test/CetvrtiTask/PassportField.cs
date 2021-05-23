using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace test.CetvrtiTask
{
    //ovo je apstraktna klasa koju nasljedjuje 7 ostalih,
    //jer imaju istu metodu koja se drugacije implementira
    abstract class PassportField
    {
        public abstract bool validate(string value);
    }
}
