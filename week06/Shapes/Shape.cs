

public abstract class Shape
{
    private  string _color;
    private string _name;

    public string GetColor()
    {
        return _color;
    }
    public string GetName(){
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public Shape(string color, string name){
        _color = color;
        _name = name;
    }

   

    public  abstract double GetArea();
    

}