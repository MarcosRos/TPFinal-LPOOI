using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private int cli_ID;
        private string cli_DNI;
        private string cli_Apellido;
        private string cli_Nombre;
        private string cli_Direccion;
        private string oS_CUIT;
        private string cli_NroCarnet;

        public int Cli_ID
        {
            get { return cli_ID; }
            set { cli_ID = value; }
        }

        public string Cli_DNI
        {
            get { return cli_DNI; }
            set { cli_DNI = value; }
        }
        

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }

        

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }

        

        public string Cli_Direccion
        {
            get { return cli_Direccion; }
            set { cli_Direccion = value; }
        }

        

        public string OS_CUIT
        {
            get { return oS_CUIT; }
            set { oS_CUIT = value; }
        }

        

        public string Cli_NroCarnet
        {
            get { return cli_NroCarnet; }
            set { cli_NroCarnet = value; }
        }

        public Cliente(string dni,string apellido, string nombre, string direccion, string cuit, string nroCarnet)
        {
            Cli_DNI = dni;
            Cli_Apellido = apellido;
            Cli_Nombre = nombre;
            Cli_Direccion = direccion;
            OS_CUIT = cuit;
            Cli_NroCarnet = nroCarnet;
        }

        public Cliente()
        {
            // TODO: Complete member initialization
        }

        public override string ToString() {
            return "Dni: " + Cli_DNI + ". Apellido: " + Cli_Apellido + ". Nombre: " + Cli_Nombre + ". Dirección: " + Cli_Direccion + ". CUIT: " + OS_CUIT + ". Nro Carnet: " + cli_NroCarnet;
        }
    }
}
