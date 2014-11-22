using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Agenda
    {

        private Compromisso[] compromissos = new Compromisso[10];
        private int qnt = 0;

        public void InserirCompromisso(Compromisso c)
        {
           
            if (qnt > 10) {

                Console.WriteLine("Agenda Cheia");
            
            }

            else
            {

                compromissos[qnt] = c;
                qnt++;


            }
        }

        public Compromisso[] ListarCompromisso()
        {


            return compromissos;
      
        }


    
    }
}
