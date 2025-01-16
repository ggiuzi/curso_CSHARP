Console.Write("Digite a velocidade do carro: ");
double velocidade = double.Parse(s: Console.ReadLine());

if (velocidade > 80)
{
    double excesso = velocidade - 80;
    double multa = excesso * 7;
    Console.WriteLine($"você foi multado, o valor da multa é R${multa:f2}");
}
else
{
    Console.WriteLine("você está dentro do limite de velocidade.");

}
