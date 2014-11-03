using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {

            Circulo bola = new Circulo();

            Console.WriteLine("Digite o Raio");

            bola.SetRaio(System.Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine(bola.calculo());

            Console.ReadKey();
        
        }
    }
}
