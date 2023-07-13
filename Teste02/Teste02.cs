// Teste 02 - Exibir média do aluno recebendo (x) quantidade de Notas

using System;

namespace Teste02
{
    class Aluno
    {
        public string Nome { get; set; }
        public double TotalNotas { get; set; }
        public int Provas { get; set; }

        public double CalcularMedia()
        {
            return TotalNotas / Provas;
        }
    }
    class Programa
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Bem vindo ao Teste 02, para iniciarmos qual é o seu Nome?");
            aluno.Nome = Console.ReadLine();

            while (true)
            {
                Console.WriteLine($"{aluno.Nome}, por favor nos informe qual foi sua nota na prova?");
                double nota = double.Parse(Console.ReadLine());

                aluno.Provas++;
                aluno.TotalNotas += nota;
                double media = aluno.CalcularMedia();

                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Quantidade de Provas: {aluno.Provas}");
                Console.WriteLine($"Total de Notas: {aluno.TotalNotas}");
                Console.WriteLine($"Sua média é de {media}");
            }
        }
    }
}