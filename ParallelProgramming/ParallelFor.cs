using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public static class ParallelFor
    {
        public static void ProcessaLaco()
        {
            //Parallel.For(0, 100000, i => Console.WriteLine(i));

            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine($"{i} Thread: {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
