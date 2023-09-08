

public class Program{
    static void Main(string[] args)
    {
        Fan fan1=new Fan();
        Fan fan2=new Fan();

        fan1.Speed=Fan.FAST;
        fan1.Radius=10;
        fan1.Color="Yellow";
        fan1.On=true;

        fan2.Speed=Fan.MEDIUM;
        fan2.Radius=5;
        fan2.Color="Blue";
        fan2.On=false;

        Console.WriteLine(fan1.ToString());
        Console.WriteLine(fan2.ToString());

    }
}