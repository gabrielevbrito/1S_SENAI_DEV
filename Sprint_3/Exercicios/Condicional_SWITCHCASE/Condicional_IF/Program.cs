using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada 
            Console.WriteLine("Vamos verificar se você foi aprovado ou reprovado!");
            Console.WriteLine("--------------------------------"); 

            Console.WriteLine("Digite a primeira nota: ");
            float valorUm = float.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite a segunda nota: ");
            float valorDois = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            float valorTres = float.Parse(Console.ReadLine());

            //Processamento 
            float mediaNotas = (valorUm+valorDois+valorTres)/3; 

            //Exibir o resultado
            if(mediaNotas>5){
                Console.WriteLine("O aluno está APROVADO com a média de: "+mediaNotas);
            }else{
                Console.WriteLine("O aluno está REPROVADO com a média de: "+mediaNotas);
            }
        }
    }
}
