using System;
using System.Collections.Generic;
namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Division
    {
        private string nombreDivision;
        private Persona encargado;

        public Division()
        {
        }

        public string NombreDivision { get => nombreDivision; set => nombreDivision = value; }
        public Persona Encargado { get => encargado; set => encargado = value; }
    }
}
