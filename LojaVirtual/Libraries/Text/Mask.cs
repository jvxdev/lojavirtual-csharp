﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Text
{
    public class Mask
    {
        public static string Delete(string value)
        {
            return value.Replace("(", "").Replace(")", "").Replace("-", "").Replace(".", "").Replace(",", "").Replace("R$", "").Replace(" ", "");
        }


        public static int ConvertValuePagarMe(decimal value)
        {
            string stringValue = value.ToString("C");
            stringValue = Delete(stringValue);
            int intValue = int.Parse(stringValue);

            return intValue;
        }
    }
}
