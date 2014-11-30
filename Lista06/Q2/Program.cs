using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    class Program
    {
        static void Main(string[] args)
        {


            int op = 1;
            ListaClientes lista = new ListaClientes();

            while (op != 0)
            {

                Console.WriteLine("Digite \n 1 para adicionar cliente \n 2 para listar os clientes \n 3 Para adiconar Socio para um determinado cliente \n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:

                        string a = Console.ReadLine();
                        string b = Console.ReadLine();
                        int c = int.Parse(Console.ReadLine());
                        Cliente cliente = new Cliente(a, b, c);
                        lista.AdicionarCliente(cliente);

                        break;

                    case 2:


                        foreach (Cliente x in lista.ListarClientes())
                        {

                            if (x == null)
                            {

                                continue;

                            }

                            else
                            {

                                Console.WriteLine(x.GetNome());
                                Console.WriteLine(x.GetCpf());
                                Console.WriteLine(x.GetLimite());
                                Console.WriteLine(x.GetNomeSocio());




                            }
                        }

                        break;

                    case 3:

                        Console.WriteLine("DIGITE O NOME DO CLIENTE PARA POR O SOCIO");
                        string nome = Console.ReadLine();

                        foreach (Cliente x in lista.ListarClientes())
                        {



                            if (x == null)
                            {

                                continue;
                            }

                            else
                            {

                                if (x.GetNome() == nome)
                                {

                                    Console.WriteLine("Cliente Achado, Digite o socio");

                                    string As = Console.ReadLine();
                                    string Bs = Console.ReadLine();
                                    int Cs = int.Parse(Console.ReadLine());
                                    Cliente socio = new Cliente(As, Bs, Cs);

                                    x.SetSocio(socio);

                                }

                                else
                                {

                                    Console.WriteLine("Cliente Não encontrado");

                                }

                            }
                            
                        }
                        break;



                }














            }
        }
    }
}
