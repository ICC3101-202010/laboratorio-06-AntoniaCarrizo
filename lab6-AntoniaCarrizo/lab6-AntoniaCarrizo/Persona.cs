using System;
namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string rut;
        private string cargo;

        public Persona(string nombre, string apellido, string rut, string cargo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Rut = rut;
            this.Cargo = cargo;
        }
        public Persona()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        public Persona CrearPersona(string cargo)
        {
            Console.WriteLine("1) Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("2) Ingrese apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("3) Ingrese rut: ");
            string rut = Console.ReadLine();
            Persona persona = new Persona(nombre, apellido, rut, cargo);
            return persona;
        }
    }
}
