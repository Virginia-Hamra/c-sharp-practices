using System;

namespace Clase_inet
{
    class Persona
    {
        public int edad;
        public string nombre;
        public string apellido;
        private string domicilio;

        //primer constructor => por default
        public Persona()
        {
            edad = 25;
            nombre = "Romina";
            apellido = "Perez";
            domicilio = "Lavalle 648";
           
        }

        public Persona(int edad, string nombre, string apellido, string domicilio)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
        }
        //metodo para imprimir
        public void Imprimir()
        {
            Console.WriteLine("Edad: " + this.edad + Environment.NewLine + "El nombre es: " + this.nombre + Environment.NewLine + "El apellido: " + this.apellido + Environment.NewLine + "Su domicilio: " + this.domicilio);
        }

        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Imprimir();
            Persona persona2 = new Persona(24, "Valeria", "Sosa", "Jose Altamira 222");
            persona2.Imprimir();
        }
    }
}
