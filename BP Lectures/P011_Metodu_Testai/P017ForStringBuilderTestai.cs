using System.Diagnostics;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class P017_StringBuilder_Tests
    {
        private int iterations = 500_000;
        [TestMethod]
        public void For_Concat_Test()
        {
            Thread.MemoryBarrier();
            var initialMemory = System.GC.GetTotalMemory(true);
            for (int i = 0; i < iterations; i++)
            {
                P017_StringBuilder.Program.For_Concat();
            }
            Thread.MemoryBarrier();
            var finalMemory = System.GC.GetTotalMemory(true);
            var consumption = finalMemory - initialMemory;
            Debug.WriteLine("For_Concat_Test memory consumption: " + consumption);
        }

        [TestMethod]
        public void For_StringBuilder_Test()
        {
            Thread.MemoryBarrier();
            var initialMemory = System.GC.GetTotalMemory(true);
            for (int i = 0; i < iterations; i++)
            {
                P017_StringBuilder.Program.For_StringBuilder();
            }
            Thread.MemoryBarrier();
            var finalMemory = System.GC.GetTotalMemory(true);
            var consumption = finalMemory - initialMemory;
            Debug.WriteLine("For_StringBuilder_Test memory consumption: " + consumption);
        }
    }
}