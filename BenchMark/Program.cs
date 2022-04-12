using BenchmarkDotNet.Running;

namespace BenchMark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ForAndForeach>();
        }
    }
}
