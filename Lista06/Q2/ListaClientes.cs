using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    class ListaClientes
    {


        Cliente[] clientes = new Cliente[10];
        public int qtd = 0;


        public void AdicionarCliente(Cliente c)
        {

            if (qtd < 10)
            {

                clientes[qtd] = c;
                qtd++;

            }

            else
            {

                Console.WriteLine("Lista Cheia");

            }
        }

        public Cliente[] ListarClientes() {


            return clientes;
        
        }
    
    
    
    
    
    }
}
