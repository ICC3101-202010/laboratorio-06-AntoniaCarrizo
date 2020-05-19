using System;
using System.Collections.Generic;
namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Division
    {
        private List<Persona> personal = new List<Persona>();
        private string nombreDivision;
        private Persona encargado;

        public Division()
        {
        }

        public string NombreDivision { get => nombreDivision; set => nombreDivision = value; }
        public Persona Encargado { get => encargado; set => encargado = value; }
        public List<Persona> Personal { get => personal; set => personal = value; }
    }
}
