using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public static class TaskWaitAll
    {
        public static void Iniciar()
        {
            var TaskA = Task.Factory.StartNew(MetodoA);
            var TaskB = Task.Factory.StartNew(MetodoB);
            Task.WaitAll(new Task[] { TaskA, TaskB }, 5000);

            Console.WriteLine("Completou todas as tarefas.");
        }

        static void MetodoA()
        {
            Console.WriteLine("Iniciando MetodoA");
            Thread.Sleep(2000);
            Console.WriteLine("concluindo MetodoA");
        }

        static void MetodoB()
        {
            Console.WriteLine("Iniciando MetodoB");
            Thread.Sleep(3000);
            Console.WriteLine("concluindo MetodoB");
        }
    }
}
