using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Jogo
    {

        Time timea;
        Time timeb;      
        private int placarA;
        private int placarB;
        private string fase;
        

        public Jogo(Time a, Time b, int placarA, int placarB, string fase)
        {

            this.timea = a;
            this.timeb = b;
            this.placarA = placarA;
            this.placarB = placarB;
            this.fase = fase;
            
        }


        public string GetNomeA()
        {

            return timea.GetNome();


        }

        public string GetNomeB()
        {

            return timeb.GetNome();


        }

        public int GetPlacarA()
        {

            return placarA;


        }


        public int GetPlacarB()
        {

            return placarB;


        }


        public string GetFase()
        {

            return fase;


        }
    
    }
}
