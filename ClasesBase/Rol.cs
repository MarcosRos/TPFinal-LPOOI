using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        private int rol_Codigo;
        private string rol_Descripcion;

        public string Rol_Descripcion
        {
            get { return rol_Descripcion; }
            set { rol_Descripcion = value; }
        }

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public Rol(int rol_Codigo, string rol_Descripcion)
        {
            this.rol_Codigo=rol_Codigo;
            this.rol_Descripcion=rol_Descripcion;
        }
    }
}
