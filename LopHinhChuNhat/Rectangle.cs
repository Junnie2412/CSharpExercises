
public class Rectangle{
    private double width;
    private double height;

    public Rectangle(){

    }

    public Rectangle(double width, double height){
        this.width=width;
        this.height=height;
    }

    public double GetArea(){
        return this.width*this.height;
    }

    public double GetPerimeter(){
        return (this.width+this.height)*2;
    }

    public String Display(){
        return "Rectangle: width= " + width +", height= "+height;
    }
}