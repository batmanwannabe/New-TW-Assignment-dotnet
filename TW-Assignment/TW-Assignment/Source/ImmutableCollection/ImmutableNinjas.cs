using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW_Assignment.Source.ImmutableCollection
{
    public class ImmutableNinjas
    {
        public IList<Ninja> Ninjas { get; set; }

        public ImmutableNinjas(IList<Ninja> ninjas)
        {
            Ninjas = ninjas;
        }

        public ImmutableNinjas All
        {
            get { return this; }
        }

        public void Add(Ninja ninja)
        {
            throw new NinjaException();
        }

        public void Remove(Ninja ninja)
        {
            throw new NinjaException();
        }

        public int Count()
        {
            return Ninjas.Count();
        }
    }

    public class Ninja
    {
        public string Name { get; private set; }
        public Ninja(string name)
        {
            Name = name;
        }
    }

    public class NinjaException : Exception { }
}
