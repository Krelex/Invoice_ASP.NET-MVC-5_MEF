using Enterwell_Fakture.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Enterwell_Fakture.Models
{
    public class Faktura
    {
        public Faktura()
        {
            this.Stavke = new List<Stavka>();
        }

        [Key]
        public int FakturaId { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public DateTime PayDate { get; set; }

        [Required]
        public string Kupac { get; set; }

        [Required]
        public string Prodavac { get; set; }

        public virtual List<Stavka> Stavke { get; set; }

        public decimal CijenaBezPdv()
        {
            decimal ukupno = 0;
            foreach (var item in this.Stavke)
            {
                ukupno += item.UkupnaCijena();
            }
            return ukupno;
        }

        //public decimal CijenaPdv()
        //{
            
        //}
    }
}