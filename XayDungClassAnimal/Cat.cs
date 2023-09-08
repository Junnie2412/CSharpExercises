
class Cat : Animal
{
    private String Name { get; set; }
    public Cat(String weight, String height, String name) : base (weight, height){
        this.Name=name;
    }
    public override void PrintInfo()
    {
        Console.WriteLine("Weight: {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
    }
    
}