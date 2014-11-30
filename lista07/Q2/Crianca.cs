using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Crianca
    {

        private string nome;
        private DateTime nascimento;
        private Responsavel responsavel;
        
        

        public Crianca(string nome, DateTime nascimento)
        {

            this.nome = nome;
            this.nascimento = nascimento;
          

        }



        public void SetResponsavel(Responsavel r) // Metodo para criar o responsavel
        {


            responsavel = r; 
        

        }

        public string GetNome()
        {

            return nome;

        }


        public DateTime GetNascimento()
        {

            return nascimento;


        }


        public Responsavel GetResponsavel()
        {

            return responsavel;


        }

    
    }
}
