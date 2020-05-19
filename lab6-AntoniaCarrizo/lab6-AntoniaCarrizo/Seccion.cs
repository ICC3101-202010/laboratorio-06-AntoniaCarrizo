using System;
namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Seccion : Division
    {
        public Seccion(string nombreDivision, Persona encargado)
        {
            this.NombreDivision = nombreDivision;
            this.Encargado = encargado;
        }

        
    }
}
