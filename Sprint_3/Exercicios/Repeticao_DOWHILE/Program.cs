using System;

namespace Repeticao_DOWHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = ""; 
            do
            {
                Console.WriteLine("BOM DIA!!!!");

                Console.WriteLine("Quer receber outro bom dia?");
                resposta = Console.ReadLine(); 
                
            } while (resposta == "sim");  
        }
    }
}
