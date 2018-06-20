using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using DotNetClassLibrary;


namespace WcfService1.DataContract
{
    [DataContract]
    public class ProductContract
    {
        public  ProductContract(Produit p)
        {
            this.libelle = p.Libelle;
            this.prix = p.Prix;
            this.code = p.Code;
            this.description = p.Description;
            this.stock = p.Stock;
        }

        [DataMember]
        public string libelle { get; set; }

        [DataMember]
        public float prix { get; set; }

        [DataMember]
        public int code { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public int stock { get; set; }
    }
}