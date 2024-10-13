using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Mountain : GeographicalObject
    {
    private double highestPoint;

    public double HighestPoint { get => highestPoint; set => highestPoint = value; }

    public override string GetInfoMethod()
        {
            return $"Інформацію отримано з геодезичних вимірювань.";
        }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Найвища точка:{HighestPoint}м\n{GetInfoMethod()}");
    }
}

