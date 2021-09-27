using SympAppsRoutineServices.Helpers;
using System.Net;
using System.Threading.Tasks;

namespace SympAppsRoutineServices.RoutineServices
{
  public static class RecurringInvoiceServices
  {
    public static async Task RoutineToGenerateInvoices(string URLBase)
    {
      HttpStatusCode status = await Requesters.GetStatusFromUrl(URLBase + "/api/v1/invoices/recurring/RoutineToGenerateInvoices");
      //if(status != HttpStatusCode.OK)
      //  //Registrar Logs de Erro
    }
  }
}
