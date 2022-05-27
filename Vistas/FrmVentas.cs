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

        private DataTable dtProdVenta;

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            load_comboClientes();
            load_comboProductos();
            load_dgvProdVenta();
        }

        private void load_dgvProdVenta()
        {
            this.dtProdVenta= new DataTable();
            dtProdVenta.Columns.Add("pro_codigo", typeof(string));
            dtProdVenta.Columns.Add("pro_descripcion",typeof(string));
            dtProdVenta.Columns.Add("pro_cantidad", typeof(decimal));
            dtProdVenta.Columns.Add("pro_precio", typeof(decimal));
            dtProdVenta.Columns.Add("pro_total", typeof(decimal));

            dgvProdVenta.DataSource = this.dtProdVenta;
            dgvProdVenta.Columns["pro_codigo"].Visible = false;
        }

        private void load_comboClientes()
        {
            DataTable aux = TrabajarUsuario.list_Cliente();

            aux.Columns.Add("NombreCompleto");
            foreach(DataRow item in aux.Rows)
            {
                item["NombreCompleto"] = Convert.ToString(item["Nombre"]) + ' '+ Convert.ToString(item["Apellido"]);
            }

            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "DNI";
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
            if (this.dtProdVenta.Rows.Count == 0)
            {
                MessageBox.Show("Primero añada productos", "Advertencia: Datos No Válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //cargar venta
                TrabajarUsuario.insert_Venta(dtpFechaVenta.Value, (string)cmbClientes.SelectedValue);

                //busco el nro de venta de la venta cargada
                int nroVenta = TrabajarUsuario.buscarUltimoIDVenta();

                foreach (DataRow fila in this.dtProdVenta.Rows)
                {
                    string cod_prod = (string)fila["pro_codigo"];
                    decimal det_Precio= (decimal)fila["pro_precio"];
                    decimal det_cantidad= (decimal)fila["pro_cantidad"];
                    decimal det_total=(decimal)fila["pro_total"];

                    //cargo el detalleventa con todos los datos del registro
                    TrabajarUsuario.insert_VentaDetalle(nroVenta, cod_prod, det_Precio, det_cantidad, det_total);
                }

                MessageBox.Show("Venta Agregada Satisfactoriamente", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.dtProdVenta.Rows.Clear();
            }
        }

        private void btnAddProdVenta_Click(object sender, EventArgs e)
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
                        MessageBox.Show("La tabla de productos está vacía", "Advertencia: Datos No Válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                string codProd = (string)cmbProductos.SelectedValue;
                bool repetido = false;
                int indiceFila = 0;

                for (int i = 0; i < this.dtProdVenta.Rows.Count; i++)
                {
                    if (this.dtProdVenta.Rows[i]["pro_codigo"].ToString() == codProd)
                    {
                        repetido = true;
                        indiceFila = i;
                    }
                }

                if (repetido)
                {
                    this.dtProdVenta.Rows[indiceFila]["pro_cantidad"] = (decimal)NumUDCantProd.Value + (decimal)this.dtProdVenta.Rows[indiceFila]["pro_cantidad"];
                    this.dtProdVenta.Rows[indiceFila]["pro_total"] = (decimal)this.dtProdVenta.Rows[indiceFila]["pro_precio"] * (decimal)this.dtProdVenta.Rows[indiceFila]["pro_cantidad"];
                }
                else
                {
                    DataRow fila = this.dtProdVenta.NewRow();
                    decimal precio = TrabajarUsuario.buscarDetPrecio((string)cmbProductos.SelectedValue);

                    fila["pro_codigo"] = codProd;
                    fila["pro_descripcion"] = (string)cmbProductos.Text;
                    fila["pro_cantidad"] = (decimal)NumUDCantProd.Value;
                    fila["pro_precio"] = precio;
                    fila["pro_total"] = precio * (decimal)NumUDCantProd.Value;

                    this.dtProdVenta.Rows.Add(fila);
                }
            }
        }
    }
}
