using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class PessoaFisica : Cliente
    {


        private string cpf;
        private string n = null; //Gambiarra

        public PessoaFisica(string nome, int id, string cpf)
            : base (id, nome)
        {

            this.cpf = cpf;


        }

        public override string GetCpf()
        {

            return cpf;

        }


        public override string GetCnpj()
        {

            return n; //Como veio de uma classe abstrata tive que obrigatoriamente impelmentar esse metodo, e fiz uma gambi

        }

    }
}
