using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada 
            Console.WriteLine("Digite a operação que deseja realizar: \n Soma, Subtracao, Multiplicacao , Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1° número: ");
            float numeroUm = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° número: ");
            float numeroDois = float.Parse(Console.ReadLine());

            //Resultado
            float resultado = 0; 

            //Processamento 
            //if(operacao == "Soma"){
            //    resultado = numeroUm + numeroDois;
            //}else if(operacao == "Subtracao"){
            //    resultado = numeroUm - numeroDois;
            //}else if(operacao == "Multiplicacao"){
            //    resultado = numeroUm * numeroDois; 
            //}else if(operacao == "Divisao"){
            //    resultado = numeroUm / numeroDois; 
            //}else{
            //    Console.WriteLine("Operação Inválida!");
           // }

           switch(operacao){

               case "Soma":
                    resultado = numeroUm + numeroDois;
                    break; 

                case "Subtracao" :
                    resultado = numeroUm - numeroDois;
                    break;

                case "Multiplicacao" :
                    resultado = numeroUm * numeroDois;
                    break;

                case "Divisao" :
                    resultado = numeroUm / numeroDois;
                    break;

                default: 
                    Console.WriteLine("Operação Inválida!"); 
                    break;
           }

            Console.WriteLine("Resultado: "+ resultado);
        }
    }
}
