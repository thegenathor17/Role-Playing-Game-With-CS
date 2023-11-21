using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cs_gae
{
    public class Human
    {
        //variables
        public string Nombre { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int Vida { get; set; }
        public int Magia { get; set; }
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public bool estaVivo = true;

        //variables
        //constructores
        public Human(int ataque, int defensa, int vida, int magia, string nombre = "Human")
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Vida = vida;
            this.Magia = magia;
        }
        public Human(int ataque, int defensa, int vida, string nombre = "Human")
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Vida = vida;
        }
        public Human(string nombre = "Human")
        {
            this.Nombre = nombre;
        }
        //constructores
        //destructor
        ~Human()
        {
            Console.WriteLine($"{Nombre} ha muerto.");
        }
        //destructor
    }
}
