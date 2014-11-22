using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class ListaClientes
    {

        Cliente[] clientes = new Cliente[10];
        int qtd = 0;

        
        public void InserirClientes(Cliente c)
        {

            if (qtd < 10) { 

            clientes[qtd] = c;
            qtd++;
            }

            else
            {

                Console.WriteLine("Lista de Clientes Cheia");

            }
        
        }


        public Cliente[] ListaCliente()
        {

            return clientes;
           

        }

    }
}
