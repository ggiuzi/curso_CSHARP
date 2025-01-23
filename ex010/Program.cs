namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Digite o salário do funcionário: R$ ");
            double salario = double.Parse(Console.ReadLine());

            double aumento;

            
            if (salario > 2500)
            {
                aumento = salario * 0.05; 
            }
            else if (salario > 1250)
            {
                aumento = salario * 0.10; 
            }
            else
            {
                aumento = salario * 0.15; 
            }

            
            Console.WriteLine($"O aumento será de R$ {aumento:F2}");
            Console.WriteLine($"O novo salário será de R$ {salario + aumento:F2}");
        }
    }
}
