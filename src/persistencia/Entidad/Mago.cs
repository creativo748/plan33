using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.persistencia.Entidad
{
    public class Mago : Personaje
    {
        public Mago(
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
        int daño = Ataque + 10;

        objetivo.Vida = objetivo.Vida - daño;

        Console.WriteLine(
            Nombre + " ataca con magia y hace "
            + daño + " de daño");
    }
    }
}