using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.persistencia.Entidad
{
    public class Guerrero : Personaje
    {
        public Guerrero(
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
      ValidarPuedeAtacar();

    int dañoR = Ataque - objetivo.Defensa;

    if (dañoR < 1)
    {
        dañoR = 1;
    }

    objetivo.RecibirDaño(dañoR);

    Console.WriteLine(
        Nombre + " ataca con su espada.");

    Console.WriteLine(
        "Daño realizado: " + dañoR);

    Console.WriteLine(
        "Vida restante de " + objetivo.Nombre +
        ": " + objetivo.Vida);
    }

    }
    
}