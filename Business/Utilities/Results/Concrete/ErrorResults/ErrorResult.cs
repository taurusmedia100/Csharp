﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Results.Concrete.ErrorResults
{
    public class ErrorResult:Result

    {
        public ErrorResult(string message,HttpStatusCode statusCode):base(message,false,statusCode)
        {
            
        }
        public ErrorResult(HttpStatusCode statusCode):base(false,statusCode)
        {
            
        }
    }
}
