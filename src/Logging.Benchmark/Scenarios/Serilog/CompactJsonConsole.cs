using BenchmarkDotNet.Attributes;
using Logging.Benchmark.Scenarios.Serilog.Setups;

namespace Logging.Benchmark.Scenarios
{
    public partial class Scenarios
    {
        [Benchmark]
        [BenchmarkCategory("Serilog", "Static String", "Debug")]
        public void Static_String_Debug_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonDebug.LogStaticString();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Static String", "Information")]
        public void Static_String_Information_Debug_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonInformation.LogStaticString();


        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Debug")]
        public void Boxing_Debug_All_Levels_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonDebug.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Information")]
        public void Boxing_Information_All_Levels_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonInformation.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Debug")]
        public void Boxing_Only_Debug_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonDebug.LogWithBoxingOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Information")]
        public void Boxing_Only_Information_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonInformation.LogWithBoxingOnlyInformation();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Logger Message", "Debug")]
        public void Logger_Message_Debug_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonDebug.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Logger Message", "Debug")]
        public void Logger_Message_Information_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonInformation.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Debug")]
        public void Log_Template_Debug_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonDebug.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Information")]
        public void Log_Template_Information_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonInformation.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Debug")]
        public void Log_Template_Only_Debug_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonDebug.LogWithTemplateOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Information")]
        public void Log_Template_Only_Information_Serilog_Console_CompactJson() =>
            Loggers.ConsoleCompactJsonInformation.LogWithTemplateOnlyInformation();
    }
}