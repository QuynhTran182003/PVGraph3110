using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    class Graf<T>
    {
        private Dictionary<Vrchol<T>, HashSet<Soused<T>>> mujGraf = new Dictionary<Vrchol<T>, HashSet<Soused<T>>>();
        private bool isWeighted = false;

        public bool IsWeighted { get { return isWeighted; } }
        public bool AddEdge(T startNodeValue, T endNodeValue, int weight = 1)
        {
            if(!isWeighted && weight != 1)
            {
                throw new GraphException();
            }
            Vrchol<T> startNode = new Vrchol<T>(startNodeValue);
            Vrchol<T> endNode = new Vrchol<T>(endNodeValue);
            Soused<T> soused = new Soused<T>(endNode, weight);

            if (!mujGraf.ContainsKey(startNode))
            {
                mujGraf.Add(startNode, new HashSet<Soused<T>>());
            }
            return mujGraf[startNode].Add(soused);
        }
    }
}
