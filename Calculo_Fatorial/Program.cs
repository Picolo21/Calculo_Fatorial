internal class Program
{
    private static void Main(string[] args)
    {
        int value;

        do
        {
            Console.Clear();
            Console.Write("Digite um número que deseja calcular o fatorial: ");
            value = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (value <= 0)
            {
                Console.WriteLine("Você informou um valor inválido. Por favor, aperte a tecla ENTER e informe um valor válido para realizar o cálculo.");
                Console.ReadKey();
            }
        } while (value <= 0);

        double fatorial = value;
        int count = value;

        do
        {
            fatorial = fatorial * (count - 1);
            count--;
        } while (count != 1);

        Console.WriteLine($"O valor de {value}! é igual a {fatorial}");
    }
}