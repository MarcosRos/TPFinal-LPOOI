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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            load_comboClientes();
            load_comboProductos();
        }

        private void load_comboClientes()
        {
            DataTable aux = TrabajarUsuario.list_Cliente();

            aux.Columns.Add("NombreCompleto");
            foreach(DataRow item in aux.Rows)
            {
                item["NombreCompleto"] = Convert.ToString(item["cli_Nombre"]) + ' '+ Convert.ToString(item["cli_Apellido"]);
            }

            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "cli_DNI";
            cmbClientes.DataSource = aux;
        }

        private void load_comboProductos()
        {
            cmbProductos.DisplayMember = "prod_Descripcion";
            cmbProductos.ValueMember = "prod_Codigo";
            cmbProductos.DataSource = TrabajarUsuario.list_Productos();
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            int cantCli = TrabajarUsuario.contarClientes();
            int cantProd = TrabajarUsuario.contarProductos();

            if (cantCli == 0 || cantProd == 0)
            {
                if (cantCli == 0 && cantProd == 0)
                {
                    MessageBox.Show("Las tablas de clientes y productos están vacías", "Advertencia: Datos No Válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cantCli == 0)
                    {
                        MessageBox.Show("La tabla de clientes está vacía", "Advertencia: Datos No Válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("La tabla de productis está vacía", "Advertencia: Datos No Válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                //cargar venta
                TrabajarUsuario.insert_Venta(dtpFechaVenta.Value, (string)cmbClientes.SelectedValue);

                //busco el nro de venta de la venta cargada
                int nroVenta = TrabajarUsuario.buscarUltimoIDVenta();
                string cod_prod = (string)cmbProductos.SelectedValue;
                decimal det_Precio = TrabajarUsuario.buscarDetPrecio((string)cmbProductos.SelectedValue);
                decimal det_cantidad = (decimal)NumUDCantProd.Value;
                decimal det_total = det_Precio * det_cantidad;
                //cargo el detalleventa con todos los datos de
                TrabajarUsuario.insert_VentaDetalle(nroVenta, cod_prod, det_Precio, det_cantidad, det_total);

                MessageBox.Show("Venta Agregada Satisfactoriamente", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
