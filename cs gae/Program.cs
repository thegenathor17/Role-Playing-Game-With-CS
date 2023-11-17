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
                saveLoadManager(args);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Loading...");
                game(args);
            }
            else
            {
                Console.WriteLine("What?");
            }
        }
        //game menu
        //game
        static void game(string[] args)
        {
            Console.WriteLine("Deep within this dungeon, a legendary hero has been captured by orcs.");
            Console.WriteLine("A group of brave adventurers has arrived to free him and face the orcish threat.");
            Console.WriteLine("The battle in the dungeon is about to begin!");
            Console.WriteLine("The legendary hero needs a name, what is it?");
            Player jugador = new Player(Console.ReadLine(), 10, 10, 100, 0, 1, 0);
            Console.WriteLine($"{jugador.nombre}? Good name");

        }
        //game
        //saves
        static void saveLoadManager(string[] args)
        {
            
        }
        //saves
    }
}