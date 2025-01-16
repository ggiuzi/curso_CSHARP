namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double nota1, nota2, media;

            
            Console.Write("primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            
            media = (nota1 + nota2) / 2;

            
            Console.WriteLine($"A média do aluno é: {media:F2}");
        }
    }
}
