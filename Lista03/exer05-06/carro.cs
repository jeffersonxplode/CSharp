using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer05_06
{
    class Carro
    {

        private string marca;
        private string nome;
        private string ano;
        private double preco;


        public Carro(){

        }

        public Carro(string marca, string nome, string ano, double preco)
        {

            this.marca = marca;
            this.nome = nome;
            this.ano = ano;
            this.preco = preco;

        }


        public void SetMarca(string marca){

            this.marca = marca;

        }
        
        public void SetNome(string nome){

            this.nome = nome;

        }
        
        public void SetAno(string ano){

            this.ano = ano;
        }
    
        public void SetPreco(double preco){

            this.preco = preco;
        }
    
        public string GetMarca(){

            return marca;

        }

        public string GetNome(){

            return nome;

        }


        public string GetAno(){

            return ano;

        }


        public double GetPreco(){

            return preco;

        }




    }
}
