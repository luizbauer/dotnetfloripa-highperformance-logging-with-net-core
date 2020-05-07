using Logging.Benchmark.Enums;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmark.Scenarios.Serilog.Setups
{
    public static class Loggers
    {
        public static ILogger<Scenarios> FileCompactJsonDebug =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogCompactJsonFormatter(LogLevel.Debug, OutputMode.File));

        public static ILogger<Scenarios> ConsoleCompactJsonDebug =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogCompactJsonFormatter(LogLevel.Debug, OutputMode.Console));

        public static ILogger<Scenarios> FileJsonDebug =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogJsonFormatter(LogLevel.Debug, OutputMode.File));
       
        public static ILogger<Scenarios> ConsoleJsonDebug =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogJsonFormatter(LogLevel.Debug, OutputMode.Console));

        public static ILogger<Scenarios> FileRenderedCompactJsonDebug =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogRenderedCompactJsonFormatter(LogLevel.Debug, OutputMode.File));
     
        public static ILogger<Scenarios> ConsoleRenderedCompactJsonDebug =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogRenderedCompactJsonFormatter(LogLevel.Debug, OutputMode.Console));


        public static ILogger<Scenarios> FileCompactJsonInformation =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogCompactJsonFormatter(LogLevel.Debug, OutputMode.File));
       
        public static ILogger<Scenarios> ConsoleCompactJsonInformation =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogCompactJsonFormatter(LogLevel.Debug, OutputMode.Console));

        public static ILogger<Scenarios> FileJsonInformation =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogJsonFormatter(LogLevel.Debug, OutputMode.File));
       
        public static ILogger<Scenarios> ConsoleJsonInformation =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogJsonFormatter(LogLevel.Debug, OutputMode.Console));

        public static ILogger<Scenarios> FileRenderedCompactJsonInformation =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogRenderedCompactJsonFormatter(LogLevel.Debug, OutputMode.File));

        public static ILogger<Scenarios> ConsoleRenderedCompactJsonInformation =
            LoggerBuilder.Build<Scenarios>(s => s.AddSerilogRenderedCompactJsonFormatter(LogLevel.Debug, OutputMode.Console));

    }
}
