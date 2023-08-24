
class Program{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        Boolean check=true;

        if(number<2)
            check=false;

        for(int i=2;i<=number/2;i++)
            if(number%i==0)
                check=false;

        if(check)
            Console.WriteLine($"{number} is a prime number");
        else 
            Console.WriteLine($"{number} is not a prime number");
    }
}
