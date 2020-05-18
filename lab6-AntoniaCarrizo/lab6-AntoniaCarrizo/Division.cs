using System;
namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Division
    {
        private string nombreDivision;

        public Division()
        {
        }

        public string NombreDivision { get => nombreDivision; set => nombreDivision = value; }
    }
}
