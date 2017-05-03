using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StockAnalysis_WCF
{

    [DataContract]
    class ActionStock
    {
        //private int code;
        //private string nom;
        //private int quantite;

        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public int Quantite { get; set; }

        public ActionStock()
        {
        }

    }
}
