using System;

namespace Morra_Cinese_Commentato
{
    class Program
    {
        public static string mossa_giocatore1 = "";
        public static string mossa_giocatore2 = "";
        public static int Vittorie_giocatore1 = 0;
        public static int Vittorie_giocatore2 = 0;
        public static string Sasso = "Sasso";
        public static string Carta = "Carta";
        public static string Forbice = "Forbice";

        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel gioco della morra cinese.");

            Console.Write("\nInserisci il nome del ");
            Console.ForegroundColor = ConsoleColor.Blue; //cambio colore delle parole a schermo
            Console.Write("giocatore 1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");

            string nome_giocatore_1 = Console.ReadLine();

            Console.Write("\nInserisci il nome del ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("giocatore 2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");

            string nome_giocatore_2 = Console.ReadLine();

            do
            {
                Console.Clear(); //pulisce la console

                Console.Write("\nOra e' il turno del giocatore ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{nome_giocatore_1}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");


                Console.Write("Scegli che se vuoi buttare sasso ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("(digita S), ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("forbice ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("(digita D) ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("o carta ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("(digita A)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

                string Scelta_Giocatore_1 = Convert.ToString(Console.ReadKey(true).KeyChar); //assegnazione valore di Scelta_Giocatore_1 e do valore letto da schermo (il valore è solo un carattere)

                while (Scelta_Giocatore_1 != "S" && Scelta_Giocatore_1 != "D" && Scelta_Giocatore_1 != "A") //ciclo che controlla che l'utente abbia messo una riposta accettabile
                {
                    Console.Clear();
                    Console.WriteLine("La risposta inserita non e' corretta...");

                    Console.Write("Scegli che se vuoi buttare sasso ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("(digita S), ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("forbice ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("(digita D) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("o carta ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("(digita A)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(".");

                    Scelta_Giocatore_1 = Convert.ToString(Console.ReadKey(true).KeyChar); //assegnazione valore di Scelta_Giocatore_1 e do valore letto da schermo (il valore è solo un carattere)
                }

                if (Scelta_Giocatore_1 == "S") //converte la scelta del giocatore Sasso
                {
                    mossa_giocatore1 = Sasso;
                }
                else if (Scelta_Giocatore_1 == "D") //converte la scelta del giocatore Forbice
                {
                    mossa_giocatore1 = Forbice;
                }
                else if (Scelta_Giocatore_1 == "A") //converte la scelta del giocatore Carta
                {
                    mossa_giocatore1 = Carta;
                }

                Console.Write("\nOra e' il turno del giocatore ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{nome_giocatore_2}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

                Console.Write("Scegli che se vuoi buttare sasso ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("(digita K), ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("forbice ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("(digita L) ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("o carta ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("(digita J)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

                string Scelta_Giocatore_2 = Convert.ToString(Console.ReadKey(true).KeyChar);

                while (Scelta_Giocatore_2 != "K" && Scelta_Giocatore_2 != "L" && Scelta_Giocatore_2 != "J")
                {
                    Console.Clear();
                    Console.WriteLine("La risposta inserita non e' corretta...");

                    Console.Write("Scegli che se vuoi buttare sasso ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("(digita K), ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("forbice ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("(digita L) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("o carta ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("(digita J)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(".");

                    Scelta_Giocatore_2 = Convert.ToString(Console.ReadKey(true).KeyChar);
                }

                if (Scelta_Giocatore_2 == "K") //converte la scelta del giocatore Sasso
                { 
                    mossa_giocatore2 = Sasso;
                }
                else if (Scelta_Giocatore_2 == "L") //converte la scelta del giocatore Forbice
                {
                    mossa_giocatore2 = Forbice;
                } 
                else if (Scelta_Giocatore_2 == "J") //converte la scelta del giocatore Carta
                {
                    mossa_giocatore2 = Carta;
                }


                if (mossa_giocatore1 == mossa_giocatore2)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nPAREGGIO");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (mossa_giocatore1 == Sasso && mossa_giocatore2 == Forbice)
                {
                    Console.Write("\nHA VINTO IL GIOCATORE ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{nome_giocatore_1}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(".");

                    Vittorie_giocatore1++;
                }
                else if (mossa_giocatore1 == Sasso && mossa_giocatore2 == Carta)
                {
                    Console.Write("\nHA VINTO IL GIOCATORE ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($"{nome_giocatore_2}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(".");

                    Vittorie_giocatore2++;
                }
                else if (mossa_giocatore1 == Forbice && mossa_giocatore2 == Sasso)
                {
                    Console.Write("\nHA VINTO IL GIOCATORE ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($"{nome_giocatore_2}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(".");

                    Vittorie_giocatore2++;
                }
                else if (mossa_giocatore1 == Forbice && mossa_giocatore2 == Carta)
                {
                    Console.Write("\nHA VINTO IL GIOCATORE ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{nome_giocatore_1}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(".");

                    Vittorie_giocatore1++;
                }
                else if (mossa_giocatore1 == Carta && mossa_giocatore2 == Sasso)
                {
                    Console.Write("\nHA VINTO IL GIOCATORE ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{nome_giocatore_1}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(".");

                    Vittorie_giocatore1++;
                }
                else if (mossa_giocatore1 == Carta && mossa_giocatore2 == Forbice)
                {
                    Console.Write("\nHA VINTO IL GIOCATORE ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($"{nome_giocatore_2}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(".");

                    Vittorie_giocatore2++;
                }

                Console.Write("\nPer continuare premere qualsiasi tasto, però se vuoi terminare il gioco, ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("premi X");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");

            } while (Console.ReadKey().Key != ConsoleKey.X); //do while che continua fino a quando digiti X

            Console.Clear();

            if (Vittorie_giocatore1 == Vittorie_giocatore2) //pareggio
            {
                Console.Write("Il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{nome_giocatore_1} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("e il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{nome_giocatore_2} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("hanno pareggiato");
                Console.WriteLine(".");
            }
            else if (Vittorie_giocatore1 > Vittorie_giocatore2) //vince giocatore 1
            {
                Console.Write("Il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{nome_giocatore_1} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ha vinto contro il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{nome_giocatore_2}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");
            }
            else if (Vittorie_giocatore2 > Vittorie_giocatore1) //vince giocatore 2
            {               
                Console.Write("Il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{nome_giocatore_2} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ha vinto contro il Giocatore ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{nome_giocatore_1}");                         
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(".");
            }            

            Console.Write("\nIl Giocatore ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{nome_giocatore_1} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ha vinto n°: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{Vittorie_giocatore1}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", mentre il Giocatore ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{nome_giocatore_2} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ha vinto n°: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"{Vittorie_giocatore2}");            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");


            Console.ReadKey();
        }
    }
}
