using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using DotNetClassLibrary;

namespace WcfService1.DataContract
{
    [DataContract]
    public class CommandeContract
    {
        public CommandeContract(Commande c)
        {

        }
    }
}