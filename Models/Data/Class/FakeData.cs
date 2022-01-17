using System;
using System.Collections.Generic;
using System.Text;
using Models.Data.Class;

namespace Models.Data.Class
{
    public static class FakeData
    {
        public static List<Factory> factories = new List<Factory>()
        {
            new Factory(1,"НПЗ#1","Первый нефтеперерабатывающий завод"),
            new Factory(2,"НПЗ#2","Второй нефтеперерабатывающий завод")
        };

        public static List<Unit> units = new List<Unit>()
        {
            new Unit(1,"ГФУ-2",1),
            new Unit(2,"АВТ-6",1),
            new Unit(3,"АВТ-10",2),
        };

        public static List<Tank> tanks = new List<Tank>()
        {
            new Tank(1,"Резервуар 1",1500,2000,1),
            new Tank(2,"Резервуар 2",2500,3000,1),
            new Tank(3,"Дополнительный резервуар 24",3000,3000,2),
            new Tank(4,"Резервуар 35",3000,3000,2),
            new Tank(5,"Резервуар 47",4000,5000,2),
            new Tank(6,"Резервуар 256",500,500,3),
        };
    }
}
