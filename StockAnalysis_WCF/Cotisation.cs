using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StockAnalysis_WCF
{
    [DataContract]
    class Cotisation
    {
        //private int id;
        //private DateTime dateCotisation;
        //private decimal ouverture;
        //private decimal fermeture;
        //private decimal minVal;
        //private decimal maxVal;
        //private decimal volFinance;
        //private decimal volQnt;
        //private int codeAction;

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime DateCotisation { get; set; }
        [DataMember]
        public decimal Ouverture { get; set; }
        [DataMember]
        public decimal Fermeture { get; set; }
        [DataMember]
        public decimal MinVal { get; set; }
        [DataMember]
        public decimal MaxVal { get; set; }
        [DataMember]
        public decimal VolFinance { get; set; }
        [DataMember]
        public decimal VolQnt { get; set; }
        [DataMember]
        public int CodeAction { get; set; }

        public Cotisation()
        {

        }
    }
}
