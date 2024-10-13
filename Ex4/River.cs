using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class River : GeographicalObject
    {
    private double flowRate;
    private double totalLenth;

    public double FlowRate { get => flowRate; set => flowRate = value; }
    public double TotalLenth { get => totalLenth; set => totalLenth = value; }

    public override string GetInfoMethod()
    {
        return $"Інформацію отримано з гідрологічних досліджень.";
    }
    public override void PrintInfo()
    {
       base.PrintInfo();
        Console.WriteLine($"Швидкість течії:{FlowRate}см/с; Загальна довжина:{TotalLenth}м\n{GetInfoMethod()}");
    }
}