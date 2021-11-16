using System;

namespace ExemploRepeticao_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo Laços de Repetição!");

            
            //FOR (valor inicial; teste booleano; incremento)

            //Exercício: Contar de 0 a 50
            
            //for (var contador = 0; contador <= 50; contador++)
            //{
            //    Console.WriteLine("Contador: "+ contador); 
            //}




            //Exercício: Contar de 200 até 100 de forma decrescente

            for (var contador = 200; contador >= 100; contador--)
            {
                Console.WriteLine("Contador: "+ contador); 
            }


        }
    }
}
