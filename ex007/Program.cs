namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, n1, n2, n3, n4;
            string resultado;

            Console.Write("Digite a nota final do aluno: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota final do aluno: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota final do aluno: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota final do aluno: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (n1 + n2 + n3 + n4) / 4;

            if (nota_final > 70)
            {  
                resultado = "aproved";
                if (nota_final >= 95)
                {
                    resultado = "aprovado com louvo";
                }
               
            }
            else if (nota_final >= 45)
            {
                resultado = "em recuperação";
            }
               else   
            {
                resultado = "reproved";
                    
               }
            Console.WriteLine("Nota do aluno {0} - resultado  {1}", nota_final, resultado);
        }
    }
}
