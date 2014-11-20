using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Professor : Pessoa
    {

        private string diretoria;

        public Professor(string diretoria, string nome, DateTime nascimento, string matricula)
            : base(nome, nascimento, matricula)
        {

            this.diretoria = diretoria;

        }
        
    
    }
}
