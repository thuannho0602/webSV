﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
    //[Table("Appconfigura")]
    public class Appconfig
    {
        //[Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
