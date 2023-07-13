// Teste 03 - Exibir média de cada aluno

using System;

namespace Teste03
{
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }

        public string VerificaAprovadoOuReprovado()
        { 
            double media = CalcularMedia();
            if (media >= 6.5)
            {
                return "O Aluno foi:Aprovado\n";
            }
            else
            {
                return "O Aluno foi:Reprovado\n";
            }
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Aluno aluno = new Aluno();
                Console.WriteLine("Informe o nome do Aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine($"Qual foi a nota do primeiro Semestre do aluno{aluno.Nome}");
                aluno.Nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine($"Qual foi a nota do segundo Semestre do aluno{aluno.Nome}");
                aluno.Nota2 = double.Parse(Console.ReadLine());

                double media = aluno.CalcularMedia();

                Console.WriteLine($"Nome do aluno: {aluno.Nome}");
                Console.WriteLine($"Média: {media}");
                Console.WriteLine($"O Aluno foi: {aluno.VerificaAprovadoOuReprovado()}\n");
            }

        }

    }
}
