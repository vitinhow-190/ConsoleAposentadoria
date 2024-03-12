using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade em anos que você trabalhou: ");
            int ano = int.Parse(Console.ReadLine());

            if (idade > 65 && ano > 30 || idade > 60 && ano > 25 ) 
            {
                Console.WriteLine("Aposentadoria disponivel"); 
            }
            else { Console.WriteLine("Aposentadoria negada"); }

            Console.ReadKey();
        }


    }
}
