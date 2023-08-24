
class Program{
    static void Main(string[] args)
    {
        String[] list={"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
        
        Console.Write("Enter student name: ");
        String name=Console.ReadLine();

        if(list.Contains(name))
            Console.WriteLine("Position of "+name+" in the list is "+(Array.IndexOf(list,name)+1));
        else    
            Console.WriteLine("Not found " + name + " in the list.");
    }
}
