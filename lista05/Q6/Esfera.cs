using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Esfera : Figura3D
    { 
    
        
        private double pi = Math.PI;
        private double raio;

       public  Esfera(double raio)
        {
            this.raio = raio;

        }


        public override double volume()
        {

            return (4 * pi * Math.Pow(raio, 3) )/3;

        }
    
    }
}
