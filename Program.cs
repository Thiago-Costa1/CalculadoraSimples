using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perguntar a operação
            Console.WriteLine("Qual a operação deseja utilizar? \nSoma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine().ToLower();

            // Pedir o 1º número
            Console.WriteLine("Digite o 1º número :");
            float num1 = float.Parse( Console.ReadLine() ); 

            // Pedir o 2º número
            Console.WriteLine("Digite o 2º número :");
            float num2 = float.Parse( Console.ReadLine() );

            // Fazer o calculo 
            // F = sufixo do float
            
            float resultado = 0;
            
            switch(operacao){

                case "soma":
                    resultado = num1 + num2;
                    break;

                case "subtracao":
                        resultado = num1 - num2;
                        break;

                case "multiplicacao":
                    resultado = num1 * num2;
                    break;
                    
                case "Divisao":
                    resultado = num1 / num2;
                        break;
                
                default:
                    Console.WriteLine("Operação inválida! :( ");
                        break;
            
            }

            if (operacao != "invalida")
               Console.WriteLine($"Calculo : {num1} com {num2} = {resultado}");
        }

    }
}
