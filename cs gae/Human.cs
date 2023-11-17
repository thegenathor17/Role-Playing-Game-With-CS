using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cs_gae
{
    internal class Human
    {
        //variables
        private string nombre = "Human";
        private int ataque = 10;
        private int defensa = 5;
        private int vida = 35;
        private int magia = 0;
        //variables
        //constructores
        public Human(int ataque, int defensa, int vida, int magia, string nombre = "Human")
        {
            this.nombre = nombre;
            this.ataque = ataque;
            this.defensa = defensa;
            this.vida = vida;
            this.magia = magia;
        }
        public Human(int ataque, int defensa, int vida, string nombre = "Human")
        {
            this.nombre = nombre;
            this.ataque = ataque;
            this.defensa = defensa;
            this.vida = vida;
        }
        public Human(string nombre = "Human")
        {
            this.nombre = nombre;
        }
        //constructores
    }
}
