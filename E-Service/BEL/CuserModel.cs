﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CuserModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int usertype { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string house { get; set; }
        public string road { get; set; }
        public string additional_info { get; set; }
    }
}
