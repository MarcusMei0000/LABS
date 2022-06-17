using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputString
{
    // интерфейс для валидаторов строки
    public interface IStringValidator
    {
        bool IsValid(string str);

        // сообщение об ошибке, задаём почему строка невалидна
        string ErrorMessage { get; }
    }
}
