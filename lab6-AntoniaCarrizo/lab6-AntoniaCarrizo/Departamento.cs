using System;
namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Departamento : Division
    {

        public Departamento(string nombreDivision, Persona encargado)
        {
            this.NombreDivision = nombreDivision;
            this.Encargado = encargado;
        }
    }
}
