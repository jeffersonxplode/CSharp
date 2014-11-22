using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
        
            ListaClientes clientes = new ListaClientes();

            int op = 1;     
            string s;
            int d;
            string t;

            while (op != 0)
            {

                Console.WriteLine("ESCOLHA O TIPO DE CLIENTE - 1 FISICO - 2 JURIDICO - 3 PARA LISTAR CLIENTES");
                op = int.Parse(Console.ReadLine());           
                switch (op)
                {
                    
                    case 1:
                        Console.WriteLine("ADICIONE CLIENTE FISICO(NOME/ID/CPF)");
                        s = Console.ReadLine();
                        d = int.Parse(Console.ReadLine());
                        t = Console.ReadLine();
                        PessoaFisica f = new PessoaFisica(s,d,t);
                        clientes.InserirClientes(f);
                        break;
                    
                    case 2:

                        Console.WriteLine("ADICIONE CLIENTE JURIDICO(NOME/ID/CNPJ)");
                        s = Console.ReadLine();
                        d = int.Parse(Console.ReadLine());
                        t = Console.ReadLine();
                        PessoaJuridica j = new PessoaJuridica(s,d,t);
                        clientes.InserirClientes(j);
                        break;

                    case 3:
                        Console.WriteLine("LISTANDO CLIENTES");

                        foreach (Cliente x in clientes.ListaCliente())
                        {
                            if (x == null)
                            {
                                continue;
                            }

                            else
                            {
                                if (x.GetCnpj() == null) //Gambiarra Fuderosa hahahahahaha
                                {
                                    Console.WriteLine(x.GetNome());
                                    Console.WriteLine(x.GetCpf());
                                }

                                else
                                {
                                    Console.WriteLine(x.GetNome());
                                    Console.WriteLine(x.GetCnpj());
                                    
                                }
                            }
                        }                     
                        break;

                }
            }
        }
        
        
        
        
        
        }
}

