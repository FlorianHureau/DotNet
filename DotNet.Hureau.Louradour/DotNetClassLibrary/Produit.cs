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

    public class Produit
    {

        public int Id { get; set; }

        public int Code { get; set; }

        public string Libelle { get; set; }

        public string Description { get; set; }

        public Boolean Actif { get; set; }

        public float Prix { get; set; }


        public int Stock { get; set; }

        public int CategorieId { get; set; }

        public Categorie Categorie { get; set; }

    }

    public class ProduitFluent : EntityTypeConfiguration<Produit>
    {
        public ProduitFluent()
        {
            ToTable("APP_PRODUIT");
            HasKey(c => c.Id);
            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Code).IsRequired();
            Property(c => c.Libelle).IsRequired().HasMaxLength(50);
            Property(c => c.Description).IsRequired().HasMaxLength(240);
            Property(c => c.Actif).IsRequired();
            Property(c => c.Prix).IsRequired();
            Property(c => c.Stock).IsRequired();
            Property(c => c.CategorieId).IsRequired();
            HasRequired(c => c.Categorie).WithMany().HasForeignKey(c => c.CategorieId);

        }

    }
}
