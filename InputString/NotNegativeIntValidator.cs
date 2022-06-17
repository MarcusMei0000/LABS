using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputString
{
    // валидатор, что целое неотрицательное число
    public class NotNegativeIntValidator : IStringValidator
    {
        // число типа int => используем при этом валидатор на int
        IntValidator intValid = new IntValidator();

        public string ErrorMessage { get; private set; }

        public bool IsValid(string str)
        {
            bool isInt = intValid.IsValid(str);

            // не число, сразу выход
            if (!isInt)
            {
                ErrorMessage = intValid.ErrorMessage;
                return false;
            }

            // теперь проверим что не отрицательный
            bool isValid = Int32.Parse(str) >= 0;

            if (!isValid)
                ErrorMessage = "Число меньше 0";

            return isValid;
        }
    }
}
