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
    public class CommandeProduit : Contexted
    {
        public int ProduitId { get; set; }
        public Produit Produit { get; set; }


        public int CommandeId { get; set; }
        public Commande Commande { get; set; }

        public int Quantite { get; set; }
    }
    public class CommandeProduitFluent : EntityTypeConfiguration<CommandeProduit>
    {
        public CommandeProduitFluent()
        {
            ToTable("APP_COMMANDEPRODUIT");
            HasKey(c => new { c.ProduitId, c.CommandeId });
            
            HasRequired(c => c.Produit).WithMany().HasForeignKey(c => c.ProduitId);
            Property(c => c.ProduitId);

            
            HasRequired(c => c.Commande).WithMany().HasForeignKey(c => c.ProduitId);
            Property(c => c.CommandeId);

            Property(c => c.Quantite).IsRequired();
        }
    }
}
