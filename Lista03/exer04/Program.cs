using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer04
{
    class Program
    {
        static void Main(string[] args)
        {

            PAPG papg = new PAPG();

            Console.WriteLine("Digite o primeiro numero");

            papg.SetNumero(System.Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine("Digite a razao");

            papg.SetRazao(System.Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine("Digite o tipo de progressão (PA OU PG)");

            papg.SetProg((Console.ReadLine()));

            Console.WriteLine("Digite os quantos n elementos da progressão serão imprimidos");

            papg.elementos(System.Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine("Digite o N elemento da progressão");

            papg.nesimo(System.Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine("Digite o N da soma dos N elementos");

            papg.somas(System.Convert.ToInt16(Console.ReadLine()));

            Console.ReadKey();

        }
    }
}
