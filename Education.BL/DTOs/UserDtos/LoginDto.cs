﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.DTOs.UserDtos
{
    public class LoginDto
    {
        public string EmailOrUserName { get; set; }
        public string Password { get; set; }
        public bool isPersistant { get; set; }
    }
}
