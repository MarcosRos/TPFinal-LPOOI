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
        }


        private void load_dgvVentas()
        {
            dgvVentas.DataSource = TrabajarUsuario.list_Ventas();
        }


        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarDNI.Text;
            dgvVentas.DataSource=TrabajarUsuario.buscarVentaDNI(dni);
        }


        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            try{
                int id = Convert.ToInt32(txtBuscarID.Text);
                dgvVentas.DataSource = TrabajarUsuario.buscarVentaID(id);

            }catch(FormatException)
            {
                MessageBox.Show("Ingrese un valor de tipo entero para buscar por ID de venta", "Datos No Válidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            load_dgvVentas();
        }
    }
}
