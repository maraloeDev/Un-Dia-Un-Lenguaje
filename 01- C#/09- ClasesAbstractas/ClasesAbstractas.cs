namespace _09__ClasesAbstractas
{
    internal class ClasesAbstractas // Una clase abstracta es aquella que tiene solo tiene la declaracion, no esta desarrollado
    {

        static void Main(string[] args)
        {

        //    Caballo caballo = new Caballo("Caballo");

        //    Humano humano = new Humano("Eduardo");

        //    Gorila gorila = new Gorila("Gorila");

        //    caballo.getNombre();

        //    humano.getNombre();

        //    gorila.getNombre();

        //    // El principio de sustitución (Es siempre un...) consiste en sustituir un objeto de un tipo por otro diferente teniendo en cuenta la HERENCIA

        //    Mamiferos persona = new Humano("Paco");

        //    persona.pensar(); // No me deja por que persona no es de tipo humano, si no de Mamifero

        //    Mamiferos[] almacenAnimales = new Mamiferos[3];

        //    almacenAnimales[0] = caballo;
        //    almacenAnimales[1] = humano;
        //    almacenAnimales[2] = gorila;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        almacenAnimales[i].pensar();
        //    }


        //}

            Lagartija lagartija = new Lagartija ("Lagartija");
            lagartija.getNombre();

            Humano humano = new Humano("Eduardo");

            humano.getNombre();
        }

    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();
    }

    class Lagartija : Animales
    {

        private String nombreReptil;

        public Lagartija(String nombre)
        {
            nombreReptil = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine($"El nombre del reptil es {nombreReptil}");
        }
    }
    class Mamiferos : Animales
    {
        //Atributos
        private string nombreSerVivo;

        //Constructor
        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }

        //Metodos

        public void cuidarCrias() => Console.WriteLine("Cuido mis crias hasta que se valgan por si solas");

        public virtual void pensar() => Console.WriteLine("Pensamiento basico instintivo");

        public void respirar()
        {
                Console.WriteLine("Soy capaz de respirar");
            }

        public override void getNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es {nombreSerVivo}");
        }
    }

    class Caballo : Mamiferos
    {

        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar() => Console.WriteLine("Soy capaz de galopar");

        public override void pensar() => Console.WriteLine("Soy capaz de pensar poco");
    }
    class Humano : Mamiferos
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }

            //Con sealed se impide heredad de esta clase
             public sealed override void pensar() => Console.WriteLine("Soy capaz de pensar ¿?");
    }

        class Adolenceste : Humano
        {
            public Adolenceste (string nombreAdolenceste) : base(nombreAdolenceste)
            {


            }

            public override void pensar()
            {
                Console.WriteLine("Las hormonas me impiden pensar");
            }
        }
     class Gorila : Mamiferos 
    {

        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar() => Console.WriteLine("Soy capaz de trepar");

        public override void pensar() => Console.WriteLine("Soy capaz de pensar de forma avanzada");
    }

        class Chimpance : Gorila
        {

            public Chimpance (String nombre) : base(nombre)
            {

            }

        }
}
}