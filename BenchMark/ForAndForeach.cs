using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchMark
{
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net50, id: "String Benchmark Job 5.0")]
    //[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31, id: "String Benchmark Job 3.1")]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn]
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class ForAndForeach
    {
        private List<int> _myList;

        [GlobalSetup]
        public void Setup()
        {
            _myList = new List<int>(150000);
        }

        [Benchmark(Baseline = true)]
        public void ForMeth()
        {

            for (int i = 0; i < _myList.Count; i++)
            {
                System.Console.WriteLine(i);
            }
        }

        [Benchmark()]
        public void ForeachMeth()
        {
            foreach (var item in _myList)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
