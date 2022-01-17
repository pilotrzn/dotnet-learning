using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Models.Data.Class
{
    /// <summary>
    /// Завод
    /// </summary>
    public class Factory
    {
        public int Id { get; }
        public string  Name { get; }
        public string  Description { get; }

        public Factory(int id,string name,string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public static Factory[] GetFactories()
        {
            return FakeData.factories.ToArray();
        }

        public static Factory FindFactory(Unit unit)
        {
            return GetFactories().FirstOrDefault(x => x.Id == unit.FactoryId);
        }
    }
}
