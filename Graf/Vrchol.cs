using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    class Vrchol<T>
    {
        private T hodnota;

        public Vrchol(T hodnota)
        {
            this.Hodnota = hodnota;
        }
        public T Hodnota 
        {
            get { return hodnota; } 
            set { hodnota = value; } 
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
            return hodnota.ToString();
        }
    }
}
