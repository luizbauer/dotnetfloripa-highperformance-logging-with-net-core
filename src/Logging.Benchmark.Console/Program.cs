using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Logging.Benchmark.Enums;

namespace Logging.Benchmark.Console
{
    [MemoryDiagnoser]
    [MarkdownExporter]
    [CategoriesColumn]
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run(typeof(OutputMode).Assembly);
            System.Console.ReadLine();
        }
    }
}