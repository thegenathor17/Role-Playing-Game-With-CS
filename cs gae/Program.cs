using cs_gae;
using System.Text.Json;
namespace text_Based_Game_With_CS
{

    class Program
    {
        int[] saveProgress = new int[90];

        string saveName = "";
        //game menu
        void Main()
        {
            while (true)
            {
                Console.WriteLine("Welcome!");
                Console.WriteLine("Do you want to start a new game or do you want to continue with the saved file? 1. Continue 2. Start new game");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Loading...");
                    LoadGame();
                }
                else if (choice == "2")
                {
                    Prologue();
                }
                else if (choice == "Admin: Nahum")
                {
                    ProbarComandos();
                }
                else
                {
                    Console.WriteLine("What?");
                }
            }
        }
        //game menu
        //game
        void Prologue()
        {
            
            Player jugador = new("juan", 3, 25, 100, 1, 1, 0);
            Console.WriteLine("Deep within this dungeon, a legendary hero has been captured by orcs.");  //Primeros dialogos
            Console.WriteLine("A group of brave adventurers has arrived to free him and face the orcish threat.");
            Console.WriteLine("The battle in the dungeon is about to begin!");
            Console.WriteLine("The legendary hero needs a name, what is it?");                           //Primeros dialogos
            string choice = Console.ReadLine(); //Toma el nombre del jugador
            jugador.Nombre = choice; //Cambia el nombre del jugador
            Comandos(choice, jugador); //llama a comandos (en progreso)
            Console.WriteLine($"{jugador.Nombre}? Good name");
            Console.WriteLine("You wake up after a very loud noise, it was the door being knocked down by one of your best friends while the fight is heard in the background.");//Segundo conjunto de dialogos
            //Inicializa a los compañeros
            Human aldric = new(15, 15, 75, "Aldric");
            Human cedric = new(10, 15, 80, 15, "Cedric");
            Human roderick = new(10, 15, 80, "roderick");
            Console.WriteLine($"{jugador.Nombre} wake up");
            //Inicializa a los compañeros
            //Primer QAE
            Console.WriteLine("You wake up still asleep and start walking towards the door unsteadily.");
            while (true)
            {
                Console.WriteLine($"Quick, {jugador.Nombre} choose a weapon: 1.Sword 2. Bow and Arrow");
                choice = Console.ReadLine();
                Comandos(choice, jugador);
                if (choice == "1")
                {
                    Console.WriteLine("Nice!");
                    jugador.HabilidadConLaEspada = 10;
                    Console.WriteLine($"While you were taking the sword, an orc suddenly attacked them. Luckily, you managed to grab the sword, DEFEND YOURSELF!");
                    break;
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Nice!");
                    jugador.HabilidadConElArco = 10;
                    Console.WriteLine($"While you were taking the bow, an orc suddenly attacked them. Luckily, you managed to grab the bow, DEFEND YOURSELF!");
                    break;
                }
                else
                {
                    Console.WriteLine("What?");
                }
            }
            //Primer QAE
            //Primer Combate (temporal)
            Orc enemigoTutorial = new Orc(10, 3, 30);
            Console.WriteLine("Checkpoint reached.");
            SaveGame(jugador, saveProgress);
            Console.WriteLine("You run towards the orc but he easily rejects you.");
            Console.WriteLine("");
            Console.WriteLine("Combat started, here is a little information: ");
            while (true)
            {
                jugador.DisplayStats(jugador.Nombre, jugador.HabilidadConLaEspada, jugador.HabilidadConElArco, jugador.Defensa, jugador.VidaMaxima, jugador.Magia, jugador.Nivel, jugador.Experiencia);
                
                Comandos(choice, jugador);

            }
            //Primer Combate (temporal)

        }
        #region Comandos
        void ProbarComandos()
        {
            Player jugador = new Player("juan", 3, 25, 0, 1, 0, 0);
            Console.WriteLine("Si no eres yo, quien eres?");
            Console.WriteLine("Como sea, bienvenido al probador de comandos");
            Console.WriteLine("Que comando probaremos hoy?");
            string comando = Console.ReadLine();
            switch (comando)
            {
                case "Menu" or "menu":
                    Main();
                    break;
                case "Save" or "save":
                    SaveGame(jugador, saveProgress);
                    break;
                case "defend" or "Defend":
                    jugador.Defend();
                    break;
                case "attack" or "Attack":
                    jugador.Attack(1,2,"tuculo",false);
                    break;
                default:
                    Console.WriteLine("Uh?");
                    break;
            }
            while(true)
            {
                Console.WriteLine("Que otro comando probaremos hoy?");
                comando = Console.ReadLine();
                switch (comando)
                {
                    case "Menu" or "menu":
                        Main();
                        break;
                    case "Save" or "save":
                        SaveGame(jugador, saveProgress);
                        break;
                    case "Defend" or "defend":
                        jugador.Defend();
                        break;
                    case "attack" or "Attack":
                        jugador.Attack(1, 2, "tuculo", false);
                        break;
                    default:
                        Console.WriteLine("Uh?");
                        break;
                }
            }
            Main();
        }
        void Comandos(string comando, Player jugador)
        {
            switch (comando)
            {
                case "Menu" or "menu":
                    Main();
                    break;
                case "Save" or "save":
                    SaveGame(jugador, saveProgress);
                    break;
            }
        }
        static void ComandosEnCombate(string comando, Player jugador, int saludDelEnemigo, int defensaDelEnemigo, string enemigo, bool arco)
        {
            switch (comando)
            {
                case "attack" or "Attack":
                    jugador.Attack(saludDelEnemigo, defensaDelEnemigo, enemigo, arco);
                    break;
                case "Defend" or "defend":
                    jugador.Defend();
                    break;
                case "" or "":
                    break;
            }
        }
        #endregion
        //game
        #region //SaveLoadManager
        //saves
        static void LoadGame()
        {
            try
            {
               
            }
            catch (System.IO.FileNotFoundException)
            {
                
            }
        }
        static void SneekLoadGame()
        {
            try
            {
                
            }
            catch (System.IO.FileNotFoundException)
            {
                
            }
            catch (Exception)
            {
                
            }
        }
        static void SaveGame(Player playerStatistics, int[] Gameprogress)
        {
            
        }
        static Player LoadPlayerData(string filepath)
        {
            
        }
        //saves
        #endregion
    }
}