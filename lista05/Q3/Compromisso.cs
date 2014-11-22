using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Compromisso
    {

        

        private string assunto;
        private DateTime data;
        private string local;

        public Compromisso(string assunto, DateTime data, string local)
        {

            this.assunto = assunto;
            this.data = data;
            this.local = local;


        }

        public string GetAssunto()
        {

            return assunto;

        }

        public DateTime GetData()
        {

           return data;

        }


        public string GetLocal()
        {

            return local;

        }




    
    }


}
