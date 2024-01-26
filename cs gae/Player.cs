using System;
namespace cs_gae
{
    internal class Player
    {
        #region variables
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
        #endregion
        #region constructores
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
        #endregion
        #region Metodos
        //metodos
        public void DisplayStats(string nombre, int habilidadConLaEspada, int habilidadConElArco, int defensa, int vidaMaxima, int magia, int nivel, int experiencia)
        {
            if (habilidadConElArco != 0)
            {
                Console.WriteLine($"The statistics of {nombre} are: \nBow Hability: {habilidadConElArco}\nDefense: {defensa}\nMax Healt: {vidaMaxima}\nMagic: {magia}\nLevel: {nivel}\nActual XP: {experiencia}");
            }
            else
            {
                Console.WriteLine($"The statistics of {nombre} are: \nSword Hability: {habilidadConLaEspada}\nDefense: {defensa}\nMax Healt: {vidaMaxima}\nMagic: {magia}\nLevel: {nivel}\nActual XP: {experiencia}");
            }
        }
        public void DisplayInventory()
        {
            for (int i = 0; i < Inventario.Length; i++)
            {
                for (int j = 0; j < Inventario.Length; j++)
                {
                    Console.WriteLine($"{Inventario[i, j]}");
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
        public void AjusteDeVida(int curacion)
        {
            Vida += curacion;
            if (Vida > VidaMaxima)
            {
                Vida = Vida - (VidaMaxima - Vida);
            }
        }
        public void Defend()
        {
            Console.WriteLine("The next turn you not going to receive damage :)");
        }
        //metodos
        #endregion
        #region destructor
        //destructor
        ~Player()
        {
            Console.WriteLine("Has muerto");
        }
        //destructor
        #endregion
    }
}