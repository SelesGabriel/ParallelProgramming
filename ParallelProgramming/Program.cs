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
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Inicio de contagem");
            ////Método INVOKE
            //Parallel.Invoke(
            //    () => ParallelInvoke.ExibeDiasSemana(), () => ParallelInvoke.ExibeMeses(), () => ParallelInvoke.ExibeAnos());

            //Metodo Parallel For            
            //ParallelFor.ProcessaLaco();

            TaskWaitAny.Iniciar();







            stopwatch.Stop();
            Console.WriteLine($"Finalização de contagem - Tempo: {stopwatch.ElapsedMilliseconds}");
        }

        
    }
}
