
class Program{
    static void Main(string[] args)
    {
        Console.Write("Nhap n : ");
        int n=Int32.Parse(Console.ReadLine());

        int[] arr=new int[n];
        int sum=0;

        for(int i=0;i<n;i++){
            Console.Write("a["+i+"]= ");
            arr[i]=Int32.Parse(Console.ReadLine());
            sum+=arr[i];
        }

        Console.WriteLine("Sum is: "+sum);
    }
}
