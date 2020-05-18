using System;
namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Departamento : Division
    {

        public Departamento(string nombreDivision)
        {
            this.NombreDivision = nombreDivision;
        }
    }
}
