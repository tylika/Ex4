using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Mountain : IGeographicalObject
{
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPoint { get; set; }

    public string GetInfoMethod()
    {
        return $"Інформацію отримано: з геодезичних вимірювань.";
    }
    public void PrintInfo()
    {
        Console.WriteLine($"\n{Name}: {Description}\nКоординати:[{CoordinateX};{CoordinateY}]");
        Console.WriteLine($"Найвища точка:{HighestPoint}м\n{GetInfoMethod()}");
    }
}
