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
    public class Categorie : Contexted
    {

        public int Id { get; set; }

        public string Libelle { get; set; }

        public Boolean Actif { get; set; }


        public void AddCategorieToBase(Categorie categorie)
        {
            this.contexte.Categories.Add(categorie);
            this.contexte.SaveChanges();
        }
        public Categorie GetCategorieFromBase(int Id)
        {
            foreach( Categorie c in this.contexte.Categories){
                if(c.Id == Id)
                {
                    return c;
                }
            }
            return null;
        }
        public void UpdateCategorieFromDatabase(int Id, string libelle, Boolean actif)
        {
            foreach(Categorie c in this.contexte.Categories)
            {
                if(c.Id == Id)
                {
                    c.Libelle = libelle;
                    c.Actif = actif;
                    this.contexte.SaveChanges();
                }
            }
        }
        public void DeleteCategorieFromBase(Categorie categorie)
        {
            this.contexte.Categories.Remove(categorie);
            this.contexte.SaveChanges();
        }

    }

    public class CategorieFluent : EntityTypeConfiguration<Categorie>
    {
        public CategorieFluent()
        {
            ToTable("APP_CATEGORIE");
            HasKey(c => c.Id);

            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Libelle).IsRequired().HasMaxLength(50);
            Property(c => c.Actif).IsRequired();
        }
       
    }
}
