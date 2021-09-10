using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TokoSepatu.Models
{
    public class Pembeli
    {
        [Key]
        public int Id { get; set; }
        public string Nama { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Alamat { get; set; }
    }
}
