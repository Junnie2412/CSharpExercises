
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The Rectangle: ");
        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k <= n; k++)
                Console.Write("* ");
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("The Bottom Left Triangle right angle: ");
        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k <= i; k++)
                Console.Write("* ");
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("The Top Left Triangle right angle: ");
        for (int i = n; i >= 1; i--)
        {
            for (int k = 1; k <= i; k++)
                Console.Write("* ");
            Console.WriteLine();
        }

    }
}