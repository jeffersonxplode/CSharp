using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer05_06
{
    class Program
    {
        static Loja loja;

        static void Main(string[] args)
        {
       
            int op;
            loja = new Loja("Concencionaria","Neopolis");
            while ((op = Menu()) != 0)
            {
                switch (op)
                {
                    case 1: Adicionar(); break;
                    case 2: ProcurarF(); break;
                    case 3: ProcurarM(); break;
                    case 4: FaixaPreco(); break;
                    case 5: Valor(); break;
                }
            }
        }

        static int Menu()
        {
            Console.WriteLine("Escolha uma opção:\n 0-Fim \n 1 - Adicionar Carros no Estoque \n 2 - Buscar por Marca \n 3 - Por Modelo \n 4 - Por Faixa de Preco \n 5 - Valor do Estoque \n");
            return int.Parse(Console.ReadLine());
        }

        static void Adicionar() {

            string n, f, e;
            double d;
            Console.Write("Marca: ");
            n = Console.ReadLine();
            Console.Write("Modelo: ");
            f = Console.ReadLine();
            Console.Write("Ano: ");
            e = Console.ReadLine();
            Console.Write("Preço: ");
            d = int.Parse (Console.ReadLine());

            Carro carro = new Carro(n, f, e, d);
            loja.AddCar(carro);
        }

        static void ProcurarF()
        {
            Console.WriteLine("Digite a Marca:");
            string n = Console.ReadLine();
            loja.Fabricante(n);
        }

        static void ProcurarM()
        {
            Console.WriteLine("Digite o Modelo:");
            string n = Console.ReadLine();
            loja.Modelo(n);
        }

        static void FaixaPreco()
        {
            int x, y;
            Console.WriteLine("DIGITE O MENOR DEPOIS O MAIOR PRECO");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            loja.FaixaPreco(x,y);
        }

        static void Valor()
        {

           Console.WriteLine( loja.ValorEstoque() ) ;

        }

    }
}

