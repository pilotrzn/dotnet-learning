using System;
using Models.Data.Class;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            var tanks = Tank.GetTank();
            Console.WriteLine($"Количество резервуаров = {tanks.Length}");
            var units = Unit.GetUnits();
            Console.WriteLine($"Количество установок = {units.Length}");

            var unit = Unit.FindUnit(tanks,"Резервуар 2");
            var unitl = Unit.FindUnitLinq(tanks, "Резервуар 2");
            var factory = Factory.FindFactory(unitl);

            //вывод всех ререзвуаров
            Tank.TankInfo();
        }
    }
}
