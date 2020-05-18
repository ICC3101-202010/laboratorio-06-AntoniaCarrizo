using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace lab6AntoniaCarrizo
{
    
    class MainClass
    {
       
        public static void Main(string[] args)
        {
            List<Empresa> listaEmpresas = new List<Empresa>();

            int romper = 0;
            while (romper<1)
            {
                Console.WriteLine("Desea utilizar un archivo para cargar la informacion? \n Seleccione una de las siguientes opciones: ");
                Console.WriteLine("1)No deseo utilizar un archivo \n2)Si, deseo utilizar un archivo \n3)Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre de la empresa: ");
                        string nombreEmpresa = Console.ReadLine();
                        Console.WriteLine("Ingrese el rut de la empresa: ");
                        string rut = Console.ReadLine();

                        Empresa empresa = new Empresa(nombreEmpresa, rut);
                        listaEmpresas.Add(empresa);
                        GuardarEmpresas(listaEmpresas);
                        Console.WriteLine("Datos cargados exitosamente");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case "2":
                        try
                        {
                            listaEmpresas = CargarEmpresa();
                            Console.WriteLine("Datos cargados exitosamente\n");
                            Thread.Sleep(2000);
                            Console.Clear();
                            foreach (Empresa emp in listaEmpresas)
                            {
                                Console.WriteLine("La informacion de la empresa es: ");
                                Console.WriteLine("Nombre: " + emp.NombreEmpresa + "\nRut: " + emp.RutEmpresa +"\n");
                            }
                        }

                        catch
                        {
                            Console.WriteLine("ERROR en la apertura del archivo!! \nIngrese los datos de la empresa:");
                            Console.WriteLine("1) Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("2) Rut: ");
                            string run = Console.ReadLine();

                            Empresa empresa1 = new Empresa(nombre, run);
                            listaEmpresas.Add(empresa1);
                            GuardarEmpresas(listaEmpresas);
                            Console.WriteLine("Datos cargados exitosamente");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        break;
                    case "3":
                        romper++;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida, por favor vuelva a ingresarla");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;

                }

            }
               
        }
        static private void GuardarEmpresas(List<Empresa> todasLasEmpresas)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, todasLasEmpresas);
            stream.Close();
        }
        static private List<Empresa> CargarEmpresa()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Empresa> todasLasEmpresas = (List<Empresa>)formatter.Deserialize(stream);
            stream.Close();
            return todasLasEmpresas;
        }
    }
}
