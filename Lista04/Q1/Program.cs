using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, z;

            Progressao pa = new PA();
            Progressao pg = new PG();

            Console.WriteLine("Digite Primeiro termo da PA");

            x = Convert.ToInt32(Console.ReadLine());
            pa.SetPrimeiroE(x);
            Console.WriteLine("Digite a Razão da PA");
            y = Convert.ToInt32(Console.ReadLine());
            pa.SetRazao(y);

            Console.WriteLine("Digite Quantidade de numeros de uma PA a ser mostrada");
           
            z = Convert.ToInt32(Console.ReadLine());
            foreach (double array in pa.GetElementos(z) ){

                Console.WriteLine(array);

            }

            Console.WriteLine("Digite o N-esimo numero de uma PA");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pa.GetElemento(z));

            Console.WriteLine("Digite a soma dos primeiros N numeros de uma PA");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pa.GetSoma(z));

            Console.ReadKey();

        
        
        }
    }
}
