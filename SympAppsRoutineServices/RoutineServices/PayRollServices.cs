using SympAppsRoutineServices.Helpers;
using System.Net;
using System.Threading.Tasks;

namespace SympAppsRoutineServices.RoutineServices
{
  public static class PayRollServices
  {
    public static async Task RoutineToGeneratePayRoll(string URLBase)
    {
      HttpStatusCode status = await Requesters.GetStatusFromUrl(URLBase + "/api/v1/payroll/setup/RoutineToGeneratePayRoll");
      //if(status != HttpStatusCode.OK)
      //  //Registrar Logs de Erro
    }
  }
}
