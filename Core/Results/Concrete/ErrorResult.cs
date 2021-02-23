﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concrete
{
    public class ErrorResult:Result
    {
        public ErrorResult(string Message) : base(false, Message)
        {

        }
        public ErrorResult():base(false)
        {

        }
    }
}
