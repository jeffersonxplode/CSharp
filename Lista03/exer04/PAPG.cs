using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer04
{
    class PAPG
    {

        private int numero, razao;
        
        private string prog;

  
       
        
        public PAPG(int numero, int razao, string prog)
        {

            this.numero = numero;
            this.prog = prog;
            this.razao = razao;
        }


        public PAPG()
        {
        }

        public void SetNumero(int numero)
        {

            this.numero = numero;

        }

        public void SetRazao(int razao)
        {

            this.razao = razao;

        }

        public void SetProg(string prog)
        {

            this.prog = prog;

        }



        public void elementos(int n)
        {

            int somatoria = numero;


            if (prog == "PA"){

                for (int i = 0; i < n; i++)
                {


                    somatoria = somatoria + razao;

                    Console.WriteLine(somatoria);
                }
            }

             if (prog == "PG"){

                for (int i = 0; i < n; i++) { 
                    
                    
                    somatoria = somatoria * razao;
                    
                    Console.WriteLine(somatoria);
                }
           }
      }

        public void nesimo(int n)
        {

            int somatoria = numero;

            if (prog == "PA")
            {

                for (int i = 0; i < n; i++)
                {

                    somatoria = somatoria + razao;

                }

                Console.WriteLine(somatoria);
            
            }

            if (prog == "PG")
            {
             
                for (int i = 0; i < n; i++)
                {

                    somatoria = somatoria * razao;  
               
                }

                Console.WriteLine(somatoria);
            }
        }


        public void somas(int n)
        {

            int somatoria = 1;
            int soma = 0;

            if (prog == "PA")
            {

                for (int i = 0; i < n; i++)
                {

                    somatoria = somatoria + razao;
                    soma = somatoria + soma;
                }

                Console.WriteLine(soma);

            }

            if (prog == "PG")
            {

                for (int i = 0; i < n; i++)
                {

                    somatoria = somatoria * razao;
                    soma = somatoria + soma;
                }

                Console.WriteLine(soma);
            }





        }

    
    }
}
