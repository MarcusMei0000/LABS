using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputString
{
    // валидатор, что введено целое число
    public class IntValidator : IStringValidator
    {
        public string ErrorMessage { get; private set; }

        public bool IsValid(string str)
        {
            // проверяем строка что число типа double
            int res;
            bool isDouble = Int32.TryParse(str, out res);

            // строка не double настраиваем сообщение
            if (!isDouble)
                ErrorMessage = "Введено не целое число";

            return isDouble;
        }
    }
}
