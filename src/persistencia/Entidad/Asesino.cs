using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.persistencia.Entidad
{
    public class Asesino : Personaje
    {
         public Asesino(
        int id,
        string nombre,
        int vida,
        int ataque,
        int defensa,
        int mana)
        : base(id, nombre, vida, ataque, defensa, mana)
    {
    }

    public override void Atacar(Personaje objetivo)
    {
        int daño = Ataque + 15;

        objetivo.Vida = objetivo.Vida - daño;

        Console.WriteLine(
            Nombre + " ataca con su daga y hace "
            + daño + " de daño");
    }   
    }
}