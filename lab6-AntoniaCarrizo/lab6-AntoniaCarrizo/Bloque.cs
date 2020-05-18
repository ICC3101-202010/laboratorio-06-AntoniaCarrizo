using System;
using System.Collections.Generic;

namespace lab6AntoniaCarrizo
{
    public class Bloque : Division
    {
        private List<Persona> personal = new List<Persona>();

        public Bloque(string nombreDivison, Persona encargado, List<Persona> personal )
        {
            this.NombreDivision = nombreDivison;
            this.Encargado = encargado;
            this.Personal = personal;
        }

        public List<Persona> Personal { get => personal; set => personal = value; }
    }
}
