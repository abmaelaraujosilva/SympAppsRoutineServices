using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SympAppsRoutineServices.RoutineServices;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SympAppsRoutineServices
{
  public class Worker : BackgroundService
  {
    private readonly ILogger<Worker> _logger;
    private URLBase _URLBase;
    public Worker(ILogger<Worker> logger, IConfiguration _conf)
    {
      _logger = logger;
      _URLBase = _conf.GetSection("URLBase").Get<URLBase>();
    }



    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
      while (!stoppingToken.IsCancellationRequested)
      {
        //await PayRollServices.RoutineToGeneratePayRoll(_URLBase?.Url);
        await RecurringInvoiceServices.RoutineToGenerateInvoices(_URLBase?.Url);
        await StatusServices.TaskStatus(_URLBase?.Url);
        await StatusServices.ProjectStatus(_URLBase?.Url);
        await StatusServices.InvoiceStatus(_URLBase?.Url);
        await StatusServices.SubscriptionStatus(_URLBase?.Url);

        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        await Task.Delay(new TimeSpan(24, 0, 0), stoppingToken);
      }
    }
  }
}
