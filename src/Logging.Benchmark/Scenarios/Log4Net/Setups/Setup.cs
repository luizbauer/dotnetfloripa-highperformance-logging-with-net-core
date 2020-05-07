using System;
using System.IO;
using Logging.Benchmark.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmark.Scenarios.Log4Net.Setups
{
    public static class Setup
    {
        public static void AddLog4NetLogging(this IServiceCollection services, LogLevel logLevel,
            OutputMode outputMode)
        {
            switch (outputMode)
            {
                case OutputMode.Console:
                    services.AddLogging(opt =>
                    {
                        opt.ClearProviders();
                        opt.AddLog4Net(Path.Combine("Properties", "log4net-console.config"));
                        opt.SetMinimumLevel(logLevel);
                    });
                    break;
                case OutputMode.File:
                    services.AddLogging(opt =>
                    {
                        opt.ClearProviders();
                        opt.AddLog4Net(Path.Combine("Properties", "log4net-file.config"));
                        opt.SetMinimumLevel(logLevel);
                    });

                    break;
                 default:
                    throw new ArgumentOutOfRangeException(nameof(outputMode), outputMode, null);
            }
        }
    }
}