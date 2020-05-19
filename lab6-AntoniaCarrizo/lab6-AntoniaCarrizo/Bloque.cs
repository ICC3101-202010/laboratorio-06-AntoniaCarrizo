using System;
using System.Collections.Generic;

namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Bloque : Division
    {
        private List<Persona> personal = new List<Persona>();

        public Bloque(string nombreDivison, Persona encargado)
        {
            this.NombreDivision = nombreDivison;
            this.Encargado = encargado;
        }

        
    }
}
