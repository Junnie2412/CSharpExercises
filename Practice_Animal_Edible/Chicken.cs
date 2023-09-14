
public class Chicken : Animal, Edible{
    public override string MakeSound()
    {
        return "Chicken: cluck-cluck!";
    }

    public string HowToEat(){
        return "could be fried";
    }
}