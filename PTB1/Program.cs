
class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Giai PT ax+b=c");

        Console.Write("Enter a= ");
        int a=Int32.Parse(Console.ReadLine());

        Console.Write("Enter b= ");
        int b=Int32.Parse(Console.ReadLine());

        Console.Write("Enter c= ");
        int c=Int32.Parse(Console.ReadLine());

        if(a==0){
            if(b==c)
                Console.WriteLine("PT vo so nghiem");
            else 
                Console.WriteLine("PT vo nghiem");
        }else{
            Console.WriteLine("PT co nghiem la: "+(float)(c-b)/a);
        }
    }
}
