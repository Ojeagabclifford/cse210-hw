

public class Cicle : Shape
{
    private double _redius;

    public Cicle(string color, double redius, string name): base(color,name)
    {
        _redius = redius;
        
    }

    public override double GetArea(){
        return _redius * _redius * Math.PI;
    }
}