using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Cubo : Figura3D
    {

        public double area;
        public double largura;
        public double comprimento;


        public Cubo(double area, double largura, double comprimento)
        {

            this.area = area;
            this.largura = largura;
            this.comprimento = comprimento;

        }

        public override double volume()
        {

            return area * largura * comprimento;


        }
    
    
    }
}
