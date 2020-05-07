using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmark
{
    public static class LoggerBuilder
    {
        public static ILogger<T> Build<T>(Action<IServiceCollection> setLog)
        {
            var services = new ServiceCollection();
            setLog(services);
            return services.BuildServiceProvider().GetService<ILogger<T>>();
        }
    }
}