using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class TaskFactory
    {

        public static void Iniciar()
        {
            Task task = Task.Factory.StartNew(() => Teste());
            Console.ReadKey();
        }

        public static void Teste()
        {
            Console.WriteLine("Executando Tarefa");
            Thread.Sleep(2000);
            Console.WriteLine("Retornando..");
        }
    }


}
