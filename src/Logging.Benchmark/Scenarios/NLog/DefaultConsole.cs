using BenchmarkDotNet.Attributes;
using Logging.Benchmark.Scenarios.NLog.Setups;

namespace Logging.Benchmark.Scenarios
{
    public partial class Scenarios
    {
        [Benchmark]
        [BenchmarkCategory("NLog", "Static String", "Debug")]
        public void Static_String_Debug_NLog_Console_() =>
            Loggers.ConsoleDebug.LogStaticString();

        [Benchmark]
        [BenchmarkCategory("NLog", "Static String", "Information")]
        public void Static_String_Information_Debug_NLog_Console_() =>
            Loggers.ConsoleInformation.LogStaticString();


        [Benchmark]
        [BenchmarkCategory("NLog", "Boxing", "Debug")]
        public void Boxing_Debug_All_Levels_NLog_Console_() =>
            Loggers.ConsoleDebug.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("NLog", "Boxing", "Information")]
        public void Boxing_Information_All_Levels_NLog_Console_() =>
            Loggers.ConsoleInformation.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("NLog", "Boxing", "Debug")]
        public void Boxing_Only_Debug_NLog_Console_() =>
            Loggers.ConsoleDebug.LogWithBoxingOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("NLog", "Boxing", "Information")]
        public void Boxing_Only_Information_NLog_Console_() =>
            Loggers.ConsoleInformation.LogWithBoxingOnlyInformation();

        [Benchmark]
        [BenchmarkCategory("NLog", "Logger Message", "Debug")]
        public void Logger_Message_Debug_NLog_Console_() =>
            Loggers.ConsoleDebug.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("NLog", "Logger Message", "Debug")]
        public void Logger_Message_Information_NLog_Console_() =>
            Loggers.ConsoleInformation.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("NLog", "Template", "Debug")]
        public void Log_Template_Debug_NLog_Console_() =>
            Loggers.ConsoleDebug.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("NLog", "Template", "Information")]
        public void Log_Template_Information_NLog_Console_() =>
            Loggers.ConsoleInformation.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("NLog", "Template", "Debug")]
        public void Log_Template_Only_Debug_NLog_Console_() =>
            Loggers.ConsoleDebug.LogWithTemplateOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("NLog", "Template", "Information")]
        public void Log_Template_Only_Information_NLog_Console_() =>
            Loggers.ConsoleInformation.LogWithTemplateOnlyInformation();
    }
}