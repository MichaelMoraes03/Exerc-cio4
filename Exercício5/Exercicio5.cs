using System;

namespace Exercicios5.Exercicio5
{
    public class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double DescontoPercentual { get; set; }

        public Produtos(string nome, double preco, double descontoPercentual)
        {
            Nome = nome;
            Preco = preco;
            DescontoPercentual = descontoPercentual;
        }

        public double PrecoComDesconto()
        {
            return Preco - (Preco * DescontoPercentual / 100);
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("              ");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}"); // Exibe como moeda
            Console.WriteLine($"Desconto: {DescontoPercentual}%");
            Console.WriteLine($"Preço com desconto: {PrecoComDesconto():C}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome inválido. O nome não pode ser vazio.");
                Console.Write("Digite o nome do produto: ");
                nome = Console.ReadLine();
            }

            Console.Write("Digite o preço do produto: ");
            double preco;
            while (!double.TryParse(Console.ReadLine(), out preco) || preco < 0)
            {
                Console.WriteLine("Preço inválido. O preço deve ser um número não negativo.");
                Console.Write("Digite o preço do produto: ");
            }

            Console.Write("Digite o desconto percentual do produto: ");
            double descontoPercentual;
            while (!double.TryParse(Console.ReadLine(), out descontoPercentual) || descontoPercentual < 0 || descontoPercentual > 100)
            {
                Console.WriteLine("Desconto inválido. O desconto deve ser entre 0 e 100.");
                Console.Write("Digite o desconto percentual do produto: ");
            }

            Produtos produtos = new Produtos(nome, preco, descontoPercentual);
            produtos.ExibirInformacoes();
        }
    }
}
