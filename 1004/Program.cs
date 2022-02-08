using System;

namespace _1004
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*
            Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
            A seguir mostre a variável PROD com mensagem correspondente.   

            Entrada: O arquivo de entrada contém 2 valores inteiros.

            Saída: Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
            Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
            */
            #endregion
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int PROD = a * b;
            Console.WriteLine($"PROD = {PROD}");
        }
    }
}
