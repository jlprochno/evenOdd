namespace evenOdd;

class Program
{
    static void Main(string[] args)
    {
        int oddNumber = 0;
        for (int i = 0; i < 10; ++i)
        {
            Console.WriteLine("Digite um número:");
            int numberEntered = Convert.ToInt32(Console.ReadLine());

            if ((numberEntered & 1) > 0)
            ++oddNumber;
        }

        Console.WriteLine($"Você inseriu:\n{10 - oddNumber} números pares e {oddNumber} números ímpares!");
    }
}
