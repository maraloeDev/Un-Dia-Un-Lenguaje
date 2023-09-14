namespace _06__Arrays
{
    internal class Arrays
    {
        static void Main(string[] args)
        {

            // Array implicito

            // var datos = new[] {"Juan", "Diaz",15};

            var valores = new[] { 1, 2, 3, 4 };

            //Arrays de objetos

            Empleados Ana = new Empleados("Ana", 20);

            Empleados[] empleados = new Empleados[2];

            empleados[0] = new Empleados("Ana", 21);
            empleados[1] = Ana;

            // Array de clases anonimas

            var personas = new[]
            {
                new {Nombre = "Pablo", Edad=23},
            new { Nombre = "Mario", Edad = 28 },
            new {Nombre = "Paco", Edad=45}
        };

            //Recorrer Array
            //for (int i = 0; i <= personas.Length; i++)
            //{
            //    Console.WriteLine(personas[i]);
            //}

            foreach (double variable in valores)
            {
                Console.WriteLine(variable);
            }

        }
    }

    class Empleados
    {
        string nombre;
        int edad;

        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}