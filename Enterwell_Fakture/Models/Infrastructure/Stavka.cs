using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Enterwell_Fakture.Models.Infrastructure
{
    public class Stavka
    {
        [Key]
        public int Id_Stavka { get; set; }

        [Required]
        [StringLength(250)]
        public string Opis { get; set; }

        [Required]
        public decimal Kolicina { get; set; }

        [Required]
        public decimal Cijena { get; set; }

        public int FakturaId { get; set; }

        public virtual Faktura faktura { get; set; }

        public decimal UkupnaCijena()
        {
            return Kolicina * Cijena;
        }
    }
}