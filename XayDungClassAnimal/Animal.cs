
public abstract class Animal{
    protected String Weight{get; set;}
    protected String Height{get; set;}

    public Animal(String weight, String height){
        this.Weight=weight;
        this.Height=height;
    }

    public abstract void PrintInfo();
}