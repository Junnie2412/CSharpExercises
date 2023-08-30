
using System.ComponentModel.DataAnnotations;

class Program
{

    public static double CtoF(double c)
    {
        return (9.0 / 5) * c + 32;
    }

    public static double FtoC(double f)
    {
        return (5.0 / 9) * (f - 32);
    }
    static void Main(string[] args)
    {
        int choice;

        do
        {

            Console.WriteLine("-------------MENU-------------");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            switch(choice){
                case 1:
                    Console.Write("Enter Celsius: ");
                    float celcius=float.Parse(Console.ReadLine());
                    Console.WriteLine(celcius+" Celsius = "+CtoF(celcius)+" Fahrenheit");
                    break;
                case 2:
                    Console.Write("Enter Fahrenheit: ");
                    float fahrenheit=float.Parse(Console.ReadLine());
                    Console.WriteLine(fahrenheit+" Fahrenheit = "+FtoC(fahrenheit)+" Celsius");
                    break;
                case 0:
                    return;
            }

        } while (choice >= 0 && choice <= 2);
    }
}
