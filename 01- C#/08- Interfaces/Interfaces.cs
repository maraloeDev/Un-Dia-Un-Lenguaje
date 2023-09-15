namespace _08__Interfaces
{
    internal class Herencia //LA HERENCIA SE REPRESENTA CON LOS DOS PUNTOS  (" : ") (Un Caballo ('es' = :) un Mamifero 
    {
        static void Main(string[] args)
        {

            Caballo caballo = new Caballo("Caballo");

            Humano humano = new Humano("Eduardo");

            Gorila gorila = new Gorila("Gorila");

            caballo.getNombre();

            humano.getNombre();

            gorila.getNombre();

            // El principio de sustitución (Es siempre un...) consiste en sustituir un objeto de un tipo por otro diferente teniendo en cuenta la HERENCIA

            Mamiferos persona = new Humano("Paco");

            persona.pensar(); // No me deja por que persona no es de tipo humano, si no de Mamifero

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = caballo;
            almacenAnimales[1] = humano;
            almacenAnimales[2] = gorila;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }


        }
    }

    // IMPLEMENTAR INTERFAZ

    //CREAR BALLENA

    class Mamiferos
    {
        //Atributos
        private string nombreSerVivo;

        //Constructor
        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }

        //Metodos
        public void respirar() => Console.WriteLine("Soy capaz de respirar");

        public void cuidarCrias() => Console.WriteLine("Cuido mis crias hasta que se valgan por si solas");

        public void getNombre() => Console.WriteLine($"El nombre del ser vivo es {nombreSerVivo}");

        public virtual void pensar() => Console.WriteLine("Pensamiento basico instintivo"); //Virtual es que todas las subclases de la clase padre, tienen que tener un metodo pensar
    }

    class Caballo : Mamiferos
    {

        public Caballo(string nombreCaballo) : base(nombreCaballo) // Para heredar el constructor, se utiliza ( :base ())
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
        public override void pensar() => Console.WriteLine("Soy capaz de pensar ¿?");
    }
    class Gorila : Mamiferos
    {

        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar() => Console.WriteLine("Soy capaz de trepar");

        public override void pensar() => Console.WriteLine("Soy capaz de pensar de forma avanzada");
    }
}