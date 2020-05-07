using BenchmarkDotNet.Attributes;
using Logging.Benchmark.Scenarios.Log4Net.Setups;

namespace Logging.Benchmark.Scenarios
{
    public partial class Scenarios
    {
        [Benchmark]
        [BenchmarkCategory("Log4Net", "Static String", "Debug")]
        public void Static_String_Debug_Log4Net_Console_() =>
            Loggers.ConsoleDebug.LogStaticString();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Static String", "Information")]
        public void Static_String_Information_Debug_Log4Net_Console_() =>
            Loggers.ConsoleInformation.LogStaticString();


        [Benchmark]
        [BenchmarkCategory("Log4Net", "Boxing", "Debug")]
        public void Boxing_Debug_All_Levels_Log4Net_Console_() =>
            Loggers.ConsoleDebug.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Boxing", "Information")]
        public void Boxing_Information_All_Levels_Log4Net_Console_() =>
            Loggers.ConsoleInformation.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Boxing", "Debug")]
        public void Boxing_Only_Debug_Log4Net_Console_() =>
            Loggers.ConsoleDebug.LogWithBoxingOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Boxing", "Information")]
        public void Boxing_Only_Information_Log4Net_Console_() =>
            Loggers.ConsoleInformation.LogWithBoxingOnlyInformation();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Logger Message", "Debug")]
        public void Logger_Message_Debug_Log4Net_Console_() =>
            Loggers.ConsoleDebug.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Logger Message", "Debug")]
        public void Logger_Message_Information_Log4Net_Console_() =>
            Loggers.ConsoleInformation.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Template", "Debug")]
        public void Log_Template_Debug_Log4Net_Console_() =>
            Loggers.ConsoleDebug.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Template", "Information")]
        public void Log_Template_Information_Log4Net_Console_() =>
            Loggers.ConsoleInformation.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Template", "Debug")]
        public void Log_Template_Only_Debug_Log4Net_Console_() =>
            Loggers.ConsoleDebug.LogWithTemplateOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("Log4Net", "Template", "Information")]
        public void Log_Template_Only_Information_Log4Net_Console_() =>
            Loggers.ConsoleInformation.LogWithTemplateOnlyInformation();
    }
}