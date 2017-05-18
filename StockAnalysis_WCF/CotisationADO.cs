using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StockAnalysis_WCF
{
    [DataContract]
    class CotisationADO
    {

        public static List<Cotisation> SelectionnerCotisations()
        {

            List<Cotisation> listCotisations = null;


            try
            {

                using (var dbContext = new StockEntities())
                {
                    listCotisations = (from cot in dbContext.cotisations
                                       //where cot.codeAction == 1 && cot.dateCotisation.Month==12
                                       select
                                       new Cotisation
                                       {
                                           Id = cot.id,
                                           DateCotisation = cot.dateCotisation,
                                           Ouverture = cot.ouverture,
                                           Fermeture = cot.fermeture,
                                           MinVal = cot.minVal,
                                           MaxVal = cot.maxVal,
                                           VolFinance = cot.volFinance,
                                           VolQnt = cot.volQnte,
                                           CodeAction = cot.codeAction
                                       }).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }

            return listCotisations;
        }
    }
}
