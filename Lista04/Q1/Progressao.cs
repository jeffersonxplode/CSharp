using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    abstract class Progressao
    {

            private double primeiroE;
            private double razao;

            public Progressao()
            {

            }

            public void SetPrimeiroE(double num)
            {

                primeiroE = num;

            }

            public void SetRazao(double num)
            {

                razao = num;

            }


            public double GetPrimeiroE()
            {

                return primeiroE;

            }


            public double GetRazao()
            {

                return razao;

            }

            public abstract double[] GetElementos(int x);
            public abstract double GetElemento(int x);
            public abstract double GetSoma(int x);

    
    
    
    }
}
