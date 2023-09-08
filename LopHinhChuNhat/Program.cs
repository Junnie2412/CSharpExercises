
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the width: ");
        double width = Double.Parse(Console.ReadLine());

        Console.Write("Enter the height: ");
        double height = Double.Parse(Console.ReadLine());

        Rectangle rec = new Rectangle(width, height);

        Console.WriteLine("Your Rectangle \n" + rec.Display());
        Console.WriteLine("Perimeter of the Rectangle: " + rec.GetPerimeter());
        Console.WriteLine("Area of the Rectangle: " + rec.GetArea());
    }
}
