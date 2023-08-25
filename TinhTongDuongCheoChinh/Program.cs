

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter axa matrix: ");
        
        Console.Write("Enter a: ");
        int a=Int32.Parse(Console.ReadLine());

        int[,] matrix=new int[a,a];

        for(int i=0;i<a;i++){
            for(int k=0;k<a;k++)
            {
                Console.Write("matrix["+i+";"+k+"]= ");
                matrix[i,k]=Int32.Parse(Console.ReadLine());
            }
        }


        Console.WriteLine("We have matrix: ");

        int sum=0;

        for(int i=0;i<a;i++){
            for(int k=0;k<a;k++){
                Console.Write(matrix[i,k]+" ");
                if(i==k)
                    sum+=matrix[i,k];
            }
            Console.WriteLine();
        }

        Console.Write("Sum of arr: "+sum);
    }
}
