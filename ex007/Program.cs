namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final;
            string resultado;

            Console.Write("Digite a nota final do aluno: ");
            nota_final = Convert.ToDouble(Console.ReadLine());

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
