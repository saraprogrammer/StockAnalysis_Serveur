using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace StockAnalysis_WCF
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.Single)]
    class StockService : IStockService
    {
        public List<ActionStock> GetAllActions()
        {
            List<ActionStock> actions = ActionADO.SelectionnerActions();


            return actions;
        }

        public List<Cotisation> GetAllCotisations()
        {
            List<Cotisation> cotisations = CotisationADO.SelectionnerCotisations();
            return cotisations;
        }
    }
}
