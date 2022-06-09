using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IAbles
    {
        public abstract void Add(object value);
    }
    interface IAddRangeable
    {

        public abstract void AddRange(ICollection c);
    }
    interface IRemoveable 
    {
        public abstract void Removeab(object? obj);

    }
    interface IRemoveAtble
    {
        public abstract void RemoveAt(int index);


    }
    interface ITrimable
    {
        public abstract void Trim();

    }

}
