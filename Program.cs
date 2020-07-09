using System;

namespace StructVsClass
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
    }

    public class Emprego
    {
        public string Nome { get; set; }
    }

    public struct Cliente
    {
        public string Nome { get; set; }
    }

    internal class Program
    {
        //Exemplo 1 Stack
        private static void Main(string[] args)
        {
            int primeiro = 10;
            int segundo = 5;

            int terceiro = primeiro + segundo;

            return;
        }

        //Exemplo 2 Stack
        //private static void Main(string[] args)
        //{
        //    int primeiro = 10;
        //    int segundo = 5;

        //    int terceiro = Somar(primeiro, segundo);

        //    return;
        //}

        //private static int Somar(int numero1, int numero2)
        //{
        //    int soma = numero1 + numero2;

        //    return soma;
        //}

        //private static void Main(string[] args)
        //{
        //Exemplo 1
        //Pessoa pessoa;

        //pessoa = new Pessoa();
        //pessoa.Nome = "Pub-Dev";
        //pessoa.Idade = 1;

        //Exemplo 2
        //Pessoa pessoa;
        //Pessoa pessoa2;

        //pessoa = new Pessoa();
        //pessoa.Nome = "Pub-Dev";
        //pessoa.Idade = 1;

        //pessoa2 = pessoa;

        //pessoa2.Nome = "Dev-Pub";

        //Console.WriteLine(pessoa.Nome);
        //Console.ReadKey();

        //Exemplo 3
        //Pessoa pessoa;

        //pessoa = new Pessoa();
        //pessoa.Nome = "Pub-Dev";
        //pessoa.Idade = 1;

        //pessoa2 = pessoa;

        //MudarNome(pessoa);

        //Console.WriteLine(pessoa.Nome);
        //Console.ReadKey();
        //}

        //private static void MudarNome(Pessoa pessoa)
        //{
        //    pessoa.Nome = "Novo Nome";
        //}
    }
}