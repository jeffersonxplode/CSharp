using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class PA : Progressao
    {

        public override double[] GetElementos(int x)
        {

            double[] somatoria = new double[x];

            for (int i = 0; i < x; i++)
            {

                somatoria[i] = GetRazao() + GetPrimeiroE() * i;

            }

            return somatoria;

        }

        public override double GetElemento(int x)
        {

            double somatoria = 0;

            for (int i = 0; i < x; i++)
            {

                somatoria = GetRazao() + GetPrimeiroE() * i;

            }

            return somatoria;

        }



        public override double GetSoma(int x)
        {

            double somat = 0;
            double somatoria;

            for (int i = 0; i < x; i++)
            {

                somatoria = GetRazao() + GetPrimeiroE() * i;
                somat = somatoria + somat;
            }


            return somat;


        }
 }
}
