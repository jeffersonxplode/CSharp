using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Time
    {
    
        private string nome;
        private string estado;

        public Time(string nome, string estado)
        {

            this.estado = estado;
            this.nome = nome;

        }


        public string GetNome()
        {

            return nome;

        }
    }
}
