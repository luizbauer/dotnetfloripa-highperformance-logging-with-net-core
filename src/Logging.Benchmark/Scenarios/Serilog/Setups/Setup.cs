using System;
using Logging.Benchmark.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Formatting;
using Serilog.Sinks.File;
using ILogger = Serilog.ILogger;

namespace Logging.Benchmark.Scenarios.Serilog.Setups
{
    public static class Setup
    {
        public static void AddSerilogLogging(IServiceCollection services, LogLevel logLevel,
            OutputMode outputMode, ITextFormatter formatter)
        {
            switch (outputMode)
            {
                case OutputMode.Console:
                    services.AddSerilogConsole(logLevel, formatter);
                    break;
                case OutputMode.File:
                    services.AddSerilogFile(logLevel, formatter);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(outputMode), outputMode, null);
            }
        }

        private static void AddSerilogFile(this IServiceCollection services, LogLevel logLevel,
            ITextFormatter formatter)
        {
            var loggerConfiguration = BuildFileLoggingConfiguration(logLevel, formatter);
            services.AddLogging(loggerConfiguration.CreateLogger(), logLevel);
        }

        private static void AddSerilogConsole(this IServiceCollection services, LogLevel logLevel,
            ITextFormatter formatter)
        {
            var loggerConfiguration = BuildConsoleLoggerConfiguration(formatter);
            services.AddLogging(loggerConfiguration.CreateLogger(), logLevel);
        }

        private static LoggerConfiguration BuildFileLoggingConfiguration(LogLevel logLevel,
            ITextFormatter textFormatter)
        {
            var sink = new SharedFileSink(Guid.NewGuid().ToString(), textFormatter, default);

            return new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Sink(sink);
        }

        private static LoggerConfiguration BuildConsoleLoggerConfiguration(ITextFormatter textFormatter)
        {
            return new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console(textFormatter);
        }

        private static void AddLogging(this IServiceCollection service, ILogger logger, LogLevel logLevel)
        {
            service.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.AddSerilog(logger);
                loggingBuilder.SetMinimumLevel(logLevel);
            });
        }
    }
}