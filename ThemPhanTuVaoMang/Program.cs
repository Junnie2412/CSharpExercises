
using System.Formats.Tar;

class Program{
    static void Main(string[] args)
    {
        Console.Write("Enter number of values in arr: ");
        int n=Int32.Parse(Console.ReadLine());

        int[] arr=new int[n+1];

        for(int i=0;i<n;i++){
            Console.Write("a["+i+"]= ");
            arr[i]=Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter X and its position: ");

        Console.Write("Enter X: ");
        int x=Int32.Parse(Console.ReadLine());

        Console.Write("Enter position: ");
        int pos=Int32.Parse(Console.ReadLine());

        while(pos>=n-1 || pos<=1){
            Console.Write("Enter position btw [2"+";"+(arr.Length-2)+"]: ");
            pos=Int32.Parse(Console.ReadLine());
        };

        Array.Resize(ref arr, n+1);

        for(int i=n;i>=pos;i--){
            arr[i]=arr[i-1];
            if(i==pos)
                arr[i]=x;
        }

        Console.WriteLine("Array after insert X: ");
        for(int i=0;i<arr.Length;i++)
            Console.WriteLine("a["+i+"]= "+arr[i]);

    }
}