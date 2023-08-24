
using System.Reflection.Metadata.Ecma335;

namespace CanNang{
    class Program{
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            double height=Double.Parse(Console.ReadLine());

            Console.Write("Enter weight: ");
            double weight=Double.Parse(Console.ReadLine());

            double bmi=weight / Math.Pow(height,2);
            Console.Write("Your BIM is: "+bmi);

            if(bmi<18)
                Console.WriteLine("Underweight");
            else if(bmi<25.0)
                Console.WriteLine("Normal");
            else if(bmi<30.0)
                Console.WriteLine("Overweight"); 
            else 
                Console.WriteLine("Obese");   
        }
    }
}
