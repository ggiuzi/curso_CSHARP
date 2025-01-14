namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário para inserir um número
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            // Exibe a tabuada do número inserido
            Console.WriteLine($"\nTabuada do {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            // Aguarda o usuário pressionar uma tecla para finalizar
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
