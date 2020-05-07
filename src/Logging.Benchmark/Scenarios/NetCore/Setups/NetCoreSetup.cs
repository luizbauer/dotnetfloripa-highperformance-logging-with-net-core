using System;
using Logging.Benchmark.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmark.Scenarios.NetCore.Setups
{
    public static class NetCoreSetup
    {
        public static void AddNetCoreLogging(this IServiceCollection services, LogLevel logLevel,
            OutputMode outputMode)
        {
            switch (outputMode)
            {
                case OutputMode.Console:
                    services.AddLogging(opt =>
                    {
                        opt.AddConsole();
                        opt.SetMinimumLevel(logLevel);
                    });
                    break;
                case OutputMode.File:
                    throw new NotSupportedException(outputMode.ToString());
                default:
                    throw new ArgumentOutOfRangeException(nameof(outputMode), outputMode, null);
            }
        }
    }
}