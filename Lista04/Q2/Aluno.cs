using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Aluno : Pessoa
    {

        private string curso;
   

        public Aluno(string curso, string nome, DateTime nascimento, string matricula)
            : base(nome, nascimento, matricula)
        {

            this.curso = curso;

        }
    
    
    
    
    }
}
