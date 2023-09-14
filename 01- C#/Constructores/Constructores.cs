namespace Constructores
{
    internal class Constructores
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche();
            Console.WriteLine(coche.datosCoche());
            Console.WriteLine("---------------------------");
            Coche coche1 = new Coche(25.02, 80.03);
            coche1.setExtras(true, "piel");
            Console.WriteLine(coche1.datosCoche());
        }
    }

    // PARTIAL sirve para dividir una clase en trozos
    partial class Coche
    {

        private int ruedas;
        private double largo;
        private double ancho;
        private string tapiceria;
        private bool climatizador;


        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }
    }
    //----------------------------------------------------------------------
    partial class Coche { 
        public Coche(double largoCoche, double anchoCoche)
        {

            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;

        }



        public string datosCoche()
        {
            return "Informacion del coche: " +
                "\n" +
                "Ruedas: " + ruedas + " " +
                "\n" +
                "Ancho: " + ancho + " " +
                "\n" +
                "Largo: " + largo + " " +
                "\n" +
                "Climatizador: " + climatizador + " " +
                "\n" +
                "Tapiceria: " + tapiceria;
        }

        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

    }
}