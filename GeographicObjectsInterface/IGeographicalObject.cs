using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    interface IGeographicalObject
    {
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string GetInfoMethod();
    public void PrintInfo();
}

