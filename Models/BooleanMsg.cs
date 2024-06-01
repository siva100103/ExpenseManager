using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class BooleanMsg
    {
        public bool Result { get; set; }
        public string Message { get; set; }


        public static implicit operator BooleanMsg(bool result)
        {
            return new BooleanMsg { Result = result, Message = string.Empty };
        }

        public static implicit operator BooleanMsg(string message)
        {
            return new BooleanMsg { Result = false, Message = message };
        }
    }

    public class BooleanMsg<T>: BooleanMsg
    {

        public T Value { get; set; }

        public static implicit operator BooleanMsg<T>(bool result)
        {
            return new BooleanMsg<T> { Result = result, Message = string.Empty };
        }

        public static implicit operator BooleanMsg<T>(string message)
        {
            return new BooleanMsg<T> { Result = false, Message = message };
        }

        public static implicit operator BooleanMsg<T>(T value)
        {

            return new BooleanMsg<T> { Result= true, Value = value };
        }
    }
}
