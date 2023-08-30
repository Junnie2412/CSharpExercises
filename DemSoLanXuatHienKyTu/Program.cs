
class Program{

    public static int NumberOfOccurrences(String str, char c){

        int count=0;

        for(int i=0;i<str.Length;i++)
            if(str[i].Equals(c))
                count++;
        
        return count;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter String: ");
        String str=Console.ReadLine();

        Console.Write("Enter letter to count the number of occurrences: ");
        char c=char.Parse(Console.ReadLine());

        Console.WriteLine("The number of occurrrences of "+c+" is "+NumberOfOccurrences(str, c));

    }
}
