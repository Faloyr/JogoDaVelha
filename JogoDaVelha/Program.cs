using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace JogoDaVelha
{
    internal class Program
    {
       
        static string p1 = "1", p2 = "2", p3 = "3", p4 = "4", p5 = "5", p6 = "6", p7 = "7", p8 = "8", p9 = "9", jgd1, jgd2, jogox, jogoy;
        static bool verificarJogada = true;
        static void Main(string[] args)


        {




            Console.WriteLine("Bem vindo ao jogo da velha ");




            Console.WriteLine("Me diga o nome do Jogador 1 (X) ");
            jgd1 = Console.ReadLine();
            Console.WriteLine("Me diga o nome do Jogador 2 (O) ");
            jgd2 = Console.ReadLine();


            Console.Clear();


            while (Program.tpvitorias() == 0)
            {
                if (verificarJogada == true)
                {
                    Program.Jogada1();
                    Program.jgd1jogadas();
                }
                else
                {
                    Program.Jogada2();
                    Program.jgd2jogadas();
                }




            }




            if (tpvitorias() == 2)
            {
                Console.WriteLine($"-------------------------------------------");
                Console.WriteLine($"         O jogo terminou empatado          ");
                Console.WriteLine($"              ");
                Console.WriteLine($"-------------------------------------------");
            }




            else if (tpvitorias() == 1)




                if (quemganhox() == 1)
                {
                    Console.WriteLine($"-------------------------------------------");
                    Console.WriteLine($"      O jogador {jgd1} Venceu !!!   ");
                    Console.WriteLine($"             Parabens ");
                    Console.WriteLine($"-------------------------------------------");
                }


            if (quemganhoy() == 1)
            {
                Console.WriteLine($"-------------------------------------------");
                Console.WriteLine($"      O jogador {jgd2} Venceu !!!   ");
                Console.WriteLine($"             Parabens ");
                Console.WriteLine($"-------------------------------------------");
            }










            Console.ReadKey();


        }


        static void Jogada1()
        {


            Console.WriteLine($"Me diga uma posicao {jgd1}");


            Program.Jogodavelha();
            jogox = (Console.ReadLine());


            Console.Clear();
        }
        static void Jogada2()
        {
            Console.WriteLine($"Me diga outra posicao {jgd2}");


            Program.Jogodavelha();
            jogoy = (Console.ReadLine());
            Program.Jogodavelha();


            Console.Clear();


        }




        static void jgd1jogadas()




        {








            if (jogox == "1" && p1 != "1")
            {
                Console.WriteLine($"Esta posicao e invalida {jgd1}");
            }




            else if (jogox == "1")
            {


                p1 = "X";
                verificarJogada = false;
            }




            if (jogox == "2" && p2 != "2")
            {
                Console.WriteLine($"Esta posicao e invalida {jgd1}");
            }
            else if (jogox == "2")
            {
                p2 = "X";
                verificarJogada = false;
            }




            if (jogox == "3" && p3 != "3")
            {
                Console.WriteLine($"Esta posicao e invalida {jgd1}");
            }


            else if (jogox == "3")
            {
                p3 = "X";
                verificarJogada = false;
            }




            if (jogox == "4" && p4 != "4")
            {
                Console.WriteLine($"Esta posicao e invalida {jgd1}");
            }


            else if (jogox == "4")
            {
                p4 = "X";
                verificarJogada = false;
            }


            if (jogox == "5" && p5 != "5")
            {
                Console.WriteLine($"Esta posicao e invalida {jgd1}");
            }
            else if (jogox == "5")
            {


                p5 = "X";
                verificarJogada = false;
            }


            if (jogox == "6" && p6 != "6")
            {
                Console.WriteLine($"Esta posicao e invalida {jgd1}");
            }


            else if (jogox == "6")
            {




                p6 = "X";
                verificarJogada = false;
            }


            if (jogox == "7" && p7 != "7")
            {
                Console.WriteLine($"Esta posicao e invalida {jgd1}");
            }
            else if (jogox == "7")
            {
                p7 = "X";
                verificarJogada = false;
            }




            if (jogox == "8" && p8 != "8")
            {
                Console.WriteLine($"Esta posicao e invalida {jgd1}");
            }


            else if (jogox == "8")
            {


                p8 = "X";
                verificarJogada = false;
            }
            if (jogox == "9" && p9 != "9")
            {
                Console.WriteLine($"Esta posicao e invalida {jgd1}");
            }
            else if (jogox == "9")
            {




                p9 = "X";
                verificarJogada = false;
            }












        }
        static void jgd2jogadas()


        {








            if (jogoy == "1" && p1 != "1")
            {


                Console.WriteLine($"Esta posicao e invalida {jgd2}");
            }




            else if (jogoy == "1")
            {


                p1 = "O";
                verificarJogada = true;
            }




            if (jogoy == "2" && p2 != "2")
            {


                Console.WriteLine($"Esta posicao e invalida {jgd2}");
            }
            else if (jogoy == "2")
            {
                p2 = "O";
                verificarJogada = true;
            }




            if (jogoy == "3" && p3 != "3")
            {


                Console.WriteLine($"Esta posicao e invalida {jgd2}");
            }


            else if (jogoy == "3")
            {


                p3 = "O";
                verificarJogada = true;
            }




            if (jogoy == "4" && p4 != "4")
            {


                Console.WriteLine($"Esta posicao e invalida {jgd2}");
            }


            else if (jogoy == "4")
            {
                p4 = "O";
                verificarJogada = true;
            }


            if (jogoy == "5" && p5 != "5")
            {


                Console.WriteLine($"Esta posicao e invalida {jgd2}");
            }
            else if (jogoy == "5")
            {


                p5 = "O";
                verificarJogada = true;
            }


            if (jogoy == "6" && p6 != "6")
            {


                Console.WriteLine($"Esta posicao e invalida {jgd2}");
            }


            else if (jogoy == "6")
            {




                p6 = "O";
                verificarJogada = true;
            }


            if (jogoy == "7" && p7 != "7")
            {


                Console.WriteLine($"Esta posicao e invalida {jgd2}");
            }
            else if (jogoy == "7")
            {
                p7 = "O";
                verificarJogada = true;
            }




            if (jogoy == "8" && p8 != "8")
            {


                Console.WriteLine($"Esta posicao e invalida {jgd2}");
            }


            else if (jogoy == "8")
            {


                p8 = "O";
                verificarJogada = true;
            }
            if (jogoy == "9" && p9 != "9")
            {


                Console.WriteLine($"Esta posicao e invalida {jgd2}");
            }
            else if (jogoy == "9")
            {




                p9 = "O";
                verificarJogada = true;
            }






        }
        static void Jogodavelha()
        {






            Console.WriteLine($" {p1} | {p2} | {p3} ");
            Console.WriteLine("---|---|--");
            Console.WriteLine($" {p4} | {p5} | {p6} ");
            Console.WriteLine("---|---|--");
            Console.WriteLine($" {p7} | {p8} | {p9} ");




        }
        static int tpvitorias()
        {
            if (p1 == p2 && p2 == p3)
            {
                return 1;
            }
            else if (p4 == p5 && p5 == p6)
            {
                return 1;
            }
            else if (p7 == p8 && p8 == p9)
            {
                return 1;
            }
            else if (p1 == p4 && p4 == p7)
            {
                return 1;
            }
            else if (p2 == p5 && p5 == p8)
            {
                return 1;
            }
            else if (p3 == p6 && p6 == p9)
            {
                return 1;
            }
            else if (p7 == p5 && p5 == p3)
            {
                return 1;
            }
            else if (p1 == p5 && p5 == p9)
            {
                return 1;
            }


            else if (p1 != "1" && p2 != "2" && p3 != "3" && p4 != "4" && p5 != "5" && p6 != "6" && p7 != "7" && p8 != "8" && p9 != "9")
                return 2;


            else
                return 0;






        }
        static int quemganhox()
        {
            if (p1 == "X" && p1 == p2 && p2 == p3)
            {
                return 1;
            }
            else if (p4 == "X" && p4 == p5 && p5 == p6)
            {
                return 1;
            }
            else if (p7 == "X" && p7 == p8 && p8 == p9)
            {
                return 1;
            }
            else if (p1 == "X" && p1 == p4 && p4 == p7)
            {
                return 1;
            }
            else if (p2 == "X" && p2 == p5 && p5 == p8)
            {
                return 1;
            }
            else if (p7 == "X" && p3 == p6 && p6 == p9)
            {
                return 1;
            }
            else if (p7 == "X" && p7 == p5 && p5 == p3)
            {
                return 1;
            }
            else if (p1 == "X" && p1 == p5 && p5 == p9)
            {
                return 1;
            }


            else
                return 0;




        }
        static int quemganhoy()
        {
            if (p1 == "O" && p1 == p2 && p2 == p3)
            {
                return 1;
            }
            else if (p4 == "O" && p4 == p5 && p5 == p6)
            {
                return 1;
            }
            else if (p7 == "O" && p7 == p8 && p8 == p9)
            {
                return 1;
            }
            else if (p1 == "O" && p1 == p4 && p4 == p7)
            {
                return 1;
            }
            else if (p2 == "O" && p2 == p5 && p5 == p8)
            {
                return 1;
            }
            else if (p7 == "O" && p3 == p6 && p6 == p9)
            {
                return 1;
            }
            else if (p7 == "O" && p7 == p5 && p5 == p3)
            {
                return 1;
            }
            else if (p1 == "O" && p1 == p5 && p5 == p9)
            {
                return 1;
            }


            else
                return 0;




        }


    }
}