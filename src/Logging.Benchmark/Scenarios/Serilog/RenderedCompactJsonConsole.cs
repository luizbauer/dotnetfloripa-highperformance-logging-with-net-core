using BenchmarkDotNet.Attributes;
using Logging.Benchmark.Scenarios.Serilog.Setups;

namespace Logging.Benchmark.Scenarios
{
    public partial class Scenarios
    {
        [Benchmark]
        [BenchmarkCategory("Serilog", "Static String", "Debug")]
        public void Static_String_Debug_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonDebug.LogStaticString();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Static String", "Information")]
        public void Static_String_Information_Debug_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonInformation.LogStaticString();


        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Debug")]
        public void Boxing_Debug_All_Levels_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonDebug.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Information")]
        public void Boxing_Information_All_Levels_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonInformation.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Debug")]
        public void Boxing_Only_Debug_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonDebug.LogWithBoxingOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Information")]
        public void Boxing_Only_Information_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonInformation.LogWithBoxingOnlyInformation();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Logger Message", "Debug")]
        public void Logger_Message_Debug_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonDebug.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Logger Message", "Debug")]
        public void Logger_Message_Information_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonInformation.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Debug")]
        public void Log_Template_Debug_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonDebug.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Information")]
        public void Log_Template_Information_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonInformation.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Debug")]
        public void Log_Template_Only_Debug_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonDebug.LogWithTemplateOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Information")]
        public void Log_Template_Only_Information_Serilog_Console_Rendered_Compact_Json() =>
            Loggers.ConsoleRenderedCompactJsonInformation.LogWithTemplateOnlyInformation();
    }
}