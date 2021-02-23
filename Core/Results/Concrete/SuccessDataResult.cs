using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(string Message, T data) : base(true, Message, data)
        {

        }
        public SuccessDataResult(T data) : base(true, data)
        {

        }
        public SuccessDataResult(string Message) : base(true, Message, default)
        {//data degeri vermek istemediğimiz zaman default kullanabiliriz

        }
        public SuccessDataResult():base(true,default)
        { }
    }
}
