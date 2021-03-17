using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParallelProgramming
{
    public static class ParallelInvoke
    {
        public static void ExibeDiasSemana()
        {
            string[] diasSemana = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            foreach (string dia in diasSemana)
            {
                Console.WriteLine($"Dia da Semana: {dia}");
                Thread.Sleep(1000);
            }
        }

        public static void ExibeMeses()
        {
            string[] meses = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };
            foreach (string mes in meses)
            {
                Console.WriteLine($"Mes: {mes}");
                Thread.Sleep(2000);
            }
        }

        public static void ExibeAnos()
        {
            string[] anos = { "2016", "2017", "2018", "2019", "2020", "2021", "2022" };
            foreach (string ano in anos)
            {
                Console.WriteLine($"Ano: {ano}");
                Thread.Sleep(2000);
            }
        }
    }
}
