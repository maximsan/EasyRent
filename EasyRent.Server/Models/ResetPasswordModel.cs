﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyRent.Server.Models
{
    public class ResetPasswordModel
    {
        public string Email { get; set; }
        public string Key { get; set; }
        public string Password { get; set; }
    }
}