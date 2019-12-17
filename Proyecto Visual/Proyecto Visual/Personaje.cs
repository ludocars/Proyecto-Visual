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
        protected String STATUS;
        //protected String Item;

        //constructor 
        public Personaje(int _HP, int _ATK, String _STATUS){
            
            HP = _HP;
            ATK = _ATK;
            STATUS = _STATUS;
        }

        //metodos
        public void Atacar(int ENEMIGO = 10){
            //aqui tomamos nuestro atk y disminuimos el hp del enemigo
            int ataque = ENEMIGO - ATK;
            Console.WriteLine("La vida del Enemigo es: " + ataque);
        }
        public void Defender() { }
        public void Status() {
            //aqui deseo mostrar los valores del personaje al momento
            Console.WriteLine("Tu vida es : " + HP);
            Console.WriteLine("Tu ataque es de : " + ATK);
            Console.WriteLine("Tu vida estado actual es : " + STATUS);
        }
    }
}
