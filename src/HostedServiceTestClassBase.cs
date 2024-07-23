using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Utility;

public abstract class HostedServiceTestClassBase : TestClassBase
{
    protected IHost SharedTestHost = new UninitialisedTestHost();
    protected Task? SharedTestHostTask;
    public CancellationTokenSource HostTaskCancellationTokenSource = new();

    public virtual IHostBuilder HostBuilder =>
        Host.CreateDefaultBuilder()
            .ConfigureServices(srv =>
            {
            })
            .ConfigureAppConfiguration((hbc, configurationBuilder) =>
            {
                //cb.AddJsonFile($"appsettings.{Environment.MachineName}.json", true);
                //cb.AddJsonFile($"appsettings.{Environment.UserName}.json", true);
            })
            .UseEnvironment("Test");

    protected virtual async Task StartTestHostAsync()
    {
        SharedTestHost = HostBuilder.Build();
        SharedTestHostTask = SharedTestHost.RunAsync(HostTaskCancellationTokenSource.Token);
        await Task.Delay(0);
    }
}
