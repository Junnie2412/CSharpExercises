
class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter axb matrix: ");
        
        Console.Write("Enter a: ");
        int a=Int32.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b=Int32.Parse(Console.ReadLine());

        int[,] matrix=new int[a,b];

        for(int i=0;i<a;i++){
            for(int k=0;k<b;k++)
            {
                Console.Write("matrix["+i+";"+k+"]= ");
                matrix[i,k]=Int32.Parse(Console.ReadLine());
            }
        }

        int horizonPos=0;
        int verticalPos=0;

        Console.WriteLine("We have matrix: ");

        for(int i=0;i<a;i++){
            for(int k=0;k<b;k++){

                Console.Write(matrix[i,k]+" ");

                if(matrix[horizonPos,verticalPos]<matrix[i,k])
                {
                    horizonPos=i;
                    verticalPos=k;
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Max is "+matrix[horizonPos,verticalPos]+" and position is matrix["+(horizonPos)+","+(verticalPos)+"]");
    }
}
