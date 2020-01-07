using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Visual
{//CLASE PADRE
    public class Personaje
    {
        //atributos
        protected int HP;
        protected int ATK;
        protected string STATUS;

        //metodos
        public void Atacar(int ENEMIGO = 10){
            //aqui tomamos nuestro atk y disminuimos el hp del enemigo
            int ataque = ENEMIGO - ATK;
            Console.WriteLine("La vida del Enemigo es: \n" + ataque);
        }
        public void Defender() {}
        public void Status() {
            //aqui deseo mostrar los valores del personaje al momento
            Console.WriteLine("Tu vida es : " + HP);
            Console.WriteLine("Tu ataque es de : " + ATK);
            Console.WriteLine("Tu vida estado actual es : " + STATUS);
        }

        //constructor 
        public Personaje(int VALOR_HP, int VALOR_ATK, string VALOR_STATUS){
            HP = VALOR_HP;
            ATK = VALOR_ATK;
            STATUS = VALOR_STATUS;
        }

        public Personaje() { }
    }
}
