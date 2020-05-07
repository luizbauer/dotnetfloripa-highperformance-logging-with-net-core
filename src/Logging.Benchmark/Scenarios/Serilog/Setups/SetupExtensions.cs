using Logging.Benchmark.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog.Formatting.Compact;
using Serilog.Formatting.Json;

namespace Logging.Benchmark.Scenarios.Serilog.Setups
{
    public static class SetupExtensions
    {
        public static void AddSerilogCompactJsonFormatter(this IServiceCollection services, LogLevel logLevel,
            OutputMode outputMode)
        {
            Setup.AddSerilogLogging(services, logLevel, outputMode, new CompactJsonFormatter());
        }

        public static void AddSerilogJsonFormatter(this IServiceCollection services, LogLevel logLevel, OutputMode outputMode)
        {
            Setup.AddSerilogLogging(services, logLevel, outputMode, new JsonFormatter());
        }

        public static void AddSerilogRenderedCompactJsonFormatter(this IServiceCollection services, LogLevel logLevel, OutputMode outputMode)
        {
            Setup.AddSerilogLogging(services, logLevel, outputMode, new RenderedCompactJsonFormatter());
        }
    }
}