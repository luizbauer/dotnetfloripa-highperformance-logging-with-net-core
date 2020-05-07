using System;
using System.IO;
using Logging.Benchmark.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace Logging.Benchmark.Scenarios.NLog.Setups
{
    public static class Setup
    {
        public static void AddNLogLogging(this IServiceCollection services, LogLevel logLevel,
            OutputMode outputMode)
        {
            switch (outputMode)
            {
                case OutputMode.Console:
                    services.AddLogging(opt =>
                    {
                        opt.ClearProviders();
                        opt.AddNLog(Path.Combine("Properties", "nlog-console.config"));
                        opt.SetMinimumLevel(logLevel);
                    });
                    break;
                case OutputMode.File:
                    services.AddLogging(opt =>
                    {
                        opt.ClearProviders();
                        opt.AddNLog(Path.Combine("Properties", "nlog-file.config"));
                        opt.SetMinimumLevel(logLevel);
                    });
                    break;
                 default:
                    throw new ArgumentOutOfRangeException(nameof(outputMode), outputMode, null);
            }
        }
    }
}