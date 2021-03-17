using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Método INVOKE
            //Parallel.Invoke(
            //    () => ParallelInvoke.ExibeDiasSemana(), () => ParallelInvoke.ExibeMeses(), () => ParallelInvoke.ExibeAnos());
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Inicio de contagem");
            ParallelFor.ProcessaLaco();
            stopwatch.Stop();
            Console.WriteLine($"Finalização de contagem - Tempo: {stopwatch.ElapsedMilliseconds}");
        }

        
    }
}
