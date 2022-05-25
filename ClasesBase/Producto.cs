using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Producto
    {
        private string prod_Codigo;
        private string prod_Categoria;
        private string prod_Descripcion;
        private decimal prod_Precio;

        public string Prod_Codigo
        {
            get { return prod_Codigo; }
            set { prod_Codigo = value; }
        }
        

        public string Prod_Categoria
        {
            get { return prod_Categoria; }
            set { prod_Categoria = value; }
        }
        

        public string Prod_Descripcion
        {
            get { return prod_Descripcion; }
            set { prod_Descripcion = value; }
        }
        

        public decimal Prod_Precio
        {
            get { return prod_Precio; }
            set { prod_Precio = value; }
        }

        public Producto(string codigo,string categoria,string descripcion,decimal precio)
        {
            Prod_Codigo = codigo;
            Prod_Categoria = categoria;
            Prod_Descripcion = descripcion;
            Prod_Precio = precio;
        }

        public override string ToString()
        {
            return "Codigo: " + Prod_Codigo + ". Categoría: " + Prod_Categoria + ". Descripción: " + Prod_Descripcion + ". Precio: " + Prod_Precio;
        }
    }

}
