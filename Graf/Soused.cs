using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    class Soused<T>
    {
        private Vrchol<T> vrchol;
        private int weight;
        public Soused(Vrchol<T> endNode, int weight)
        {
            EndNode = endNode;
            Weight = weight;
        }

        public Vrchol<T> EndNode { get; }
        public int Weight { get; }

        public Soused(T nodeValue, int weight = 1)
        {
            this.vrchol = new Vrchol<T>(nodeValue);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.vrchol.ToString() + weight;
        }
    }
}
