using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StockAnalysis_WCF
{
    [DataContract]
    class ActionADO
    {


        public static List<ActionStock> SelectionnerActions()
        {

            //StockEntities dbContext = new StockEntities();
            List<ActionStock> listActions = null;
            

            try
            {

                //foreach(var a in dbContext.action)
                //{
                //    listActions.Add(a);
                //}

                //foreach(var objAction in dbContext.Database.SqlQuery<ActionStock>("SELECT * FROM "))

                    using (var dbContext = new StockEntities())
                    {
                    listActions = (from actn in dbContext.action
                                         select
                                         new ActionStock
                                         {
                                             Code = actn.code,
                                             Nom = actn.nom,
                                             Quantite = actn.quantite
                                         }).ToList();
                    }
                //foreach (var person in entities.Database.SqlQuery<Person>("SELECT * FROM dbo.Persons"))
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }

            return listActions;
        }

    }
}
