using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    class Cliente
    {

        private string nome;
        private string cpf;
        private Cliente socio;
        private double limite;


        public Cliente(string nome, string cpf,double limite) {


            this.nome = nome;
            this.cpf = cpf;
            this.limite = limite;
        
        
        }


        public void SetSocio(Cliente c)
        {

            this.socio = c;
            c.socio = this;
        }


        public double GetLimite()
        {

            if (socio == null)
            {

                return limite;

            }

            else {



                return limite + socio.limite; 
            
            }
        
        }


        public string GetNome() {

            return nome;
        
        }

        public string GetCpf() {

            return cpf;
        
        }

        public string GetNomeSocio() {

            if (socio == null) {


                return "Não existe Socio";
            
            }
        
            else{
            
                return socio.GetNome();
            
            }
        }
    
        
    
    
    
    }
}
