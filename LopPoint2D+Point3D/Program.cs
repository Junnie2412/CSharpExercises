
using System.Drawing;

class Program{
    static void Main(string[] args)
    {
        Point2D point2D=new Point2D();
        Point3D point3D=new Point3D();

        point2D.SetXY(2,3);

        point3D.SetXY(3,4);
        point3D.SetZ(5);

        Console.WriteLine(point2D.ToString());
        Console.WriteLine(point3D.ToString());
    }
}