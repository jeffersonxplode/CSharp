using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Campeonato
    {

        private string nome;
        Jogo[] jogos = new Jogo[4];
        int qtd = 0;

        public Campeonato(string nome)
        {

            this.nome = nome;

        }


        public void InserirJogo(Jogo c)
        {

            if (qtd < 4)
            {

                jogos[qtd] = c;
                qtd++;

            }

            else
            {
                Console.WriteLine("TABELA CHEIA");

            }
        }


        public Jogo[] ListarJogos()
        {

            return jogos;

        }



        public Jogo[] ListarJogos(string fase)
        {

            Jogo[] aux = new Jogo[qtd];
            int i = 0;

            foreach (Jogo c in jogos)
            {

                if (c == null)
                {
                    continue;

                }
                
                else{

                    if (c.GetFase() == fase)
                    {
                        aux[i] = c;
                        i++;
                    }

                    else { continue; }
                
                }

            }

            return aux;
        }
    
    


    }
}
