using Logging.Benchmark.Enums;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmark.Scenarios.NetCore.Setups
{
    public static class Loggers
    {
        public static ILogger<Scenarios> ConsoleDebug =
            LoggerBuilder.Build<Scenarios>(s => s.AddNetCoreLogging(LogLevel.Debug, OutputMode.Console));

        public static ILogger<Scenarios> ConsoleInformation =
            LoggerBuilder.Build<Scenarios>(s => s.AddNetCoreLogging(LogLevel.Information, OutputMode.Console));
    }
}