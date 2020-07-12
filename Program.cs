namespace StructVsClass
{
    public struct Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
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

        //public class Pessoa
        //{
        //    public int Idade { get; set; }
        //    public string Nome { get; set; }
        //}

        //Exemplo 1 Heap
        //private static void Main(string[] args)
        //{
        //    Pessoa pessoa;

        //    pessoa = new Pessoa
        //    {
        //        Nome = "Pub-Dev",
        //        Idade = 1
        //    };

        //    return;
        //}

        //Exemplo 2 HEAP
        //private static void Main(string[] args)
        //{
        //    Pessoa pessoa;
        //    Pessoa pessoa2;

        //    pessoa = new Pessoa();
        //    pessoa.Nome = "Pub-Dev";
        //    pessoa.Idade = 1;

        //    pessoa2 = pessoa;

        //    pessoa2.Nome = "Dev-Pub";

        //    return;
        //}

        //Exemplo 3 HEAP
        //private static void Main(string[] args)
        //{
        //    Pessoa pessoa = new Pessoa
        //    {
        //        Nome = "Pub-Dev",
        //        Idade = 1
        //    };

        //    Pessoa pessoa2 = pessoa;

        //    MudarNome(pessoa);

        //    Console.WriteLine(pessoa2.Nome);

        //    return;
        //}

        //private static void MudarNome(Pessoa pessoa)
        //{
        //    pessoa.Nome = "Dev-Pub";
        //}
    }
}