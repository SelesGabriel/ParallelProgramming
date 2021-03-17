using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public static class TaskWaitAny
    {
        public static void Iniciar()
        {
            var TaskA = Task.Factory.StartNew(MetodoA);
            var TaskB = Task.Factory.StartNew(MetodoB);
            var tasks = new Task[] { TaskA, TaskB };

            int firstTask = Task.WaitAny(tasks, 5000);

            Console.WriteLine($"Task {tasks[firstTask].Id} completou primeiro");

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
