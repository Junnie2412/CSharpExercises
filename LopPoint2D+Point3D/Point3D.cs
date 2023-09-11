
using System.Diagnostics.Contracts;

class Point3D : Point2D{
    private float z;

    public Point3D(float x, float y){
        base.SetXY(x,y);
    }
    public Point3D(){

    }

    public float GetZ(){
        return this.z;
    }

    public void SetZ(float z){
        this.z=z;
    }

    public void SetXYZ(float x, float y, float z){
        base.SetXY(x,y);
        this.z=z;
    }

    public float[] GetXYZ(){
        float[] array={base.GetX(),base.GetY(),this.z};
        return array;
    }

    public string ToString(){
        return "("+base.GetX()+", "+base.GetY()+", "+this.z+")";
    }
}