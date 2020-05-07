using BenchmarkDotNet.Attributes;
using Logging.Benchmark.Scenarios.NetCore.Setups;

namespace Logging.Benchmark.Scenarios
{
    public partial class Scenarios
    {
        [Benchmark]
        [BenchmarkCategory("NetCore", "Static String", "Debug")]
        public void Static_String_Debug_NetCore_Console_() =>
            Loggers.ConsoleDebug.LogStaticString();

        [Benchmark]
        [BenchmarkCategory("NetCore", "Static String", "Information")]
        public void Static_String_Information_Debug_NetCore_Console_() =>
            Loggers.ConsoleInformation.LogStaticString();


        [Benchmark]
        [BenchmarkCategory("NetCore", "Boxing", "Debug")]
        public void Boxing_Debug_All_Levels_NetCore_Console_() =>
            Loggers.ConsoleDebug.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("NetCore", "Boxing", "Information")]
        public void Boxing_Information_All_Levels_NetCore_Console_() =>
            Loggers.ConsoleInformation.LogWithBoxingAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("NetCore", "Boxing", "Debug")]
        public void Boxing_Only_Debug_NetCore_Console_() =>
            Loggers.ConsoleDebug.LogWithBoxingOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("NetCore", "Boxing", "Information")]
        public void Boxing_Only_Information_NetCore_Console_() =>
            Loggers.ConsoleInformation.LogWithBoxingOnlyInformation();

        [Benchmark]
        [BenchmarkCategory("NetCore", "Logger Message", "Debug")]
        public void Logger_Message_Debug_NetCore_Console_() =>
            Loggers.ConsoleDebug.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("NetCore", "Logger Message", "Debug")]
        public void Logger_Message_Information_NetCore_Console_() =>
            Loggers.ConsoleInformation.LogWithLoggerMessage();

        [Benchmark]
        [BenchmarkCategory("NetCore", "Template", "Debug")]
        public void Log_Template_Debug_NetCore_Console_() =>
            Loggers.ConsoleDebug.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("NetCore", "Template", "Information")]
        public void Log_Template_Information_NetCore_Console_() =>
            Loggers.ConsoleInformation.LogWithTemplateAllLogLevels();

        [Benchmark]
        [BenchmarkCategory("NetCore", "Template", "Debug")]
        public void Log_Template_Only_Debug_NetCore_Console_() =>
            Loggers.ConsoleDebug.LogWithTemplateOnlyDebug();

        [Benchmark]
        [BenchmarkCategory("NetCore", "Template", "Information")]
        public void Log_Template_Only_Information_NetCore_Console_() =>
            Loggers.ConsoleInformation.LogWithTemplateOnlyInformation();
    }
}