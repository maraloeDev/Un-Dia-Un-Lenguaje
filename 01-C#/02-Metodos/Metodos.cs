namespace _02_Metodos
{
    internal class Metodos
    {
        static void Main(string[] args) {
            //mensajeEnPantalla();
            sumaDeNumeros(5,1);
        }
        
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el metodo");
        }

        static int sumaDeNumeros (int numero1, int numero2)
        {
            //Console.WriteLine($"La suma de los numeros es {(numero1 + numero2)}");
            return numero1 + numero2;
        }
    }
}