using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputString
{
    public class DoubleValidator : IStringValidator
    {
        public string ErrorMessage { get; private set; }

        public bool IsValid(string str)
        {
            double res;
            bool isDouble = Double.TryParse(str, out res);

            if (!isDouble)
                ErrorMessage = "Введено не число";

            return isDouble;
        }
    }
}
