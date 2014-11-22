using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    abstract class Cliente
    {
        
        private int id;
        private string nome;


        public Cliente(int id, string nome)
        {

            this.id = id;
            this.nome = nome;

        }

        public string GetNome()
        {

            return nome;


        }

        //Não conseguir Resolver esse problema, tiver que criar essa Classe Abstrata para chamar esses metodos

        public abstract string GetCnpj();
        public abstract string GetCpf();

       

    }
}
