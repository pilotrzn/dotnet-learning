using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Class
{
    /// <summary>
    /// Резервуар
    /// </summary>
    public class Tank
    {
        public int Id { get;  }
        public string Name { get;  }
        public double Volume { get; }
        public double MaxVolume { get;  }
        public int UnitId { get;  }

        public Tank(int id, string name, double volume,double maxvolume, int unitid)
        {
            Id = id;    
            Name = name;
            Volume = volume;
            MaxVolume = maxvolume;
            UnitId = unitid;
        }

        public static Tank[] GetTank()
        {
            return FakeData.tanks.ToArray();
        }

        public static void TankInfo()
        {
            var tanks = GetTank();

            foreach (var item in tanks)
            {
                var unitl = Unit.FindUnitLinq(tanks, item.Name);
                var factory = Factory.FindFactory(unitl);
                Console.WriteLine($"Резервуар {item.Name} принадлежит установке {unitl.Name} завода {factory.Name}");
            }
        }

        public static double TankMass()
        {
            return GetTank().Sum(x => x.Volume);
        }

    }
}
