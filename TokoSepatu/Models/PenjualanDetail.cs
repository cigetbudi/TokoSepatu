using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TokoSepatu.Models
{
    public class PenjualanDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PenjualanId { get; set; }
        [ForeignKey("PenjualanId")]
        public virtual Penjualan Penjualan { get; set; }
        [DisplayName("Item")]
        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "jumlah harus lebih besar dari 0!")]
        public int Qty { get; set; }

        public int Total { get; set; }
    }
}
