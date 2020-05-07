using BenchmarkDotNet.Attributes;
using Logging.Benchmark.Scenarios.Serilog.Setups;

namespace Logging.Benchmark.Scenarios
{
    public partial class Scenarios
    {
        [Benchmark]
        [BenchmarkCategory("Serilog", "Static String", "Debug")]
        public void Static_String_Debug_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonDebug.LogStaticString();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Static String", "Information")]
        public void Static_String_Information_Debug_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonInformation.LogStaticString();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Debug")]
        public void Boxing_Debug_All_Levels_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonDebug.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Information")]
        public void Boxing_Information_All_Levels_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonInformation.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Debug")]
        public void Boxing_Only_Debug_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonDebug.LogWithBoxingOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Boxing", "Information")]
        public void Boxing_Only_Information_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonInformation.LogWithBoxingOnlyInformation();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Logger Message", "Debug")]
        public void Logger_Message_Debug_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonDebug.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Logger Message", "Debug")]
        public void Logger_Message_Information_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonInformation.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Debug")]
        public void Log_Template_Debug_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonDebug.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Information")]
        public void Log_Template_Information_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonInformation.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Debug")]
        public void Log_Template_Only_Debug_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonDebug.LogWithTemplateOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("Serilog", "Template", "Information")]
        public void Log_Template_Only_Information_Serilog_File_Compact_Json() =>
            Loggers.FileCompactJsonInformation.LogWithTemplateOnlyInformation();
    }
}