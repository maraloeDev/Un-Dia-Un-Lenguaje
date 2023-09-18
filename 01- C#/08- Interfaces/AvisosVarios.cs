namespace _08__Interfaces
{
    class AvisosvARIOS : IAvisos
    {
        
        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el dia {2} ", remitente,mensaje , fecha);
        }

        string IAvisos.getFecha()
        {
            throw new NotImplementedException();
        }

        // Atributos
        private string remitente;
        private string mensaje;
        private string fecha;

        public AvisosvARIOS()
        {
            remitente = "DGT";
            mensaje = "Hola";
            fecha = "";
        }
        public AvisosvARIOS(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

    }
}
