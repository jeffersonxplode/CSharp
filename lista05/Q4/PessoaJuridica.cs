using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class PessoaJuridica : Cliente
    {


        private string cnpj;
        private string n = null; //Gambiarra

        public PessoaJuridica(string nome, int id, string cnpj)
            : base (id, nome)
        {

            this.cnpj = cnpj;


        }

        public override string GetCnpj()
        {

            return cnpj;

        }


        public override string GetCpf()
        {

            return n; //Como veio de uma classe abstrata tive que obrigatoriamente impelmentar esse metodo, e fiz uma gambi

        }

    }   

}
