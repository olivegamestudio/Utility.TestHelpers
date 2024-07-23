using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Utility;

public class UninitialisedTestHost : IHost
{
    public void Dispose()
    {
        throw new NotSupportedException();
    }

    public Task StartAsync(CancellationToken cancellationToken = new())
    {
        throw new NotSupportedException();
    }

    public Task StopAsync(CancellationToken cancellationToken = new())
    {
        throw new NotSupportedException();
    }

    public IServiceProvider? Services { get; set; }
}
