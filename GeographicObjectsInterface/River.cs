using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class River : IGeographicalObject
{
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double FlowRate { get; set; }
    public double TotalLenth { get; set; }

    public string GetInfoMethod()
    {
        return $"Інформацію отримано: з гідрологічних досліджень.";
    }
    public void PrintInfo()
    {
        Console.WriteLine($"\n{Name}: {Description}\nКоординати:[{CoordinateX};{CoordinateY}]");
        Console.WriteLine($"Швидкість течії:{FlowRate}см/с; Загальна довжина:{TotalLenth}м\n{GetInfoMethod()}");
    }
}