// Teste 01 - Exibir média do aluno

using System;

namespace Teste01
{
    class Aluno
    {
        public double CalcularMedia(double nota1, double nota2)
        {
            return (nota1 + nota2) / 2;
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite a nota do primeiro semestre: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo semestre: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = aluno.CalcularMedia(nota1, nota2);
            Console.WriteLine($"Sua média é {media}");

            Console.ReadKey();
        }
    }
}