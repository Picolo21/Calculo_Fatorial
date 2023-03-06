internal class Program
{
    private static void Main(string[] args)
    {
        double fat(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            else
            {
                return (value * fat(value - 1));
            }
        }

        int number;
        double resposta;

        Console.Write("Informe um valor: ");
        number = int.Parse(Console.ReadLine());

        resposta = fat(number);

        Console.WriteLine(number + "! é igual a " + resposta);
    }
}