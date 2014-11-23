using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
        
        
            Figura3D[] figuras = new Figura3D[3];

            figuras[0] = new Esfera(4);
            figuras[1] = new Cubo(4,3,2);
            figuras[2] = new Cone(2,7);

            Console.WriteLine(figuras[0].volume());
            Console.WriteLine(figuras[1].volume());
            Console.WriteLine(figuras[2].volume());

            Console.ReadKey();
        
        }
    }
}
