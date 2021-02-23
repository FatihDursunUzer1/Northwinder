using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(string Message, T data) : base(false, Message, data)
        {

        }
        public ErrorDataResult(T data) : base(false, data)
        {

        }
        public ErrorDataResult(string Message) : base(false, Message, default)
        {

        }
        public ErrorDataResult():base(false,default)
        {

        }
    }
}
