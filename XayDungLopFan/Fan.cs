
using System.Runtime.ConstrainedExecution;

public class Fan{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    private int speed=SLOW;
    public int Speed{
        get => speed;
        set => speed = value;
    }
    private Boolean on=false;
    public Boolean On{
        get => on;
        set => on=value;
    }
    private double radius=5;
    public double Radius{
        get => radius;
        set => radius=value;
    }
    private string color="Blue";
    public string Color{
        get => color;
        set => color=value;
    }

    public Fan(){
    }

    public string ToString(){
        if(On)
            return "Speed: "+Speed+"; Color: "+Color+"; Radius: "+Radius+" fan is on";
        else
            return "Color: "+Color+"; Radius: "+Radius+" fan is off";
    }
}