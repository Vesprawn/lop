using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legend_of_prawn
{
    class Program
    {
        public static bool gameRunning = true;
        public static Player player;
        private const string QUIT = "QUIT";
        private const string EXIT = "EXIT";

        static void Main(string[] args)
        {
            start();
        }

        public static void update() {
            Console.Clear();
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("||                                                   Legend of Prawn                                                  ||");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("{0}", player.Name);
            Console.WriteLine("{0}/{1}", player.HP, player.MaxHP);
        }

        public static void gameOver() {
            gameRunning = false;
            Console.Clear();
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("||                                                      GAME OVER                                                     ||");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("Do you want to start again?");
            Console.WriteLine("[y]es / [n]o ");
            var input = Console.ReadLine().ToUpper().Trim();

            switch (input) {
                case "Y":
                    restart();
                    break;
                case "YES":
                    restart();
                    break;
                default:
                    // DO nothing and EXIT
                    break;
            }
        }

        public static void restart() {
            start();
        }

        public static void start() {
            player = new Player();
            gameRunning = true;
            update();

            while (gameRunning)
            {
                var input = Console.ReadLine().ToUpper().Trim();
                Console.WriteLine("User input: {0}", input);
                switch (input)
                {
                    case "TESTDMG":
                        player.TakeDamage(30);

                        if (player.HP <= 0)
                        {
                            gameOver();
                        }
                        update();
                        break;
                    case QUIT:
                        gameOver();
                        break;
                    case EXIT:
                        gameOver();
                        break;
                    default:
                        update();
                        Console.WriteLine("Unrecognised command {0}", input);
                        break;
                }
            }
        }
    }
}
