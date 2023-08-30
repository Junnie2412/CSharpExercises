
class Program
{

    public static void delX(int[] arr)
    {
        Console.Write("Enter X in array to delete: ");
        int x = Int32.Parse(Console.ReadLine());

        Boolean check = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                check = true;
                for (int k = i; k < arr.Length - 1; k++)
                    arr[k] = arr[k + 1];
                i--;
                Array.Resize(ref arr, arr.Length - 1);
            }
        }

        if (check)
        {
            Console.WriteLine("Array after delete X");

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("a[" + i + "]= " + arr[i]);
        }
        else
            Console.WriteLine(x + " is not in array to delete");

    }
    static void Main(string[] args)
    {
        Console.Write("Enter n of array: ");
        int n = Int32.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "]= ");
            arr[i] = Int32.Parse(Console.ReadLine());
        }

        delX(arr);
    }
}
