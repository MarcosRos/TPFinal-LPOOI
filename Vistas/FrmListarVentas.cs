using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmListarVentas : Form
    {
        public FrmListarVentas()
        {
            InitializeComponent();
        }


        private void FrmListarVentas_Load(object sender, EventArgs e)
        {
            load_dgvVentas();
            load_comboClientesVentas();
            load_comboClientesProductos();
            load_dgvVentasDetalle();

        }

        private void load_comboClientesVentas()
        {
            DataTable aux = TrabajarUsuario.list_Cliente();

            aux.Columns.Add("NombreCompleto");
            foreach (DataRow item in aux.Rows)
            {
                item["NombreCompleto"] = Convert.ToString(item["Nombre"]) + ' ' + Convert.ToString(item["Apellido"]);
            }

            cmbVentaCliente.DisplayMember = "NombreCompleto";
            cmbVentaCliente.ValueMember = "DNI";
            cmbVentaCliente.DataSource = aux;
        }

        private void load_comboClientesProductos()
        {
            DataTable aux = TrabajarUsuario.list_Cliente();

            aux.Columns.Add("NombreCompleto");
            foreach (DataRow item in aux.Rows)
            {
                item["NombreCompleto"] = Convert.ToString(item["Nombre"]) + ' ' + Convert.ToString(item["Apellido"]);
            }

            cmbCliProd.DisplayMember = "NombreCompleto";
            cmbCliProd.ValueMember = "DNI";
            cmbCliProd.DataSource = aux;
        }


        private void load_dgvVentas()
        {
            dgvVentaCli.DataSource = TrabajarUsuario.list_Ventas();
        }

        private void load_dgvVentasDetalle()
        {
            dgvProdCliente.DataSource = TrabajarUsuario.list_Productos_Vendidos();
        }

        private void btnListarVentaCliente_Click(object sender, EventArgs e)
        {
            string dni = cmbVentaCliente.SelectedValue.ToString();
            dgvVentaCli.DataSource = TrabajarUsuario.list_Ventas_Segun_Cliente(dni);
        }

        private void btnListarVentaFecha_Click(object sender, EventArgs e)
        {
            dgvVentaCli.DataSource = TrabajarUsuario.list_Ventas_Segun_Fecha(dtpDesdeVenta.Value, dtpHastaVenta.Value);
        }

        private void btnListarProdCli_Click(object sender, EventArgs e)
        {
            string dni = cmbCliProd.SelectedValue.ToString();
            dgvProdCliente.DataSource = TrabajarUsuario.list_Productos_Segun_Cliente(dni);
        }

        private void btnListarProdFecha_Click(object sender, EventArgs e)
        {
            dgvProdCliente.DataSource = TrabajarUsuario.list_Productos_Segun_Fecha(dtpDesdeProd.Value, dtpHastaProd.Value);
        }

    }
}
