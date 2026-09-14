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
            get {return nombre;}
            set
            {
                 if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
                nombre=value;
            }
     }
     public short Id { get ; set ; }

     public int Vida 
     {
         get { return vida; }
         set
            {
                if (value >= 0)
            {
                vida = value;
            }
            }
     }
                      
     public int Ataque
    {
        get { return ataque; }
        set
        {
            if (value > 0)
            {
                ataque = value;
            }
        }
    }
    public int Defensa
    {
        get { return defensa; }
        set
        {
            if (value > 0)
            {
                defensa = value;
            }
        }
    }
     public int Mana
    {
        get { return mana; }
        set
        {
            if (value >= 0)
            {
                mana = value;
            }
        }
    }
     public Personaje (short id, string nombre, int vida, int ataque, int defensa, int mana)
        {
            Id = id ;
            Nombre = nombre ;
            Vida = vida ;
            Ataque = ataque ;
            Defensa = defensa ;
            Mana = mana ;
        }
        public bool EstaDerrotado()
    {
        return Vida <= 0;
    }
    public abstract void Atacar(Personaje objetivo);
    }
}   