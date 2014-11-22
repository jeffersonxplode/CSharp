using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {


        
        static void Main(string[] args)
        {


            Agenda agenda = new Agenda();

            int op = 1;     
            string s;
            DateTime d;
            string t;

            while (op != 0)
            {
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("ADICIONE COMPROMISSO");
                        s = Console.ReadLine();
                        d = DateTime.Parse(Console.ReadLine());
                        t = Console.ReadLine();
                        Compromisso c = new Compromisso(s, d, t);
                        agenda.InserirCompromisso(c);
                        break;

                    case 2:
                        Console.WriteLine("LISTANDO COMPROMISSOS");

                        foreach (Compromisso x in agenda.ListarCompromisso())
                        {
                            if (x == null)
                            {
                                continue;
                            }

                            else
                            {
                                Console.WriteLine(x.GetAssunto());
                                Console.WriteLine(x.GetData());
                                Console.WriteLine(x.GetLocal());
                            }
                        }                     
                        break;

                }
            }
        }
    }
}
