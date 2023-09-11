
class Program{
    static void Main(string[] args)
    {
        Circle circle=new Circle();
        Cylinder cylinder=new Cylinder();

        circle.SetColor("Blue");
        circle.SetRadius(4);

        Console.WriteLine(circle.ToString());

        cylinder.SetColor("Yellow");
        cylinder.SetHeight(8);
        cylinder.SetRadius(4);

        Console.WriteLine(cylinder.ToString());
    }
}