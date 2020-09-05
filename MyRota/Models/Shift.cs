﻿using MyRota.SmartEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyRota.Models
{
    public class Shift
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        //[Required]
        [EnumDataType(typeof(Branch))]
        public Branch Branch { get; set; }

        public string Comment { get; set; }

        public TimeSpan Duration => EndTime - StartTime;
    }
}