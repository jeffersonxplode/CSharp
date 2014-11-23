using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Cone : Figura3D
    {

        private double pi = Math.PI;
        private double raio;
        private double altura;

        public Cone(double raio, double altura)
        {

            this.raio = raio;
            this.altura = altura;
        }

        public override double volume()
        {


            return (pi * Math.Pow(raio, 2) * altura) / 3;

        }
    
    }
}
