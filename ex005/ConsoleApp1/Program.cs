namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            
            Console.WriteLine($"\nTabuada do {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

           
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
