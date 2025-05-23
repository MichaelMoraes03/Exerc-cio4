using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Exercicios4.Exercício4

{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public Aluno() { }
        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }
        public bool EstaAprovado()
        {
            return CalcularMedia() >= 7;
        }

    }

    class Program
    {
        static void Main()
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(aluno.Nome))
            {
                Console.WriteLine("Nome inválido. O nome não pode ser vazio.");
                Console.WriteLine("Digite o nome do aluno:");
                aluno.Nome = Console.ReadLine();
            }

            Console.WriteLine("Digite a nota 1:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            while (aluno.Nota1 < 0 || aluno.Nota1 > 10)
            {
                Console.WriteLine("Nota inválida. Digite uma nota entre 0 e 10.");
                Console.WriteLine("Digite a nota 1:");
                aluno.Nota1 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite a nota 2:");
            aluno.Nota2 = double.Parse(Console.ReadLine());
            while (aluno.Nota2 < 0 || aluno.Nota2 > 10)
            {
                Console.WriteLine("Nota inválida. Digite uma nota entre 0 e 10.");
                Console.WriteLine("Digite a nota 2:");
                aluno.Nota2 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite a nota 3:");
            aluno.Nota3 = double.Parse(Console.ReadLine());
            while (aluno.Nota3 < 0 || aluno.Nota3 > 10)
            {
                Console.WriteLine("Nota inválida. Digite uma nota entre 0 e 10.");
                Console.WriteLine("Digite a nota 3:");
                aluno.Nota3 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"A média do aluno {aluno.Nome} é: {aluno.CalcularMedia():F2}");
            if (aluno.EstaAprovado())
            {
                Console.WriteLine($"O aluno {aluno.Nome} está aprovado.");
            }
            else
            {
                Console.WriteLine($"O aluno {aluno.Nome} está reprovado.");
            }
        }
    }
}