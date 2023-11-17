using System;
namespace cs_gae
{
    internal class Player
    {
        //variables
        public string nombre = "Player";
        public int ataque = 10;
        public int defensa = 10;
        public int vida = 100;
        public int magia = 0;
        public int nivel = 1;
        public int experiencia = 0;
        //variables
        //constructores
        public Player(string nombre, int ataque, int defensa, int vida, int magia, int nivel, int experiencia)
        {
            this.nombre = nombre;
            this.ataque = ataque;
            this.defensa = defensa;
            this.vida = vida;
            this.magia = magia;
            this.nivel = nivel;
            this.experiencia = experiencia;
        }
        //constructores
        //metodos
        //metodos
    }
}