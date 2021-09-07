using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TokoSepatu.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NamaItem { get; set; }
        [DisplayName("Kategori")]
        public int KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }

        [DisplayName("Merk")]
        public int MerkId { get; set; }
        [ForeignKey("MerkId")]
        public virtual Merk Merk { get; set; }
    }
}
