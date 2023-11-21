using System;
namespace cs_gae
{
    internal class Player
    {
        //variables
        public string Nombre { get; set; }
        public int HabilidadConElArco { get; set; }
        public int HabilidadConLaEspada { get; set; }
        public int Defensa { get; set; }
        public int Vida { get; set; }
        public int Magia { get; set; }
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public bool estaVivo;
        public int[,] Inventario = new int[7,7];
        public int VidaMaxima { get; set; }
        //variables
        //constructores
        public Player(string nombre, int defensa, int vida, int vidaMaxima, int magia, int nivel, int experiencia)
        {
            this.Nombre = nombre;
            this.Defensa = defensa;
            this.Vida = vida;
            this.VidaMaxima = vidaMaxima;
            this.Magia = magia;
            this.Nivel = nivel;
            this.Experiencia = experiencia;
        }
        //constructores
        //metodos
        public static void DisplayStats(string nombre, int ataque, int defensa, int vidaMaxima, int magia, int nivel)
        {
            Console.WriteLine($"Estadisticas de {nombre} son: \nAtaque: {ataque}\nDefensa: {defensa}\nVida Maxima {vidaMaxima}\nMagia: {magia}\nNivel: {nivel}");
        }
        public void DisplayInventory()
        {
            for (int i = 0; i > Inventario.Length; i++)
            {
                for(int j = 0; j < Inventario.Length; j++)
                {
                    Console.WriteLine($"{Inventario[i,j]}");
                }
            }
        }
        public void Attack(int saludDelEnemigo, int defensaDelEnemigo, string enemigo, bool arco)
        {
            if (arco == false)
            {
                Console.WriteLine($"{Nombre} attacked {enemigo} and dealt {HabilidadConLaEspada - defensaDelEnemigo} points of damage. ");
                Console.WriteLine($"Now you have {saludDelEnemigo - (-defensaDelEnemigo)} points of healt.");
            }
            else
            {
                Console.WriteLine($"{Nombre} attacked {enemigo} and dealt {HabilidadConElArco - defensaDelEnemigo} points of damage. ");
                Console.WriteLine($"Now you have {saludDelEnemigo - (-defensaDelEnemigo)} points of healt.");
            }
        }
        //metodos
        //destructor
        ~Player()
        {
            Console.WriteLine("Has muerto");
            estaVivo = false;
        }
        //destructor
    }
}