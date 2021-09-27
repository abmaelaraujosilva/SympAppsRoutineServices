using SympAppsRoutineServices.Helpers;
using System.Net;
using System.Threading.Tasks;

namespace SympAppsRoutineServices.RoutineServices
{
  public static class StatusServices
  {
    public static async Task TaskStatus(string URLBase)
    {
      HttpStatusCode status = await Requesters.GetStatusFromUrl(URLBase + "/api/v1/routine/task");
    }
    public static async Task ProjectStatus(string URLBase)
    {
      HttpStatusCode status = await Requesters.GetStatusFromUrl(URLBase + "/api/v1/routine/project");
    }
    public static async Task InvoiceStatus(string URLBase)
    {
      HttpStatusCode status = await Requesters.GetStatusFromUrl(URLBase + "/api/v1/routine/invoice");
    }
    public static async Task SubscriptionStatus(string URLBase)
    {
      HttpStatusCode status = await Requesters.GetStatusFromUrl(URLBase + "/api/v1/routine/subscription");
    }
  }
}
