using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class MondoAnimale
    {
        public abstract class Animale
        {
            public abstract void Verso();
            public abstract void Eat();
            public static void Sleep()
            {
                Console.WriteLine("ZZZZZ");
            }
        }


        public class Cane : Animale
        {
            public override void Verso()
            {
                Console.WriteLine("Bau");
            }
            public override void Eat()
            {
                Console.WriteLine("Cane è un carnivoro");
            }
        }

        public class Passerotto : Animale
        {
            public override void Verso()
            {
                Console.WriteLine("Piu Piu");
            }
            public override void Eat()
            {
                Console.WriteLine("Mangia quello che trova");
            }
        }

        public class Aquila : Animale
        {
            public override void Verso()
            {
                Console.WriteLine("Boh");
            }
            public override void Eat()
            {
                Console.WriteLine("Conigli");
            }
        }
        public class Delfino : Animale
        {
            public override void Verso()
            {
                Console.WriteLine("EEEEEh");
            }
            public override void Eat()
            {
                Console.WriteLine("Atrli pesci");
            }
         
        }
        public interface IVola
        {
            void Vola();
        }
        public interface INuota
        {
            void Nuota();
        }

        public class Uccello :  Animale,IVola  // pazzesco! posso concatenare le astrazioni
        { 
            public override void Verso()
            {
                Console.WriteLine("EEEEEh");
            }
            public override void Eat()
            {
                Console.WriteLine("Atrli pesci");
            }
            public void Vola()
            {
                Console.WriteLine("Sto Volando");
            }
       
        }
        public class Pesce : Animale,INuota
        {
            public override void Verso()
            {
                Console.WriteLine("non penso faccia versi");
            }
            public override void Eat()
            {
                Console.WriteLine("Altri pesci");
            }
            public void Nuota()
            {
                Console.WriteLine("Sto nuotando");
            }
        }

    }
}
