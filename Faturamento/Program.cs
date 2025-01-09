using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faturamento
{
    class Program
    {
        static void Main()
        {
            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double Outros = 19849.53;

            double total = SP + RJ + MG + ES + Outros;

            Console.WriteLine($"Percentual de SP: {CalcularPercentual(SP, total):F2}%");
            Console.WriteLine($"Percentual de RJ: {CalcularPercentual(RJ, total):F2}%");
            Console.WriteLine($"Percentual de MG: {CalcularPercentual(MG, total):F2}%");
            Console.WriteLine($"Percentual de ES: {CalcularPercentual(ES, total):F2}%");
            Console.WriteLine($"Percentual de Outros: {CalcularPercentual(Outros, total):F2}%");
            Console.ReadLine();
        }

        static double CalcularPercentual(double valor, double total)
        {
            return (valor / total) * 100;
        }
    }

}
