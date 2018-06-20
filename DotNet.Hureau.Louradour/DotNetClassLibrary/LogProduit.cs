using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DotNetClassLibrary
{
    public class LogProduit : Contexted
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }


        public int ProduitId { get; set; }

        public Produit Produit { get; set; }

    }

    public class LogProduitFluent : EntityTypeConfiguration<LogProduit>
    {
        public LogProduitFluent()
        {
            ToTable("APP_LOGPRODUIT");
            HasKey(c => c.Id);
            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Message).IsRequired().HasMaxLength(50);
            Property(c => c.Date).IsRequired();

            Property(c => c.ProduitId).IsRequired();
            HasRequired(c => c.Produit).WithMany().HasForeignKey(c => c.ProduitId);
        }
    }
}
