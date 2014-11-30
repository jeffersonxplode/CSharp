using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Responsavel
    {

        private string nome;
        private string telefone;
        private string email;
        private Crianca[] crianca = new Crianca[3]; // Array de Crianças, Um Responsavel pode ter varias crianças sob sua responsabilidade
        private int qnt = 0;
     

        public Responsavel(string nome, string telefone, string email)
        {

            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            
        }


        public void SetCrianca(Crianca c)
        {
            if (qnt < 3)
            {
                crianca[qnt] = c;
                crianca[qnt].SetResponsavel(this); // No caso quando você coloca a criança sob a responsabilidade, automaticamente ela vira o seu responsavel 
                qnt++;
            }

            else
            {

                Console.WriteLine("CHEIO");

            }

        }

        public string GetNome()
        {

            return nome;

        }

        public string GetTelefone()
        {

            return telefone;

        }

        public string GetEmail()
        {

            return email;

        }


        public Crianca[] GetCrianca()
        {

            return crianca; 

        }





    }
}
