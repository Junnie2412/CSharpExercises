
public class StopWatch{
    private DateTime startTime {get; set;}
    private DateTime endTime{get; set;}

    public StopWatch(){
        this.startTime=DateTime.Now;
    }

    public void Start(){
        this.startTime=DateTime.Now;
    }

    public void Stop(){
        this.endTime=DateTime.Now;
    }

    public int GetElapsedTime(){
        return DateTime.Now.Microsecond - this.startTime.Microsecond;
    }


}