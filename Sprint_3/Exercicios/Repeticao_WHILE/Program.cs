using System;

namespace Repeticao_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Você está tendo um Bom dia?");
            string resposta = Console.ReadLine();

            while (resposta == "sim")
            {
                Console.WriteLine("Bom dia!");
            }
        }
    }
}
