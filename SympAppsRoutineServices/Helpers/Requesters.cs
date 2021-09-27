using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SympAppsRoutineServices.Helpers
{
  public class Requesters
  {
    public static async Task<HttpStatusCode> GetStatusFromUrl(string url)
    {
      try
      {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        return response.StatusCode;
      }
      catch
      {
        return HttpStatusCode.NotFound;
      }
    }
  }
}
