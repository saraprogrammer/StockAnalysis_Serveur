using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace StockAnalysis_WCF
{
    [ServiceContract]

    interface IStockService
    {
        [OperationContract]
        List<ActionStock> GetAllActions();

        [OperationContract]
        List<Cotisation> GetAllCotisations();
    }
}
