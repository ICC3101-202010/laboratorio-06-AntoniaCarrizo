using System;
namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Area : Division
    {
        public Area(string nombreDivision)
        {
            this.NombreDivision = nombreDivision;
        }
    }
}
