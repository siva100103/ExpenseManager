using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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

        public static implicit operator bool(BooleanMsg msg)
        {
            return msg.Result;
        }
    }

    public class BooleanMsg<T> where T : class
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public T Value { get; set; }

        public static implicit operator bool(BooleanMsg<T> msg)
        {
            return msg.Result;
        }

        public static implicit operator BooleanMsg<T>(string message)
        {
            return new BooleanMsg<T> { Result = false, Message = message };
        }

        public static implicit operator BooleanMsg<T>(T value)
        {
            return new BooleanMsg<T> { Result = true, Value = value };
        }

        public static implicit operator T?(BooleanMsg<T> msg)
        {
            return msg.Result ? msg.Value : null;
        }

    }
}
