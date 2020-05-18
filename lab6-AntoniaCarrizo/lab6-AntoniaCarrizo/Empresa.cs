using System;
using System.Collections.Generic;

namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Empresa
    {
        private List<Division> divisiones = new List<Division>();
        private string nombreEmpresa;
        private string rutEmpresa;

        public Empresa(string nombreEmpresa, string rutEmpresa)
        {
            this.NombreEmpresa = nombreEmpresa;
            this.RutEmpresa = rutEmpresa;
            this.Divisiones = divisiones;
        }

        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string RutEmpresa { get => rutEmpresa; set => rutEmpresa = value; }
        public List<Division> Divisiones { get => divisiones; set => divisiones = value; }
    }
}
