using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputString
{
    // Валидатор, проверяющий радиус
    public class NotNegativeDoubleValidator : IStringValidator
    {
        // число типа double => используем при этом валидатор на double
        DoubleValidator doubleValid = new DoubleValidator();

        public string ErrorMessage { get; private set; }

        public bool IsValid(string str)
        {
            bool isDouble = doubleValid.IsValid(str);

            // не число, сразу выход
            if (!isDouble)
            {
                ErrorMessage = doubleValid.ErrorMessage;
                return false;
            }

            // теперь проверим что не отрицательный
            bool isValid = Double.Parse(str) >= 0;

            if (!isValid)
                ErrorMessage = "Число меньше 0";

            return isValid;
        }
    }
}
