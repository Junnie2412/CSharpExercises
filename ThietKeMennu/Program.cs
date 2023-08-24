
class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("-----------MENU-----------");
            Console.WriteLine("1. Draw Triangle");
            Console.WriteLine("2. Draw Square");
            Console.WriteLine("3. Draw Rectangle");
            Console.WriteLine("0. Exit");

            Console.Write("  Enter choice: ");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    Console.Write("Enter n: ");
                    int n = Int32.Parse(Console.ReadLine());

                    for (int i = n; i >= 1; i--)
                    {
                        for (int k = i; k >= 1; k--)
                            Console.Write("* ");
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.Write("Enter n: ");
                    n = Int32.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        for (int k = 1; k <= n; k++)
                            Console.Write("* ");
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.Write("Enter n: ");
                    n = Int32.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        for (int k = 1; k <= n + 1; k++)
                            Console.Write("* ");
                        Console.WriteLine();
                    }
                    break;
            }

        } while (choice != 0);
    }
}
