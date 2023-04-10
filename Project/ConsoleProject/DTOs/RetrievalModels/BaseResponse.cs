﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.DTOs.RetrievalModels
{
    public class BaseResponse<T>
    {
       public T Data {get; set;}
       public bool Status {get; set;}
       public string Message {get; set;}
    }
}
