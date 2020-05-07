using System;
using Logging.Benchmark.Enums;
using Logging.Benchmark.Scenarios.Log4Net.Setups;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Logging.Benchmark.Scenarios.NetCore.Setups;
using Logging.Benchmark.Scenarios.NLog.Setups;
using Logging.Benchmark.Scenarios.Serilog.Setups;
using Logging.Benchmark.WebApi.Controllers;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmark.WebApi.Extensions
{
    public enum Providers
    {
        Native,
        Log4Net,
        NLog,
        Serilog
    }

    public static class ServiceCollectionExtension
    {
        public static void ConfigureLogger(this IServiceCollection services, LoggerSettings loggerSettings)
        {
            switch (loggerSettings.Provider)
            {
                case Providers.Native:
                    services.AddNetCoreLogging(loggerSettings.LogLevel, loggerSettings.OutputMode);
                    break;
                case Providers.Log4Net:
                    services.AddLog4NetLogging(loggerSettings.LogLevel, loggerSettings.OutputMode);
                    break;
                case Providers.NLog:
                    services.AddNLogLogging(loggerSettings.LogLevel, loggerSettings.OutputMode);
                    break;
                case Providers.Serilog:
                    services.AddSerilogCompactJsonFormatter(loggerSettings.LogLevel, loggerSettings.OutputMode);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}