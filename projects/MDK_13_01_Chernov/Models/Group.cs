﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK_13_01_Chernov.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; } = null;
    }
}