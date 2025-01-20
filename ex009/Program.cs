namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário para digitar um número
            Console.Write("Digite um número: ");
            int numero = int.Parse(s: Console.ReadLine());

            // Verifica se o número é par ou ímpar
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
    

