using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_gae;
namespace cs_gae
{
    internal class Orc
    {
        //variables
        private string nombre = "Orc";
        private int ataque = 10;
        private int defensa = 5;
        private int vida = 35;
        private int magia = 0;
        //variables
        //constructores
        public Orc(int ataque, int defensa, int vida, int magia, string nombre = "Orc")
        {
            this.nombre = nombre;
            this.ataque = ataque;
            this.defensa = defensa;
            this.vida = vida;
            this.magia = magia;
        }
        public Orc(int ataque, int defensa, int vida)
        {
            this.ataque = ataque;
            this.defensa = defensa;
            this.vida = vida;
        }
        public Orc(int ataque, int defensa, int vida, string nombre = "Orc")
        {
            this.nombre = nombre;
            this.ataque = ataque;
            this.defensa = defensa;
            this.vida = vida;
        }
        public Orc(string nombre = "Orc")
        {
            this.nombre = nombre;
        }
        //constructores
        //Metodos
        void AtacarJugador(int defensaDelJugador, int vidaDelJugador)
        {
            Console.WriteLine($"{nombre} attacked you and dealt {ataque - defensaDelJugador} points of damage. ");
            Console.WriteLine($"Now you have {vidaDelJugador - (ataque - defensaDelJugador)} points of healt.");
        }
        //Metodos
        //Destructor
        ~Orc()
        {
            Console.WriteLine($"{nombre} died.");
        }
    }
}