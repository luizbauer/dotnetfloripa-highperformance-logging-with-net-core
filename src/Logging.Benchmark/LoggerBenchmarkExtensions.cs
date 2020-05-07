using System;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmark
{
    public static class LoggerBenchmarkExtensions
    {
        private static readonly Action<ILogger, int, Exception> SampleMessage = LoggerMessage.Define<int>(LogLevel.Information,
            new EventId(1, nameof(SampleMessage)), "Logger Message Sample (Id = '{SampleMessage}')");

        public static void LogWithLoggerMessage<T>(this ILogger<T> logger)
        {
            SampleMessage(logger, 10, default);
        }

        public static void LogStaticString<T>(this ILogger<T> logger)
        {
            logger.LogInformation("Log information static");
            logger.LogDebug("Log debug static");
            logger.LogCritical("Log critical static");
            logger.LogError("Log error static");
            logger.LogTrace("Log trace static");
            logger.LogWarning("Log warning static");
        }

        public static void LogWithBoxingAllLogLevels<T>(this ILogger<T> logger)
        {
            logger.LogInformation($"Log information boxing from int {1}");
            logger.LogDebug($"Log debug boxing from int {2}");
            logger.LogCritical($"Log critical boxing from int {3}");
            logger.LogError($"Log error boxing from int {4}");
            logger.LogTrace($"Log trace boxing from int {5}");
            logger.LogWarning($"Log warning boxing from int {6}");
        }

        public static void LogWithBoxingOnlyInformation<T>(this ILogger<T> logger)
        {
            logger.LogInformation($"Log information boxing from int {7}");
        }

        public static void LogWithBoxingOnlyDebug<T>(this ILogger<T> logger)
        {
            logger.LogDebug($"Log information boxing from int {8}");
        }

        public static void LogWithTemplateAllLogLevels<T>(this ILogger<T> logger)
        {
            
            logger.LogInformation("Log information template from int {0}", 1);
            logger.LogDebug("Log debug template from int {0}",2);
            logger.LogCritical("Log critical template from int {0}",3);
            logger.LogError("Log error template from int {0}",4);
            logger.LogTrace("Log trace template from int {0}",5);
            logger.LogWarning("Log warning template from int {0}", 6);
        }

        public static void LogWithTemplateOnlyInformation<T>(this ILogger<T> logger)
        {
            logger.LogInformation("Log information template from int {0}", 1);
        }

        public static void LogWithTemplateOnlyDebug<T>(this ILogger<T> logger)
        {
            logger.LogDebug("Log debug template from int {0}", 2);
        }
    }
}