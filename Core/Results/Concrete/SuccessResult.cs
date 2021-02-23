using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
   public class SuccessResult:Result
    {
        public SuccessResult(String Message) : base(true,Message)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
