using System.Data.Common;
using System.Runtime.Serialization.Json;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Net.Http.Headers;
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System;
using System.IO;
using cs_gae;
using System.Text.Json;
namespace text_Based_Game_With_CS
{
    class Program
    {

        //game menu
        static void Main(string[] args)
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
                Game();
            }
            else
            {
                Console.WriteLine("What?");
            }
        }
        static void GameMenu()
        {
            Console.WriteLine("Do you want to start a new game or do you want to continue with the saved file? 1. Continue 2. Start new game");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Loading...");
                LoadGame();
            }
            else if (choice == "2")
            {
                Game();
            }
            else
            {
                Console.WriteLine("What?");
            }
        }
        //game menu
        //game
        static void Game()
        {
            string choice = "";
            Console.WriteLine("Deep within this dungeon, a legendary hero has been captured by orcs.");
            Console.WriteLine("A group of brave adventurers has arrived to free him and face the orcish threat.");
            Console.WriteLine("The battle in the dungeon is about to begin!");
            Console.WriteLine("The legendary hero needs a name, what is it?");
            Player jugador = new(Console.ReadLine(), 3, 25, 0, 1, 0, 0);
            Console.WriteLine($"{jugador.Nombre}? Good name");
            Console.WriteLine("You wake up after a very loud noise, it was the door being knocked down by one of your best friends while the fight is heard in the background.");
            Human aldric = new(15, 15, 75, "Aldric");
            Human cedric = new(10, 15, 80, 15, "Cedric");
            Human roderick = new(10, 15, 80, "roderick");
            Console.WriteLine($"{jugador.Nombre} wake up");
            Console.WriteLine("You wake up still asleep and start walking towards the door unsteadily.");
            while (true)
            {
                Console.WriteLine($"Quick, {jugador.Nombre} choose a weapon: 1.Sword 2. Bow and Arrow");
                choice = Console.ReadLine();
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
            Orc enemigoTutorial = new Orc(10, 3, 30);

        }
        //game
        #region //SaveLoadManager
        //saves
        static void LoadGame()
        {
            try
            {
                Player loadedplayer = LoadPlayerData("Saves.json");
                Console.WriteLine("Loading...");
                Console.WriteLine("Loaded");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Error 001. No save file.");
                Console.WriteLine("Redirecting to Main menu...");
                GameMenu();
            }
        }
        static void SaveGame(Player gameProgress, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(gameProgress);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Game progress saved successfully.");
        }
        static Player LoadPlayerData(string filepath)
        {
            string jsonString = File.ReadAllText(filepath);
            Player loadedPlayer = JsonSerializer.Deserialize<Player>(jsonString);
            return loadedPlayer;
        }
        //saves
        #endregion
    }
}