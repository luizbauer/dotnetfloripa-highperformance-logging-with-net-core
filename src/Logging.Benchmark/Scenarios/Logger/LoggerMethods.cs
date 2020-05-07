using System;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmark.Scenarios.Logger
{
    [MemoryDiagnoser]
    public class LoggerMethods
    {
        public static ILogger<LoggerMethods> Logger = new LoggerFactory().CreateLogger<LoggerMethods>();
        private const string TemplateLog = "Boxing {number}";
        private static readonly Action<ILogger, byte, Exception> BoxingMessage = LoggerMessage.Define<byte>(LogLevel.Information,
            new EventId(1, nameof(BoxingMessage)), "Boxing {BoxingMessage}");

        [Benchmark]
        public void LogInformationWithInterpolation() => Logger.LogInformation($"Boxing {3}");

        [Benchmark]
        public void LogInformationWithTemplate() => Logger.LogInformation("Boxing {number}", 3);

        [Benchmark]
        public void LogInformationWithTemplateAndConstant() => Logger.LogInformation(TemplateLog, 3);

        [Benchmark]
        public void LogInformationWithMessageDefine() => BoxingMessage(Logger, 1, default);
    }
}
