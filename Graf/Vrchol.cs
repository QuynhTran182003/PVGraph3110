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
            set {
                if(value < 0)
                {
                    throw new ArgumentException("Nesmi hodnota mensi nez 0");
                }
                hodnota = value; 
            } 
        }

        

        
    }
}
