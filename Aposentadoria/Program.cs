using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos tem o empregado: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos anos trabalhados tem o empregado: ");
            int trabalho = int.Parse(Console.ReadLine());

            if(idade >= 65 && trabalho >= 30 || idade >= 60 && trabalho >= 25)
            {
                Console.WriteLine("Tem direito a aponsentadoria.");
            }
            else
            {
                Console.WriteLine("Não tem direito a aposentadoria.");
            }
            Console.ReadKey();

        }
    }
}
