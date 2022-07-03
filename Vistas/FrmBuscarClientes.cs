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
    public partial class FrmBuscarClientes : Form
    {
        public Cliente unCliente = null;
        public FrmBuscarClientes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text, apellido = txtApellido.Text, nombre = txtNombre.Text;
            dgvClientes.DataSource = TrabajarUsuario.buscarCliApeDniNombre(apellido,dni,nombre);
            btnOrdenar.Enabled = true;
            dgvClientes.Rows[0].Cells[0].Selected = false;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rbDNI.Checked == true)
            {
                DataTable dt = (DataTable)dgvClientes.DataSource;
                DataView dv = dt.DefaultView;
                dv.Sort= "DNI ASC";
                dt = dv.Table;
                dgvClientes.DataSource = dt;
            }
            else if (rbApellido.Checked == true)
            {
                DataTable dt = (DataTable)dgvClientes.DataSource;
                DataView dv = dt.DefaultView;
                dv.Sort = "Apellido ASC";
                dt = dv.Table;
                dgvClientes.DataSource = dt;
            }
            else if (rbNroCarnet.Checked == true)
            {
                DataTable dt = (DataTable)dgvClientes.DataSource;
                DataView dv = dt.DefaultView;
                dv.Sort = "NroCarnet ASC";
                dt = dv.Table;
                dgvClientes.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun filtro", "Filtrado fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void dgvClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                string apellido = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                string nombre = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                string dni = dgvClientes.CurrentRow.Cells["DNI"].Value.ToString();
                unCliente = new Cliente();
                unCliente.Cli_Apellido = apellido;
                unCliente.Cli_Nombre = nombre;
                unCliente.Cli_DNI = dni;
            }
        }

        private void FrmBuscarClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = TrabajarUsuario.list_Cliente();
            dgvClientes.Rows[0].Cells[0].Selected = true;
            Console.WriteLine(dgvClientes.CurrentRow);
        }
    }
}
