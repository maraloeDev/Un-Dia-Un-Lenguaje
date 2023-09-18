namespace _08__Interfaces
{
    internal class Interfaces
    {
        //static void Main(string[] args)
        //{

        //    Caballo caballo = new Caballo("Caballo");

        //    ISaltoConPatas mamiferosTerrestres = caballo; // Para indicarle el numero de patas, aplicamos el principio de sustitucion (es un...)

        //    Humano humano = new Humano("Eduardo");

        //    Gorila gorila = new Gorila("Gorila");

        //    Ballena ballena = new Ballena("Ballena");

        //    caballo.getNombre();

        //    humano.getNombre();

        //    gorila.getNombre();

        //    ballena.getNombre();

        //    Mamiferos persona = new Humano("Paco");

        //    persona.pensar();

        //    Mamiferos[] almacenAnimales = new Mamiferos[3];

        //    almacenAnimales[0] = caballo;
        //    almacenAnimales[1] = humano;
        //    almacenAnimales[2] = gorila;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        almacenAnimales[i].pensar();
        //    }

        //    Console.WriteLine("Numero de patas utilizadas en el salto de  de  caballo:  " + mamiferosTerrestres.numeroPatas());


        //}
    }

    // Una interfaz es un conjunto de regras que tienen que cumplir las clases, se pueden implementar tantas interfaces como se necesiten

    interface IMamiferosTerrestres
    {

        public int numeroPatas();

    }

    interface IAnimlesyDeportes
    {

        public bool esOlimpico();
        public string tipoDeporte();

    }

    interface ISaltar
    {
        public string saltar();
    }

    interface ISaltoConPatas
    {

        public int numeroPatas();

    }



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

        public virtual void pensar() => Console.WriteLine("Pensamiento basico instintivo");
    }


    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimlesyDeportes, ISaltar, ISaltoConPatas

        // Si dos interfaces tienen el mismo metodo, se llama a la interfaz dentro del metodo
    {

        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar() => Console.WriteLine("Soy capaz de galopar");


        public override void pensar() => Console.WriteLine("Soy capaz de pensar poco");

        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;

        }
        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }

        public string tipoDeporte()
        {
            return "El tipo de deporte del caballo es la Carrera de caballos";
        }

        public bool esOlimpico()
        {
            return true;
        }

        public string saltar()
        {
            return "Se Saltar";
        }
    }
    class Humano : Mamiferos, IMamiferosTerrestres, IAnimlesyDeportes
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }

        public int numeroPatas()
        {
            return 2;
        }

        public override void pensar() => Console.WriteLine("Soy capaz de pensar ¿?");

        public string tipoDeporte()
        {
            return "El deporte que practico es el Golf";
        }

        public bool esOlimpico()
        {
            return false;
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
    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }


    }
}