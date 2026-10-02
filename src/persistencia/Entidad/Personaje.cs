using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace src.persistencia.Entidad
{
 
   public abstract class Personaje
    {
        private int vida;
        private int ataque;
        private int defensa;
        private int mana;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "El nombre no puede estar vacío.");
                }

                nombre = value;
            }
        }

        public int Id { get; set; }

        public int Vida
        {
            get { return vida; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "La vida no puede ser negativa.");
                }

                vida = value;
            }
        }

        public int Ataque
        {
            get { return ataque; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "El ataque debe ser mayor que cero.");
                }

                ataque = value;
            }
        }

        public int Defensa
        {
            get { return defensa; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "La defensa debe ser mayor que cero.");
                }

                defensa = value;
            }
        }

        public int Mana
        {
            get { return mana; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "El mana no puede ser negativo.");
                }

                mana = value;
            }
        }

        public Personaje(
            int id,
            string nombre,
            int vida,
            int ataque,
            int defensa,
            int mana)
        {
            Id = id;
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
            Defensa = defensa;
            Mana = mana;
        }

        public bool EstaDerrotado()
        {
            return Vida <= 0;
        }

        public void ValidarPuedeAtacar()
        {
           if (EstaDerrotado())
              {
                  throw new InvalidOperationException("El personaje está derrotado y no puede atacar.");
              }
        }
        public abstract void Atacar(Personaje objetivo);
        
        public void RecibirDaño(int dañoR)
        {
            if (dañoR < 0)
               {
                 throw new ArgumentException("El daño no puede ser negativo.");
               }

                Vida = Vida - dañoR;
        }
    }
    
}   