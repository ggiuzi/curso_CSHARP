namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, resposta;

            Console.WriteLine("Digite um numero:");
            
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tente outra vez:");
            num2 = Convert.ToInt32(Console.ReadLine());

            num3 = num1 - num2;
            Console.WriteLine("a subtração {0} - {1} = {2}", num1, num2, num3);

            num3 = num1 + num2;
            Console.WriteLine("a soma {0} - {1} = {2}", num1, num2, num3);

            num3 = num1 * num2;
            Console.WriteLine("a multipli é {0} * {1} = {2}", num1, num2, num3);

            resposta = num1 / num2;
            Console.WriteLine("divida tudo é {0} / {1} = {2}", num1, num3, resposta);
            resposta = num1 % num2;
            Console.WriteLine("o resto da divisao é {0} % {1} = {2}", num1, num2, resposta);

            num4 = 35f;
            resposta = num1 / num4;

            Console.WriteLine("a divisao de {0} / {1} = {2}.", num1, num4, resposta);
        }
    }
}
