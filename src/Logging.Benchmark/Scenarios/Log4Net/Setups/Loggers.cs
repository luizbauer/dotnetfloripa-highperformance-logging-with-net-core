using Logging.Benchmark.Enums;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmark.Scenarios.Log4Net.Setups
{
    public static class Loggers
    {
        public static ILogger<Scenarios> ConsoleDebug =
            LoggerBuilder.Build<Scenarios>(s => s.AddLog4NetLogging(LogLevel.Debug, OutputMode.Console));

        public static ILogger<Scenarios> ConsoleInformation =
            LoggerBuilder.Build<Scenarios>(s => s.AddLog4NetLogging(LogLevel.Debug, OutputMode.Console));

        public static ILogger<Scenarios> FileDebug =
            LoggerBuilder.Build<Scenarios>(s => s.AddLog4NetLogging(LogLevel.Debug, OutputMode.File));

        public static ILogger<Scenarios> FileInformation =
            LoggerBuilder.Build<Scenarios>(s => s.AddLog4NetLogging(LogLevel.Debug, OutputMode.File));
    }
}