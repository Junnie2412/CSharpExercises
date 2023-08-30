
class Program{

    public static int findMin(int[] arr){
        int min=arr[0];

        for(int i=1;i<arr.Length;i++)
            if(arr[i]<min)
                min=arr[i];

        return min;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter n of array: ");
        int n=Int32.Parse(Console.ReadLine());

        int[] arr=new int[n];

        for(int i=0;i<n;i++)
        {
            Console.Write("a["+i+"]= ");
            arr[i]=Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("Min of array is: "+findMin(arr));
    }
}
