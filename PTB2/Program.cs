
class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Find x in ax^2 + bx + c = 0");

        Console.Write("Enter a= ");
        double a=Double.Parse(Console.ReadLine());

        Console.Write("Enter b= ");
        double b=Double.Parse(Console.ReadLine());

        Console.Write("Enter c= ");
        double c=Double.Parse(Console.ReadLine());

        if(a==0){
            if(b==0){
                if(c==0)
                    Console.WriteLine("Phuong trinh vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }else{
                Console.WriteLine("x = "+(double)-c/b);
            }
        }else{
            double delta=Math.Pow(b,2)-4*a*c;

            if(delta < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if(delta > 0 )
                Console.WriteLine("Phuong trinh co nghiem x = "+(double)-b/2*a);
            else{
                Console.WriteLine("Phuong trinh co hai nghiem: ");

                double x1=(double)(-b+Math.Sqrt(delta)/2*a);
                double x2=(double)(-b-Math.Sqrt(delta)/2*a);

                Console.WriteLine("x1= "+x1);
                Console.WriteLine("x2= "+x2);
            }
        }
    }
}
