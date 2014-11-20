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

            Ipessoa[] pessoas = new Ipessoa[5];

            pessoas[0] = new Aluno("TADS", "Aluno1", DateTime.Parse("28/02/1989"), "0000000000000000");
            pessoas[1] = new Professor("DIATINF", "Professor1", DateTime.Parse("10/11/1975"), "0000000000001");
            pessoas[2] = new Professor("DIATINF", "Professor2", DateTime.Parse("14/1/2001"), "0000000000000");
            pessoas[3] = new Aluno("Comercio exterior", "Aluno2", DateTime.Parse("10/9/1990"), "00000000000");
            pessoas[4] = new Aluno("TADS", "ALuno3", DateTime.Parse("9/11/1989"), "000000000");


            foreach (Ipessoa x in pessoas) {

                if (DateTime.Now.Month == x.GetNascimento().Month)
                {

                    Console.WriteLine(x.GetNome());


                }
                
            
            
            }

            Console.ReadKey();







        }
    }
}
