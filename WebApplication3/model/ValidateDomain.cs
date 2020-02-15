﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.model
{
    public class ValidateDomain:ValidationAttribute
    {
        public readonly string allowDomain;
        public ValidateDomain(string allowdomain)
        {
            this.allowDomain = allowdomain;

        }
        public override bool IsValid(object value)
        {
            string[] email = value.ToString().Split('@');
            if (email[1] == this.allowDomain)
                return true;
            else
                return false;
        }


    }
}
