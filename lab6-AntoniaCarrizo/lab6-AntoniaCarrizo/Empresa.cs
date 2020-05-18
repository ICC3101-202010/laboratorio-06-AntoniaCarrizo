using System;
namespace lab6AntoniaCarrizo
{
    [Serializable]
    public class Empresa
    {
        private string nombreEmpresa;
        private string rutEmpresa;

        public Empresa(string nombreEmpresa, string rutEmpresa)
        {
            this.NombreEmpresa = nombreEmpresa;
            this.RutEmpresa = rutEmpresa;
        }

        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string RutEmpresa { get => rutEmpresa; set => rutEmpresa = value; }
    }
}
