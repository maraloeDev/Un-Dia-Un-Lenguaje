namespace _05__POO
{
    internal class Clases_e_Instancias
    {

        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            Console.WriteLine(circulo.calculoArea(25));

            Circulo circulo2 = new Circulo();

            Console.WriteLine(circulo2.calculoArea(255));


            conversionEuroDolar conversionEuroDolar = new conversionEuroDolar();
            Console.WriteLine(conversionEuroDolar.convierte(50));
        }


        class Circulo
        {

            const double pi = 3.1416;
            public double calculoArea(int radio)
            {


                return double.Pi * Math.Pow(radio, 2);
            }
        }

        class conversionEuroDolar
        {
            const double euro = 1.25;

            public double convierte(int cantidad)
            {
                return cantidad * euro;
            }
        }
    }
}