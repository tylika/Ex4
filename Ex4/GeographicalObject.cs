using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class GeographicalObject
{
    private double coordinateX;
    private double coordinateY;
    private string name;
    private string description;

    public double CoordinateX { get => coordinateX; set => coordinateX = value; }
    public double CoordinateY { get => coordinateY; set => coordinateY = value; }
    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }

    public virtual string GetInfoMethod()
    {
        return "";
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"\n{Name}: {Description}\nКоординати:[{CoordinateX};{CoordinateY}]");
    }

}

