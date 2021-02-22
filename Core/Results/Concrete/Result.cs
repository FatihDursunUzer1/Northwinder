using Core.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
    // void döndüren methodlar için oluşturulan Result sınıfı
    public class Result : IResult
    {
        public Result(bool Success,string Message):this(Success)
        {
            this.Message = Message;
        }
        public Result(bool Success)
        {
            this.Success = Success;
        }
        public string Message { get; }

        public bool Success { get; }
    }
}
