

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public Rectangle(string color, double lenght, double width, string name): base(color,name)
    {
           _lenght = lenght;
           _width = width;
        
    }

    public override double GetArea(){
        return _lenght* _width;
    }
}