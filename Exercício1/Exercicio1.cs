Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();
if (nome.Length < 5)
{
    Console.WriteLine("Seu nome é menor que 5 caracteres.");
    COnsole.Write("Digite seu nome novamente: ");
    nome = Console.ReadLine();
} 
Console.Write("Digite seu CPF: ");
string cpf = Console.ReadLine();
if (cpf.Length != 11)
{
    Console.WriteLine("Seu CPF deve ter 11 dígitos. Digite novamente.");
    cpf = Console.ReadLine();
}
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());
while (idade < 18)
{
    Console.WriteLine("Você deve ter 18 anos ou mais. Digite novamente.");
    Console.Write("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());
}
Console.WriteLine("Cadastro aprovado!");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"CPF: {cpf}");
Console.WriteLine($"Idade: {idade}");
