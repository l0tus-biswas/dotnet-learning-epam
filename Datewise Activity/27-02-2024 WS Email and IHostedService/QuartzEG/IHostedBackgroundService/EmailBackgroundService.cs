
using Microsoft.Extensions.Hosting;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

public class EmailBackgroundService : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
          await Task.Delay(1000);
            Console.WriteLine("Ping");
        }
    }
}
