
namespace ToanTu{
    class Program{
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            float height=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter width: ");
            float width=Convert.ToInt32(Console.ReadLine());

            Console.Write("Area is: "+height*width);
        }
    }
}
