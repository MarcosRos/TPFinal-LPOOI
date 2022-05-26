using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ClasesBase;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCliAlta_Click(object sender, EventArgs e)
        {
            bool bVacio = false;
            // Buscamos en cada Control de nuestro tabPage. a
            foreach (var ctrl in tabPageCli.Controls)
            {
                //Preguntamos por cada TextBox de los controles del formulario
                if (ctrl is TextBox)
                {
                    TextBox textBox = ctrl as TextBox;
                    if (textBox.Text == String.Empty)
                    {
                        if ((textBox.Name.ToString() != "txtBuscarEliminarCliDni" && textBox.Name.ToString() != "txtBuscarEliminarCliApellido"))
                        {
                            bVacio = true;
                        }
                    }
                }
            }

            if (bVacio == true)
            {
                MessageBox.Show("No se llenaron todos los campos", "Advertencia: Datos No Válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Quieres agregar a este cliente?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cliente cliente = new Cliente();
                    string dniAux = txtCliDni.Text;
                    Boolean unicidad = TrabajarUsuario.comprobarDNI(dniAux);

                    if (unicidad == true)
                    {
                        cliente.Cli_DNI = txtCliDni.Text;
                        cliente.Cli_Apellido = txtCliApellido.Text;
                        cliente.Cli_Nombre = txtCliNombre.Text;
                        cliente.Cli_NroCarnet = txtCliNroCarnet.Text;
                        cliente.Cli_Direccion = txtCliDireccion.Text;
                        cliente.OS_CUIT = cmbOS.SelectedValue.ToString();

                        TrabajarUsuario.insert_Cliente(cliente);
                        ClearTabPage(tabPageCli);
                        load_dgvClientes();
                        MessageBox.Show("Cliente Agregado Satisfactoriamente", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Limpiar textboxes usadas para el registro
                        foreach (var ctrl in tabPageCli.Controls)
                        {
                          if (ctrl is TextBox)
                          {
                            TextBox textBox = ctrl as TextBox;
                            if ((textBox.Name.ToString() != "txtBuscarEliminarCliDni" && textBox.Name.ToString() != "txtBuscarEliminarCliApellido"))
                            {
                                textBox.Clear();
                            }
                          }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha agregado el cliente, ya que posee un DNI ya existente", "Carga Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnProdAlta_Click(object sender, EventArgs e)
        {
            bool bVacio = false;

            // Buscamos en cada Control de nuestro tabPage.
            foreach (var ctrl in tabPageProd.Controls)
            {
                //Preguntamos por cada TextBox de los controles del formulario
                if (ctrl is TextBox)
                {
                    TextBox textBox = ctrl as TextBox;
                    //Si algún TextBox se encontrase vacío la variable auxiliar se vuelve "true"
                    if (textBox.Text == String.Empty)
                    {
                        bVacio = true;
                    }
                }
            }

            if (bVacio == true)
            {
                MessageBox.Show("No se llenaron todos los campos", "Advertencia: Datos No Válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Quieres agregar este producto?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Producto producto;
                    string codigoAux = txtProdCodigo.Text;
                    Boolean unicidad = TrabajarUsuario.comprobarCodigo(codigoAux);

                    if (unicidad == true)
                    {
                        try
                        {
                            producto = new Producto(txtProdCodigo.Text, txtProdCategoria.Text, txtProdDescripcion.Text, Convert.ToDecimal(txtProdPrecio.Text));
                            TrabajarUsuario.insert_Producto(producto);
                            ClearTabPage(tabPageProd);
                            load_dgvProductos();
                            MessageBox.Show("Producto Agregado Satisfactoriamente", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Ha intentado cargar en el miembro precio un valor que no era decimal", "Datos No Válidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha agregado el producto, ya que posee un Codigo ya existente", "Carga Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MenuItemMainSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres salir de la aplicación?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
                //this.Close(); solo cierra la ventana
            }
        }

        private void ClearTabPage(TabPage tab)
        {
            foreach (var ctrl in tab.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if(FrmLogin.rol=="1"){
                this.tControlGestion.TabPages.Remove(tabPageCli);
                this.ventasToolStripMenuItem.Visible = false;
            }
            else if (FrmLogin.rol == "2")
            {
                this.tControlGestion.TabPages.Remove(tabPageProd);
                this.usuariosToolStripMenuItem.Visible = false;
                load_comboObraSocial();
                load_dgvClientes();
                load_dgvProductos();
                dgvClientes.Rows[0].Cells[0].Selected = false;
                txtCliDni.Text = "";
                txtCliApellido.Text = "";
                txtCliNombre.Text = "";
                txtCliNroCarnet.Text = "";
                txtCliDireccion.Text = "";
                cmbOS.SelectedValue = "30 - 71096961 - 9";
            }
            else
            {
                load_comboObraSocial();
                load_dgvClientes();
                load_dgvProductos();
                dgvClientes.Rows[0].Cells[0].Selected = false;
                txtCliDni.Text = "";
                txtCliApellido.Text = "";
                txtCliNombre.Text = "";
                txtCliNroCarnet.Text = "";
                txtCliDireccion.Text = "";
                cmbOS.SelectedValue = "30 - 71096961 - 9";
            }
        }

        private void load_comboObraSocial()
        {
            cmbOS.DisplayMember = "OS_RazonSocial";
            cmbOS.ValueMember = "OS_CUIT";
            cmbOS.DataSource = TrabajarUsuario.list_ObraSocial();
        }

        private void load_dgvClientes()
        {
            dgvClientes.DataSource = TrabajarUsuario.list_Cliente();
        }

        private void load_dgvProductos()
        {
            dgvProductos.DataSource = TrabajarUsuario.list_Productos();
        }


        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            string apellido = txtBuscarEliminarCliApellido.Text;
            string dni = txtBuscarEliminarCliDni.Text;
            dgvCliBuscar.DataSource = TrabajarUsuario.buscarCliApeDni(apellido, dni);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string apellido = txtBuscarEliminarCliApellido.Text;
            string dni = txtBuscarEliminarCliDni.Text;
            Boolean resultado = TrabajarUsuario.deleteCliente(dni, apellido);
            if (resultado == true)
            {
                MessageBox.Show("Usuario Eliminado Correctamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_dgvClientes();
                //dgvConsultaUsuarios.DataSource = TrabajarUsuario.consultarUsuariosUserName(username);

            }
            else
            {
                MessageBox.Show("No se ha podido encontrar el usuario a eliminar", "Eliminacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void agregarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas formVentas = new FrmVentas();
            formVentas.Show();
        }

        private void listarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarVentas formListarVentas = new FrmListarVentas();
            formListarVentas.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro formRegistro = new Registro();
            formRegistro.Show();
        }

        private void dgvClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null) 
            {
                txtCliDni.Text = dgvClientes.CurrentRow.Cells["DNI"].Value.ToString();
                txtCliApellido.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtCliNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCliDireccion.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                cmbOS.SelectedValue = dgvClientes.CurrentRow.Cells["ObraSocial"].Value.ToString();
                txtCliNroCarnet.Text = dgvClientes.CurrentRow.Cells["NroCarnet"].Value.ToString();
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            string dniAEditar = dgvClientes.CurrentRow.Cells["cli_DNI"].Value.ToString();
            TrabajarUsuario.editarCliente(dniAEditar, txtCliApellido.Text, txtCliNombre.Text, txtCliDireccion.Text, (string) cmbOS.SelectedValue , txtCliNroCarnet.Text, txtCliDni.Text);
            MessageBox.Show("Cliente Editado Correctamente", "Edicion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_dgvClientes();
            dgvCliBuscar.DataSource = null;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string dniEliminar = dgvClientes.CurrentRow.Cells["cli_DNI"].Value.ToString();
            Cliente unCliente = new Cliente();
            unCliente = TrabajarUsuario.devolverCliente(dniEliminar);
            unCliente.Cli_DNI = dniEliminar;


            DialogResult result = MessageBox.Show("Seguro que desea eliminar este Cliente? \nID: " + unCliente.Cli_ID + "\nDNI: " + unCliente.Cli_DNI.ToString() + "\nApellido: " + unCliente.Cli_Apellido.ToString() + "\nNombre: " + unCliente.Cli_Nombre.ToString() + "\nDireccion: " + unCliente.Cli_Direccion.ToString() + "\nCUIT: " + unCliente.OS_CUIT.ToString() + "\nNroCarnet: " + unCliente.Cli_NroCarnet.ToString(), "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                TrabajarUsuario.deleteCliente(dniEliminar,unCliente.Cli_Apellido);
                MessageBox.Show("Cliente Eliminado Correctamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_dgvClientes();
                dgvCliBuscar.DataSource = null;
            }
        }

        private void btn_OrdenarClientes_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = TrabajarUsuario.list_Cliente_Apellido();
        }


    }
}
