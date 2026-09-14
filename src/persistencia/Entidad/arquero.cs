using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.persistencia.Entidad
{
    public class arquero : Personaje
    {
         public Arquero(
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
        int daño = Ataque + 5;

        objetivo.Vida = objetivo.Vida - daño;

        Console.WriteLine(
            Nombre + " dispara una flecha y hace "
            + daño + " de daño");
    }
    }
}