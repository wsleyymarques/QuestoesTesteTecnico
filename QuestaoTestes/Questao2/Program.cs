using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Questao2
    //2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos
    //2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem
    //que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando
    //se o número informado pertence ou não a sequência.
{
    static void Main()
    {
        // optei por informar o numero previamente no codigo
        int numero = 35;  

        if (EhFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }

        Console.ReadKey();
    }

    static bool EhFibonacci(int numero)
    {
        //Para deixar o codigo mais eficiente optei por verificar pelo quadrado perfeito
        return EhQuadradoPerfeito(5 * numero * numero + 4) || EhQuadradoPerfeito(5 * numero * numero - 4);
    }

    static bool EhQuadradoPerfeito(int x)
    {
        int s = (int)Math.Sqrt(x);
        return s * s == x;
    }
}

