
class Program{
    static void Main(string[] args)
    {
        int n;

        do{
            Console.Write("Enter n <=20: ");
            n=Int32.Parse(Console.ReadLine());
        }while(n>20 || n<=0);

        int[] arr=new int[n];
        
        for(int i=0;i<n;i++){
            Console.Write("a["+i+"]= ");
            arr[i]=Int32.Parse(Console.ReadLine());
        }

        int max=0;

        for(int i=0;i<n;i++)
            if(arr[max]<arr[i])
                max=i;

        Console.WriteLine("Max value: "+arr[max]+" and its position "+(max+1));

    }
}
