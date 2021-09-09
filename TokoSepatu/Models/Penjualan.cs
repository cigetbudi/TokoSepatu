using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TokoSepatu.Models
{
    public class Penjualan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime? TanggalPenjualan { get; set; }
        public enum TipePembayaran
        {
            Cash,
            Debit,
            DigitalWallet
        }
        public string Keterangan { get; set; }
        [Required]
        public int GrandTotal { get; set; }
    }
}
