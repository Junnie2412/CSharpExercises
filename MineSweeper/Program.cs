
class MineSweeper
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter axb matrix: ");

        Console.Write("Enter a: ");
        int a = Int32.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = Int32.Parse(Console.ReadLine());

        char[,] matrix = new char[a, b];
        int[,] count=new int[a,b];

        for (int i = 0; i < a; i++)
        {
            for (int k = 0; k < b; k++)
            {
                Console.Write("matrix[" + i + ";" + k + "]= ");
                matrix[i, k] =Console.ReadLine()[0];
            }
        }

        Console.WriteLine("We have matrix: ");

        for (int i = 0; i < a; i++)
        {
            for (int k = 0; k < b; k++)
                Console.Write(matrix[i, k] + "  ");
            Console.WriteLine();
        }

        for (int i = 0; i < a; i++)
        {
            for (int k = 0; k < b; k++){
                if(!matrix[i,k].Equals('*')){
                    for(int h=i-1;h<=i+1;h++)
                        for(int v=k-1;v<=k+1;v++)
                            if(h>=0&&h<a&&v>=0&&v<b)
                                if(matrix[h,v].Equals('*'))
                                    count[i,k]+=1;
                }
            }
        }

        Console.WriteLine();

        for (int i = 0; i < a; i++)
        {
            for (int k = 0; k < b; k++)
                if(matrix[i,k].Equals('*'))
                    Console.Write('*'+"  ");
                else
                    Console.Write(count[i, k] + "  ");
            Console.WriteLine();
        }
    }
}
