using System;

public class Shape 
{
    private string _color;

    public Shape(string color)
    {
       _color=color;
    }
    
    public string Getcolor()
    {
        return _color;
    }

    public void Setcolor( string color)
    {
        _color=color;
    }

    public virtual double GetArea()
    {
        return -1;
    }
}