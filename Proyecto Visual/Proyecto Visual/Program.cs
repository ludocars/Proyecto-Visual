using System;

namespace Proyecto_Visual
{
    class Program
    {
        static void Main(string[] args)
        {
            Paladin NuevoPala = new Paladin(5,2,"vivo");
            NuevoPala.Atacar();
            NuevoPala.Status();

        }
    }
}
