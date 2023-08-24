
namespace TiLeTienTe{
    class Program{
        static void Main(string[] args)
        {
            Console.Write("Enter USD: ");
            long usd=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(usd+" USD to VND is: "+usd*23000);
        }
    }
}
