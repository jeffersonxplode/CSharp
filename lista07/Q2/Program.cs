using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {


            // Joguei os Valores direto só para testar, Fique a vontade para criar uma interface, estou sem saco :)

            Responsavel responsavel = new Responsavel("Jefferson","96130292","Jefferson@TADS.com"); 

            Crianca[] criancas = new Crianca[3];

            criancas[0] = new Crianca("joaozinho",DateTime.Parse("12/12/2003")); 
            criancas[1] = new Crianca("Mariazinha", DateTime.Parse("13/1/2001"));
            criancas[2] = new Crianca("Pedrinho", DateTime.Parse("14/02/2000"));

            // Acrescentando as crianças no responsavel

            responsavel.SetCrianca(criancas[0]); 
            responsavel.SetCrianca(criancas[1]);
            responsavel.SetCrianca(criancas[2]);

            Console.WriteLine("Crianças que estão sob a responsabilidade de {0}: \n", responsavel.GetNome());

            foreach (Crianca x in responsavel.GetCrianca()) // Chamando o Array de Crianças do responsavel e imprimindo
            {

                Console.WriteLine("Criança - {0}", x.GetNome());
                Console.WriteLine("Nascido em {0}", x.GetNascimento());
            }

            Console.WriteLine("\n"); 

            Console.WriteLine("Crianças e seus respectivos responsaveis: \n"); 

            for (int i = 0; i < 3; i++)
            {
                // Percorrendo o Array de crianças e imprimido os responsaveis delas

                Console.WriteLine("Criança: {0} - Responsavel: {1}", criancas[i].GetNome(), criancas[i].GetResponsavel().GetNome()); 

            }

            Console.ReadKey();







        
        
        }
    }
}
