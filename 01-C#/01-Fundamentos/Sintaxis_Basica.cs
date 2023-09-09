namespace _01_Fundamentos
{
    internal class Sintaxis_Basica
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al repositorio un día, un lenguaje. Hola C#!!!");

            // Variables

            int edad;
            string nombre;

            edad = 23;
            Console.WriteLine(edad);

            //Operadores aritmeticos
            Console.WriteLine(7 * 5);
            Console.WriteLine(5.0 / 2.0);
            Console.WriteLine(9 % 4);

            //Concatenacion
            int edadConcat = 23;
            edadConcat += 1;

            Console.WriteLine("Tienes una edad de " + edadConcat + " años");

             Console.WriteLine($"Tienes una edad de {edadConcat} años"); //Se puede utilizar una interpolacion de strings ( en vez de poner +, se pone $ y {tuVariable}

            //Casteos
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27; //Lo que hace esto es que a todas las variables, su valor el 27

            edadPersona2 = 21;

            var edadPersona = 23; //Se utiliza esto pasa ASIGNAR EN TIEMPO DE EJECUCION el tipo (int), no se le puede dar otro tipo de valor
            Console.WriteLine(edadPersona);

            //Conversion Explicita (casting)
            double temperatura = 34.9;
            int temperaturaMadrid;

            temperaturaMadrid = (int)temperatura;
            Console.WriteLine(temperaturaMadrid);


            //Conversion Implicita Se hace entre tipo compatibles
            int habitantesCiudad = 1000000;
            long habitantesCiudad2023 = habitantesCiudad;
            Console.WriteLine(habitantesCiudad2023);

            float pesoMaterial = 5.78F;
            double pesoMaterialPrec = pesoMaterial;
            Console.WriteLine(pesoMaterialPrec);

            //Lecturas desde teclado
            Console.WriteLine("Introduce un numero");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("El numero introducido es " + numero);

            const int VALOR = 10; //El valor de una constante, nunca cambia

            const int VALOR2 = 11; //El valor de una constante, nunca cambia

            //Para mostrar la constante, se utiliza una coma, y entre llaves el numero de la constante

            Console.WriteLine("El valor de la constante 1 es {0} y de la constante 2 es {1}", VALOR, VALOR2);

            const double pi = 3.1416;

            Console.WriteLine("Introduce la medida del radio:");
            double radio = int.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2) * pi;

            Console.WriteLine($"El area del circulo es {area}");
        }
    }
}