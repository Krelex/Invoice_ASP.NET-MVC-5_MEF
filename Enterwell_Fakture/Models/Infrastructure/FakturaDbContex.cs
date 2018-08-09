namespace Enterwell_Fakture.Models.Infrastructure
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FakturaDbContex : DbContext
    {
        public DbSet<Faktura> Fakture { get; set; }
        public DbSet<Stavka> Stavke { get; set; }

        public FakturaDbContex()
            : base("name=FakturaDbContex")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
