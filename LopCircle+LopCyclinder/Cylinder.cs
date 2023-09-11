
class Cylinder : Circle{
    private float height;
    public void SetHeight(float height){
        this.height=height;
    }
    public float GetHeight(){
        return this.height;
    }

    public double GetVolume(){
        return base.GetArea()*this.height;
    }

    public string ToString(){
        return "Radius: "+this.GetRadius()+"; Height: "+this.height+"; Volume: "+this.GetVolume();
    }
}