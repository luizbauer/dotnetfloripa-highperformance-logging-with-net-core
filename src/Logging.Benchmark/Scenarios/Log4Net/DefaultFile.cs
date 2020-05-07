using BenchmarkDotNet.Attributes;
using Logging.Benchmark.Scenarios.Log4Net.Setups;

namespace Logging.Benchmark.Scenarios
{
    public partial class Scenarios
    {
        [Benchmark]
        [BenchmarkCategory("Log4Net", "Static String", "Debug")]
        public void Static_String_Debug_Log4Net_File_() =>
            Loggers.FileDebug.LogStaticString();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Static String", "Information")]
        public void Static_String_Information_Debug_Log4Net_File_() =>
            Loggers.FileInformation.LogStaticString();


        [Benchmark]
        [BenchmarkCategory("Log4Net", "Boxing", "Debug")]
        public void Boxing_Debug_All_Levels_Log4Net_File_() =>
            Loggers.FileDebug.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Boxing", "Information")]
        public void Boxing_Information_All_Levels_Log4Net_File_() =>
            Loggers.FileInformation.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Boxing", "Debug")]
        public void Boxing_Only_Debug_Log4Net_File_() =>
            Loggers.FileDebug.LogWithBoxingOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Boxing", "Information")]
        public void Boxing_Only_Information_Log4Net_File_() =>
            Loggers.FileInformation.LogWithBoxingOnlyInformation();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Logger Message", "Debug")]
        public void Logger_Message_Debug_Log4Net_File_() =>
            Loggers.FileDebug.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Logger Message", "Debug")]
        public void Logger_Message_Information_Log4Net_File_() =>
            Loggers.FileInformation.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Template", "Debug")]
        public void Log_Template_Debug_Log4Net_File_() =>
            Loggers.FileDebug.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Template", "Information")]
        public void Log_Template_Information_Log4Net_File_() =>
            Loggers.FileInformation.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Template", "Debug")]
        public void Log_Template_Only_Debug_Log4Net_File_() =>
            Loggers.FileDebug.LogWithTemplateOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Template", "Information")]
        public void Log_Template_Only_Information_Log4Net_File_() =>
            Loggers.FileInformation.LogWithTemplateOnlyInformation();
    }
}