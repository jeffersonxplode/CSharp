using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1
{
    class Circulo
    {

        private double area;
        private double raio;
        private const double pi = Math.PI;

        
        public Circulo(){
        
        }    
    
        public void SetRaio (double raio) {

            this.raio = raio;
        
        }


        public double calculo() {


            return area = pi * (raio * 2);
            
        }

        



    }
}
