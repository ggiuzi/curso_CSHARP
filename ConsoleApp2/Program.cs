namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write("digite o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("digite o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("digite o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os valores informados formam um triangulo");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("ele é um triangulo equilatero.");
                }
                else if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
                {
                    Console.WriteLine("Ele é um triangulo isosceles.");
                }
                else
                {
                    Console.WriteLine("Ele é um escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores informados não formam um triangulo");
            }



        }
    }
}
