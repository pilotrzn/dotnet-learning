using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Data.Class
{
    /// <summary>
    /// Установка
    /// </summary>
    public class Unit
    {
        public int Id { get; }
        public string Name { get; }
        public int FactoryId { get; }

        public Unit(int id, string name, int factoryid)
        {
            Id = id;
            Name = name;
            FactoryId = factoryid;
        }
        public static Unit[] GetUnits()
        {
            return FakeData.units.ToArray();
        }

        /// <summary>
        /// метод с циклами
        /// </summary>
        /// <param name="tanks"></param>
        /// <param name="TankName"></param>
        /// <returns></returns>
        public static Unit FindUnit(Tank[] tanks, string TankName)
        {
            var units = GetUnits();
            int unitid = 0;
            foreach (var item in tanks)
            {
                if (item.Name == TankName)
                {
                    unitid = item.UnitId;
                    break;
                }
            }

            foreach (var unit in units)
            {
                if (unit.Id == unitid)
                    return unit;
            }
            return null;
        }
        /// <summary>
        /// метод с LINQ
        /// </summary>
        /// <param name="tanks"></param>
        /// <param name="TankName"></param>
        /// <returns></returns>
        public static Unit FindUnitLinq(Tank[] tanks, string TankName)
        {
            var unitid = Tank.GetTank().FirstOrDefault(x => x.Name == TankName).UnitId;     
            return GetUnits().FirstOrDefault(x => x.Id == unitid);
        }
    }
}
