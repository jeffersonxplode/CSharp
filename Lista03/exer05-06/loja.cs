using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer05_06
{
    class Loja
    {

        private string nome;
        private string endereco;
        private Carro[] estoque;
        private int qnt = 0;

        public Loja(string nome, string endereco)
        {
            this.nome = nome;
            this.endereco = endereco;
            estoque = new Carro[5];
        }
    
        public void AddCar(Carro c){

            if(qnt < 5){

                estoque[qnt] = c;
                qnt++;
            }

            else
            {
                Console.WriteLine("ESTOQUE CHEIO");
            }
        }


        public void Fabricante(string n)
        {

            for (int i = 0; i < qnt; i++)
            {

                if (estoque[i].GetMarca() == n)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}",
                            estoque[i].GetMarca(),
                            estoque[i].GetNome(),
                            estoque[i].GetAno(),
                            estoque[i].GetPreco()
                            );
                }
            }
        }


        public void Modelo(string n)
        {

            for (int i = 0; i < qnt; i++)
            {

                if (estoque[i].GetNome() == n)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}",
                            estoque[i].GetMarca(),
                            estoque[i].GetNome(),
                            estoque[i].GetAno(),
                            estoque[i].GetPreco()
                            );
                }
            }
        }

        public void FaixaPreco(double n, double j)
        {

            for (int i = 0; i < qnt; i++)
            {

                if (estoque[i].GetPreco() > n && estoque[i].GetPreco() < j)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}",
                            estoque[i].GetMarca(),
                            estoque[i].GetNome(),
                            estoque[i].GetAno(),
                            estoque[i].GetPreco()
                            );
                }
            }
        }

        public double ValorEstoque()
        {

            double valort = 0;

            for (int i = 0; i < qnt; i++)
            {

                valort = estoque[i].GetPreco() + valort;
                           
            }
            
            return valort;
        }
        
    }



    }

