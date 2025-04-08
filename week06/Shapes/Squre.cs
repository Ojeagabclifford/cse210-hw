

public class Squre : Shape
{
    private double _side;

    public Squre(string color, double side, string name): base(color,name)
    {
        _side = side;
        
    }

    public override double GetArea(){
        return _side* _side;
    }
}