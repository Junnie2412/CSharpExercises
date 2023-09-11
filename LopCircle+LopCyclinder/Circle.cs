
class Circle{
    private float radius;
    private string color;
    private double area;
    
    public void SetRadius(float radius){
        this.radius=radius;
    }
    public float GetRadius(){
        return this.radius;
    }

    public void SetColor(string color){
        this.color=color;
    }
    public string GetColor(){
        return this.color;
    }
    public double GetArea(){
        return Math.Pow(this.radius,2)*3.14;
    }

    public string ToString(){
        return "Radius: "+this.radius+"; Color: "+this.color+"; Area: "+ this.GetArea();
    }


}