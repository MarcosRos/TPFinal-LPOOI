using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_ID;
        private string usu_NombreUsuario;
        private string usu_Contrasenia;
        private string usu_ApellidoNombre;
        private int rol_Codigo;


        public string Usu_Contrasenia
        {
            get { return usu_Contrasenia; }
            set { usu_Contrasenia = value; }
        }

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }


        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }

        //vista
        public Usuario(int id, string nombreUsuario, string contra, string apellidoNombre, int codRol)
        {
            usu_ID = id;
            Usu_NombreUsuario = nombreUsuario;
            usu_Contrasenia = contra;
            usu_ApellidoNombre = apellidoNombre;
            rol_Codigo = codRol;
        }

        public Usuario()
        {
            // TODO: Complete member initialization
        }
    }
}
