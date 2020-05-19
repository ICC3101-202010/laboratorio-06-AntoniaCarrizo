using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

/*
 * En el enunciado no se pide que se cree un area, por lo tanto esta clase no se usa,
 * si quisiera usarse solo habria que poner en el metodo Crearempresa:
 *
 * Console.WriteLine("Area: ");
            Console.WriteLine("Ingrese los datos del encargado del Area: ");
            Persona encargadoAr = per.CrearPersona("Encargado Area");
            Area area = new Area("area", encargadoAr);
            empresa.Divisiones.Add(area);
            Console.Clear();
*/

namespace lab6AntoniaCarrizo
{

    class MainClass
    {

        public static void Main(string[] args)
        {
            List<Empresa> listaEmpresa = new List<Empresa>();
            int num = 0;
            Persona per = new Persona();


            int romper = 0;
            while (romper < 1)
            {
                Console.WriteLine("Desea utilizar un archivo para cargar la informacion? \nSeleccione una de las siguientes opciones: ");
                Console.WriteLine("1)No deseo utilizar un archivo \n2)Si, deseo utilizar un archivo \n3)Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":

                        if (num == 0)
                        {
                            CrearEmpresa(per,listaEmpresa);
                            

                        }
                        else
                        {

                            while (true)
                            {
                                Console.WriteLine("Ya ha agregado una empresa. Desea reemplazarla por una nueva? (considere que la anterior sera eliminada)");
                                Console.WriteLine("1)Reemplazar por una nueva \n2)No reemplazar");
                                string op = Console.ReadLine();

                                if (op == "1")
                                {
                                    listaEmpresa.RemoveAt(0);
                                    CrearEmpresa(per, listaEmpresa);
                                    Console.WriteLine("Datos cargados exitosamente");

                                    break;

                                }
                                else if (op == "2")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Opcion no valida, por favor vuelva a ingresarla ");
                                }
                            }


                        }
                        GuardarEmpresas(listaEmpresa);
                        
                        Thread.Sleep(2000);
                        Console.Clear();
                        num++;
                        break;

                    case "2":
                        try
                        {
                            listaEmpresa = CargarEmpresa();
                            Console.WriteLine("Datos cargados exitosamente\n");
                            Thread.Sleep(2000);
                            Console.Clear();

                            Console.WriteLine("La informacion de la empresa es: ");
                            Console.WriteLine("Nombre: " + listaEmpresa[0].NombreEmpresa + "\nRut: " + listaEmpresa[0].RutEmpresa + "\n");

                            Console.WriteLine("La informacion de sus divisiones es: ");
                            int i = 0;
                            foreach (Division division in listaEmpresa[0].Divisiones)
                            {
                                Console.WriteLine(" "+i+") "+ division.NombreDivision);
                                Console.WriteLine("     * Encargado: ");
                                Console.WriteLine("     - Nombre: " + division.Encargado.Nombre);
                                Console.WriteLine("     - Apellido: " + division.Encargado.Apellido);
                                Console.WriteLine("     - Rut: " + division.Encargado.Rut);

                                if (division.NombreDivision.ToLower().Contains("bloque"))
                                {
                                    Console.WriteLine("\n       *Personal:");
                                    foreach (Persona persona in division.Personal)
                                    {
                                        Console.WriteLine("     - Nombre: " + persona.Nombre);
                                        Console.WriteLine("     - Apellido: " + persona.Apellido);
                                        Console.WriteLine("     - Rut: " + persona.Rut);
                                        Console.WriteLine("     - Cargo: " + persona.Cargo);
                                        Console.WriteLine("\n");
                                    }
                                    
                                }
                                Console.WriteLine("\n");
                                i++;
                                num++;
                                Thread.Sleep(2000);
                            }


                            
                        }

                        catch
                        {
                            Console.WriteLine("ERROR en la apertura del archivo!! \nIngrese los datos de la empresa:");
                            CrearEmpresa(per, listaEmpresa);
                            GuardarEmpresas(listaEmpresa);
                            Console.WriteLine("Datos cargados exitosamente");
                            Thread.Sleep(2000);
                            Console.Clear();
                            num++;
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

        static public void CrearEmpresa(Persona per, List<Empresa> listaEmpresa)
        {
            //Crear Empresa
            Console.WriteLine("Ingrese el nombre de la empresa: ");
            string nombreEmpresa = Console.ReadLine();
            Console.WriteLine("Ingrese el rut de la empresa: ");
            string rut = Console.ReadLine();
            Empresa empresa = new Empresa(nombreEmpresa, rut);
            Console.Clear();

            //Crear Departamento
            Console.WriteLine("Departamento: ");
            Console.WriteLine("Ingrese los datos del encargado del departamento: ");
            Persona encargadoDep = per.CrearPersona("Encargado departamento");
            Departamento departamento = new Departamento("Departamento", encargadoDep);
            empresa.Divisiones.Add(departamento);
            Console.Clear();

            //Crear Seccion
            Console.WriteLine("Seccion: ");
            Console.WriteLine("Ingrese los datos del encargado de la seccion: ");
            Persona encargadoSecc = per.CrearPersona("Encargado seccion");
            Seccion seccion = new Seccion("Seccion", encargadoSecc);
            empresa.Divisiones.Add(seccion);
            Console.Clear();

            //Crear Bloque 1
            Console.WriteLine("Bloque 1 : ");
            Console.WriteLine("Ingrese los datos del encargado del bloque 1: ");
            Persona encargadoBlock = per.CrearPersona("Encargado bloque");
            Bloque bloque1 = new Bloque("Bloque 1", encargadoBlock);

            Console.WriteLine("Ingrese los datos del personal 1 del bloque 1: \n0) Ingrese el cargo del personal 1");
            string cargo1 = Console.ReadLine();
            Persona personal1 = per.CrearPersona(cargo1);
            bloque1.Personal.Add(personal1);

            Console.WriteLine("Ingrese los datos del personal 2 del bloque 1: \n0) Ingrese el cargo del personal 2");
            string cargo2 = Console.ReadLine();
            Persona personal2 = per.CrearPersona(cargo2);
            bloque1.Personal.Add(personal2);

            empresa.Divisiones.Add(bloque1);
            Console.Clear();

            //Crear Bloque 2
            Console.WriteLine("Bloque 2 : ");
            Console.WriteLine("Ingrese los datos del encargado del bloque 2: ");
            Persona encargadoBlock2 = per.CrearPersona("Encargado bloque");
            Bloque bloque2 = new Bloque("Bloque 2", encargadoBlock2);

            Console.WriteLine("Ingrese los datos del personal 1 del bloque 2: \n0) Ingrese el cargo del personal 1");
            string cargo3 = Console.ReadLine();
            Persona personal3 = per.CrearPersona(cargo3);
            bloque2.Personal.Add(personal3);

            Console.WriteLine("Ingrese los datos del personal 2 del bloque 2: \n0) Ingrese el cargo del personal 2");
            string cargo4 = Console.ReadLine();
            Persona personal4 = per.CrearPersona(cargo4);
            bloque2.Personal.Add(personal4);

            empresa.Divisiones.Add(bloque2);
            Console.Clear();


            listaEmpresa.Add(empresa);
            
        }
        
       

    }
}
