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
            DataTable dt = TrabajarUsuario.list_Ventas();
            dgvVentaCli.DataSource = dt;
            lblVentas.Text = "Hay en total " + dt.Rows.Count.ToString() + " ventas";
        }

        private void load_dgvVentasDetalle()
        {
            DataTable dt = TrabajarUsuario.list_Productos_Vendidos();
            dgvProdCliente.DataSource = dt;
            lblDetalleVenta.Text = "Hay en total " + dt.Rows.Count.ToString() + " productos vendidos";
        }

        private void btnListarVentaCliente_Click(object sender, EventArgs e)
        {
            string dni = cmbVentaCliente.SelectedValue.ToString();
            DataTable dt = TrabajarUsuario.list_Ventas_Segun_Cliente(dni);
            dgvVentaCli.DataSource = dt;
            lblVentas.Text = "Hay en total " + dt.Rows.Count.ToString() + " ventas realizadas por este cliente";
        }

        private void btnListarVentaFecha_Click(object sender, EventArgs e)
        {
            DataTable dt = TrabajarUsuario.list_Ventas_Segun_Fecha(dtpDesdeVenta.Value, dtpHastaVenta.Value);
            dgvVentaCli.DataSource = dt;
            lblVentas.Text = "Hay en total " + dt.Rows.Count.ToString() + " ventas en este rango de fechas";
        }

        private void btnListarProdCli_Click(object sender, EventArgs e)
        {
            string dni = cmbCliProd.SelectedValue.ToString();
            DataTable dt = TrabajarUsuario.list_Productos_Segun_Cliente(dni);
            dgvProdCliente.DataSource = dt;
            lblDetalleVenta.Text = "Hay en total " + dt.Rows.Count.ToString() + " productos vendidos a este cliente";
        }

        private void btnListarProdFecha_Click(object sender, EventArgs e)
        {
            DataTable dt = TrabajarUsuario.list_Productos_Segun_Fecha(dtpDesdeProd.Value, dtpHastaProd.Value);
            dgvProdCliente.DataSource = dt;
            lblDetalleVenta.Text = "Hay en total "+dt.Rows.Count.ToString()+" productos en este rango de fechas";
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            FrmBuscarClientes frmBuscarClientes = new FrmBuscarClientes();
            frmBuscarClientes.Show();
        }

        private void btn_BuscarCli_Click(object sender, EventArgs e)
        {
            FrmBuscarClientes frmBuscarClientes = new FrmBuscarClientes();
            frmBuscarClientes.Show();

        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            string id = txtIdAEliminar.Text;
            if (MessageBox.Show("Estas seguro que deseas eliminar esta venta? Se irá por siempre y eso es mucho tiempo!", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.OK)
            {
                Boolean resultado = TrabajarUsuario.deleteVenta(id);
                if (resultado == true)
                {
                    MessageBox.Show("Venta Eliminada Correctamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_dgvVentas();
                    load_dgvVentasDetalle();
                }
                else
                {
                    MessageBox.Show("No se ha podido encontrar la venta a eliminar", "Eliminacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
