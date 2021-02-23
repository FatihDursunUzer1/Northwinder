using Core.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T data { get; }
        public DataResult(bool Success,string Message,T data):base(Success,Message)
        {
            this.data = data;
        }
        public DataResult(bool Success,T data):base(Success)
        {
            this.data = data;
        }
    }
}
