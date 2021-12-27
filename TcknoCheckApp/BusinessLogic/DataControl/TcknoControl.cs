using System.Threading.Tasks;
using TcknoCheckApp.Models.Concrete;
using static Identity.KPSPublicSoapClient;

namespace TcknoCheckApp.BusinessLogic.DataControl
{
    public static class TcknoControl
    { 
      public static async Task<bool> TcknoChecked(Starbuck starbuck)
        {
            bool control;
            try
            {
                var mrns = new Identity.KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
                var tcknoControl =await mrns.TCKimlikNoDogrulaAsync(starbuck.Tckno, starbuck.FirstName,starbuck.LastName,starbuck.BirthYear);
                control = tcknoControl.Body.TCKimlikNoDogrulaResult;
            }
            catch (System.Exception)
            {

                control= false;
            }
            return control;
           
        }
    }
}
