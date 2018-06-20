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
    public class Client : Contexted
    {
        public int Id { get; set; }

        public string Nom { get; set; }
    
        public string Prenom { get; set; }

        public Boolean Actif { get; set; }

        public void AddClientToBase(Client client)
        {
            this.contexte.Clients.Add(client);
            this.contexte.SaveChanges();
        }
        public Client GetClientFromBase(int Id)
        {
            foreach (Client c in this.contexte.Clients)
            {
                if (c.Id == Id)
                {
                    return c;
                }
            }
            return null;
        }
        public void UpdateClientFromDatabase(int Id, string nom, string prenom, Boolean actif)
        {
            foreach (Client c in this.contexte.Clients)
            {
                if (c.Id == Id)
                {
                    c.Nom = nom;
                    c.Prenom = prenom;
                    c.Actif = actif;
                    this.contexte.SaveChanges();
                }
            }
        }
        public void DeleteClientFromBase(Client client)
        {
            this.contexte.Clients.Remove(client);
            this.contexte.SaveChanges();
        }

    }

    public class ClientFluent : EntityTypeConfiguration<Client>
    {
        public ClientFluent()
        {
            ToTable("APP_CLIENT");
            HasKey(c => c.Id);
            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nom).IsRequired().HasMaxLength(50);
            Property(c => c.Prenom).IsRequired().HasMaxLength(50);
            Property(c => c.Actif).IsRequired();

        }
    }
}
