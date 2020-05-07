using Logging.Benchmark.Enums;
using Logging.Benchmark.WebApi.Extensions;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmark.WebApi
{
    public class LoggerSettings 
    {
        public Providers Provider { get; set; }
        public LogLevel LogLevel { get; set; }
        public OutputMode OutputMode { get; set; }
    }
}