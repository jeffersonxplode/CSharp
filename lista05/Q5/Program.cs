using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {

            int op=1;
            string Timea;
            string Timeb;
            string estadoa;
            string estadob;
            int placarA;
            int placarB;
            string fase;



            Campeonato campeonatos = new Campeonato("BRASILEIRAO");

            while (op != 0)
            {

                Console.WriteLine("\n DIGITE:\n 1 - Inserir Times \n 2 - Listar jogos \n 3 - Listar Jogos pro fase \n 0 - Para Sair \n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:

                        Console.WriteLine("Digite Nome Time 1");
                        Timea = Console.ReadLine();
                        Console.WriteLine("Digite Nome Time 2");
                        Timeb = Console.ReadLine();
                        Console.WriteLine("Digite Estado Time 1");
                        estadoa = Console.ReadLine();
                        Console.WriteLine("Digite Estado Time 2");
                        estadob = Console.ReadLine();
                        Console.WriteLine("Digite Placar Time 1");
                        placarA = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite Placar Time 2");
                        placarB = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite Fase");
                        fase = Console.ReadLine();
                        Time a = new Time(Timea,estadoa);
                        Time b = new Time(Timeb,estadob);
                        Jogo jogo = new Jogo(a,b,placarA,placarB,fase);
                        campeonatos.InserirJogo(jogo);
                        break;
                    
                    case 2:

                        foreach(Jogo x in campeonatos.ListarJogos()){

                            if (x == null)
                            {

                                continue;
                            }


                            else
                            {
                                Console.WriteLine("------JOGO-------- \n");
                                Console.WriteLine("TIME A: " + x.GetNomeA());
                                Console.WriteLine("TIME B: " + x.GetNomeB());
                                Console.WriteLine("Placar Time A: " + x.GetPlacarA());
                                Console.WriteLine("Placar Time B: " + x.GetPlacarB());
                                Console.WriteLine("Fase: " + x.GetFase());

                            }
                        }
                        break;

                    case 3:

                        Console.WriteLine("Digite a Fase");
                        string s = Console.ReadLine();
                        foreach(Jogo x in campeonatos.ListarJogos(s)){

                            if (x == null)
                            {

                                continue;
                            }

                            else
                            {
                                Console.WriteLine("Times da Fase - " + s);
                                Console.WriteLine("TIME A: " + x.GetNomeA());
                                Console.WriteLine("TIME B: " + x.GetNomeB());
                                Console.WriteLine("Placar Time A: " + x.GetPlacarA());
                                Console.WriteLine("Placar Time B: " + x.GetPlacarB());
                                

                            }

                        }
                        break;
                
                }


            }







        
        }
    }
}
