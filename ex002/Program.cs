namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = -7;
            float number = 7.7f;
            char letra = 'c';
            string nome = "dudrops";

            Console.WriteLine("o número é {0}.",numero);
            Console.WriteLine("o valor é R${0}",number);
            Console.WriteLine("qual é a musica é ",letra);   
            Console.WriteLine("whats your name? {0}",nome);

            Console.WriteLine("o numero é {0}, o valor é {1}, a letra é {2}, e seu nome é {3}." ,numero, number, letra, nome);

        }
    }
}
