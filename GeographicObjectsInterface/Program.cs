using System;


class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        River river1 = new River { CoordinateX = 47.701626, CoordinateY = 33.215220, Name = "Інгулець", Description = "Річка у центральній та південній Україні, права притока Дніпра. Греки називали її Пантікап, а скіфи — Герр.", FlowRate = 0.005, TotalLenth = 557 };
        River river2 = new River { CoordinateX = 49.733802, CoordinateY = 34.623046, Name = "Ворскла", Description = "Одна з найбільших лівих приток Дніпра. Витік Ворскли розташований поблизу села Покровки Івнянського району Бєлгородської області. ", FlowRate = 0.001, TotalLenth = 464 };
        Mountain mountain1 = new Mountain { CoordinateX = 48.171790, CoordinateY = 24.421088, Name = "Петрос", Description = "Гора в Українських Карпатах, у Рахівському районі Закарпатської області. Одна з найвищих вершин гірського масиву Чорногора.", HighestPoint = 2020 };
        Mountain mountain2 = new Mountain { CoordinateX = 49.070292, CoordinateY = 23.413701, Name = "Парашка", Description = "Гора в Українських Карпатах, найвища вершина однойменного хребта Парашка в Сколівських Бескидах", HighestPoint = 1271 };
        river1.PrintInfo();
        river2.PrintInfo();
        mountain1.PrintInfo();
        mountain2.PrintInfo();
    }
}