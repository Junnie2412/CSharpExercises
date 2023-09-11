
using System.Reflection.Metadata.Ecma335;

class Point2D{
    private float x;
    private float y;

    public Point2D(float x, float y){
        this.x=x;
        this.y=y;
    }

    public Point2D(){

    }

    public float GetX(){
        return this.x;
    }

    public float GetY(){
        return this.y;
    }

    public void SetXY(float x, float y){
        this.x=x;
        this.y=y;
    }

    public float[] GetXY(){
        float[] array={this.x, this.y};
        return array;
    }

    public string ToString(){
        return "("+this.x+", "+this.y+")";
    }
}