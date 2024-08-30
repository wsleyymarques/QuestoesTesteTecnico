using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
//    5) Escreva um programa que inverta os caracteres de um string.

//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua
//preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;
{


    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = "Exemplo de String";

            
            Console.WriteLine("Digite uma string para inverter:");
            input = Console.ReadLine();

            
            string invertedString = InverterString(input);

            
            Console.WriteLine($"String original: {input}");
            Console.WriteLine($"String invertida: {invertedString}");

            Console.ReadKey();
        }

        static string InverterString(string input)
        {
            
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

           
            char[] caracteres = new char[input.Length];

            
            for (int i = 0; i < input.Length; i++)
            {
                caracteres[i] = input[input.Length - 1 - i];
            }

            
            return new string(caracteres);
        }
    }
}
