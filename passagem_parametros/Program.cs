using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace passagem_parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a operação: ");
            string operacao = Console.ReadLine().ToUpper();
            

            switch(operacao)
            {
                case "ADIÇÃO":
                    adicao(n1, n2);
                    break;
            

            
                case "SUBTRAÇÃO":
                    subtracao(n1, n2);
                    break;
                

                
                case "MULTIPLICAÇÃO":
                        multiplicacao(n1, n2);
                        break;
                   

                    
                case "DIVISÃO":
                            divisao(n1, n2);
                            break;
            }
        }
         
        static void adicao (double v1, double v2)
        {
            double resultado = v1 + v2;
            Console.WriteLine("O resultado da operação é " + resultado);
        }

        static void subtracao(double v1, double v2)
        {
            double resultado = v1 - v2;
            Console.WriteLine("O resultado da operação é " + resultado);
        }

        static void multiplicacao (double v1, double v2)
        {
            double resultado = v1 * v2;
            Console.WriteLine("O resultado da operação é " + resultado);
        }
        static void divisao(double v1, double v2)
        {
            double resultado = v1 / v2;
            Console.WriteLine("O resultado da operação é " + resultado);
        }

    }
}
