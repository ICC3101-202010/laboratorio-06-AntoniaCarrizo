using System;
namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Area : Division
    {
        public Area(string nombreDivision, Persona encargado)
        {
            this.NombreDivision = nombreDivision;
            this.Encargado = encargado;
        }
    }
}
