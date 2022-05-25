using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ObraSocial
    {
        private string oS_CUIT;
        private string oS_RazonSocial;
        private string oS_Telefono;
        private string oS_Direccion;

        public ObraSocial(string cuit, string razonSocial, string telefono, string direccion)
        {
            oS_CUIT = cuit;
            oS_RazonSocial = razonSocial;
            oS_Telefono = telefono;
            oS_Direccion = direccion;
        }

        public string OS_RazonSocial
        {
            get { return oS_RazonSocial; }
            set { oS_RazonSocial = value; }
        }
        
        public string OS_Direccion
        {
            get { return oS_Direccion; }
            set { oS_Direccion = value; }
        }
        
        public string OS_Telefono
        {
            get { return oS_Telefono; }
            set { oS_Telefono = value; }
        }

        public string OS_CUIT
        {
            get { return oS_CUIT; }
            set { oS_CUIT = value; }
        }

        public override string ToString()
        {
            return "CUIT: " + oS_CUIT + ". RazónSocial: " + oS_RazonSocial + ". Teléfono: " + oS_Telefono + ". Dirección: " + oS_Direccion;
        }
    }
}
