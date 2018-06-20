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
    public class Commande : Contexted
    {

        public int Id { get; set; }

        public DateTime DateCommande { get; set; }

        public string Observation { get; set; }

        public int StatutId { get; set; }

        public Statut Statut { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }


        public void AddCommandeToBase(Commande commande)
        {
            this.contexte.Commandes.Add(commande);
            this.contexte.SaveChanges();
        }
        public Commande GetCommandeFromBase(int Id)
        {
            foreach (Commande c in this.contexte.Commandes)
            {
                if (c.Id == Id)
                {
                    return c;
                }
            }
            return null;
        }
        public void UpdateCommandeFromDatabase(int Id, DateTime dateCommande, string observation, int statutId, Statut statut, int clientId, Client client)
        {
            foreach (Client c in this.contexte.Clients)
            {
                if (c.Id == Id)
                {
                    this.DateCommande = dateCommande;
                    this.Observation = observation;
                    this.StatutId = statutId;
                    this.Statut = statut;
                    this.ClientId = clientId;
                    this.Client = client;
                    this.contexte.SaveChanges();
                }
            }
        }
        public void DeleteCommandeFromBase(Commande commande)
        {
            this.contexte.Commandes.Remove(commande);
            this.contexte.SaveChanges();
        }

    }

    public class CommandeFluent : EntityTypeConfiguration<Commande>
    {
        public CommandeFluent()
        {
            ToTable("APP_COMMANDE");
            HasKey(c => c.Id);

            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Observation).IsRequired().HasMaxLength(50);
            Property(c => c.DateCommande).IsRequired();
            Property(c => c.StatutId);
            HasRequired(c => c.Statut).WithMany().HasForeignKey(c => c.StatutId);
            Property(c => c.ClientId);
            HasRequired(c => c.Client).WithMany().HasForeignKey(c => c.ClientId);

        }
    }
}
