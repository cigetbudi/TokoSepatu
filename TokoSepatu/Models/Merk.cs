﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TokoSepatu.Models
{
    public class Merk
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nama { get; set; }
        public string Negara { get; set; }
    }
}
