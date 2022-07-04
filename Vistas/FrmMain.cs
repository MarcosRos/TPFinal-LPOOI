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
                    Boolean unicidad = TrabajarUsuario.comprobarDNIExistente(dniAux);
                    Boolean carnetIncorrecto = TrabajarUsuario.comprobarCarnetExistente(txtCliNroCarnet.Text);

                    if (unicidad && carnetIncorrecto)
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
                        if (!unicidad && !carnetIncorrecto)
                        {
                            MessageBox.Show("No se ha agregado el cliente, ya que posee un DNI y Nro de Carnet ya existentes", "Carga Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (!unicidad)
                            {
                                MessageBox.Show("No se ha agregado el cliente, ya que posee un DNI ya existente", "Carga Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("No se ha agregado el cliente, ya que posee un Nro de Carnet ya existente", "Carga Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        
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
            if (FrmLogin.rol == "1")
            {
                this.tControlGestion.TabPages.Remove(tabPageCli);
                this.ventasToolStripMenuItem.Visible = false;
            }
            else if (FrmLogin.rol == "2")
            {
                this.tControlGestion.TabPages.Remove(tabPageProd);
                this.usuariosToolStripMenuItem.Visible = false;
                load_comboObraSocial();
                load_dgvClientes();
                load_cmbObraSocial();
                load_dgvProductos();
                dgvClientes.Rows[0].Cells[0].Selected = false;
                dgvProductos.Rows[0].Cells[0].Selected = false;
                txtCliDni.Text = "";
                txtCliApellido.Text = "";
                txtCliNombre.Text = "";
                txtCliNroCarnet.Text = "";
                txtCliDireccion.Text = "";
                cmbOS.SelectedIndex = 0;
            }
            else
            {
                load_comboObraSocial();
                load_dgvClientes();
                load_cmbObraSocial();
                load_dgvProductos();
                dgvClientes.Rows[0].Cells[0].Selected = false;
                dgvProductos.Rows[0].Cells[0].Selected = false;
                txtCliDni.Text = "";
                txtCliApellido.Text = "";
                txtCliNombre.Text = "";
                txtCliNroCarnet.Text = "";
                txtCliDireccion.Text = "";
                cmbOS.SelectedIndex = 0;
            }
        }

        private void load_cmbObraSocial()
        {
            cmbObraSocial.DisplayMember = "OS_RazonSocial";
            cmbObraSocial.ValueMember = "OS_RazonSocial";
            cmbObraSocial.DataSource = TrabajarUsuario.list_ObraSocial();
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
            DataTable dt = (DataTable)dgvClientes.DataSource;
            lblClientes.Text = "Total de Clientes: " + dt.Rows.Count.ToString();
        }

        private void load_dgvProductos()
        {
            dgvProductos.DataSource = TrabajarUsuario.list_Productos();
        }


        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            string apellido = txtBuscarEliminarCliApellido.Text;
            string dni = txtBuscarEliminarCliDni.Text;
            DataTable dt = TrabajarUsuario.buscarCliApeDni(apellido, dni);
            dgvCliBuscar.DataSource = dt;
            lblClientesBuscar.Text = "Clientes segun filtro: " + dt.Rows.Count.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string apellido = txtBuscarEliminarCliApellido.Text;
            string dni = txtBuscarEliminarCliDni.Text;
            string resultado = TrabajarUsuario.deleteCliente(dni, apellido);
            if (resultado == "true")
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

                DataTable dt = TrabajarUsuario.list_ObraSocial();
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    Console.WriteLine(dt.Rows[i]["OS_RazonSocial"].ToString());
                    Console.WriteLine(dgvClientes.CurrentRow.Cells["ObraSocial"].Value.ToString());
                    if (dt.Rows[i]["OS_RazonSocial"].ToString() == dgvClientes.CurrentRow.Cells["ObraSocial"].Value.ToString())
                    {
                        cmbOS.SelectedIndex = i;
                    }
                }
                txtCliNroCarnet.Text = dgvClientes.CurrentRow.Cells["NroCarnet"].Value.ToString();
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            bool dniIncorrecto = false;
            bool carnetIncorrecto = false;
            string mensajeMostrar = "";
            string dniAEditar = dgvClientes.CurrentRow.Cells["DNI"].Value.ToString();
            string carnetAEditar = dgvClientes.CurrentRow.Cells["NroCarnet"].Value.ToString();
            if (!TrabajarUsuario.comprobarDNIExistente(txtCliDni.Text) && !(txtCliDni.Text == dniAEditar))
            {
                dniIncorrecto = true;
                mensajeMostrar += "El DNI del cliente al que se quiere modificar ya existe";
            }

            if (!TrabajarUsuario.comprobarCarnetExistente(txtCliNroCarnet.Text) && !(txtCliNroCarnet.Text == carnetAEditar))
            {
                if (dniIncorrecto)
                {
                    mensajeMostrar += ". Y ";
                }
                carnetIncorrecto = true;
                mensajeMostrar += "El Nro de Carnet del cliente al que se quiere modificar ya existe";
            }

            if (carnetIncorrecto || dniIncorrecto)
            {
                MessageBox.Show(mensajeMostrar, "No se pudo realizar la edición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TrabajarUsuario.editarCliente(dniAEditar, txtCliApellido.Text, txtCliNombre.Text, txtCliDireccion.Text, (string)cmbOS.SelectedValue, txtCliNroCarnet.Text, txtCliDni.Text);
            MessageBox.Show("Cliente Editado Correctamente", "Edicion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_dgvClientes();
            dgvCliBuscar.DataSource = null;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string dniEliminar = dgvClientes.CurrentRow.Cells["DNI"].Value.ToString();
            Cliente unCliente = new Cliente();
            unCliente = TrabajarUsuario.devolverCliente(dniEliminar);
            unCliente.Cli_DNI = dniEliminar;


            DialogResult result = MessageBox.Show("Seguro que desea eliminar este Cliente? \nID: " + unCliente.Cli_ID + "\nDNI: " + unCliente.Cli_DNI.ToString() + "\nApellido: " + unCliente.Cli_Apellido.ToString() + "\nNombre: " + unCliente.Cli_Nombre.ToString() + "\nDireccion: " + unCliente.Cli_Direccion.ToString() + "\nCUIT: " + unCliente.OS_CUIT.ToString() + "\nNroCarnet: " + unCliente.Cli_NroCarnet.ToString(), "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                string resultado = TrabajarUsuario.deleteCliente(dniEliminar, unCliente.Cli_Apellido);
                if (resultado == "true")
                {
                    MessageBox.Show("Cliente Eliminado Correctamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_dgvClientes();
                    dgvCliBuscar.DataSource = null;
                }
                else if (resultado == "false")
                {
                    MessageBox.Show("No se ha podido encontrar al cliente", "Eliminacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar este cliente, ya que posee ventas a su nombre", "Eliminacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_OrdenarClientes_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = TrabajarUsuario.list_Cliente_Apellido();
        }

        private void btnOrdenarDescCate_Click(object sender, EventArgs e)
        {
            if (rdbCategoria.Checked == true)
            {
                dgvProductos.DataSource = TrabajarUsuario.list_Productos_Categoria();
            }
            else if (rdbDescripcion.Checked == true)
            {
                dgvProductos.DataSource = TrabajarUsuario.list_Productos_Descripcion();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun filtro", "Filtrado fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            string codEliminar = dgvProductos.CurrentRow.Cells["Codigo"].Value.ToString();
            Producto unProducto = new Producto();
            unProducto.Prod_Categoria = dgvProductos.CurrentRow.Cells["Categoria"].Value.ToString();
            unProducto.Prod_Codigo = dgvProductos.CurrentRow.Cells["Codigo"].Value.ToString();
            unProducto.Prod_Descripcion = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
            unProducto.Prod_Precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells["Precio"].Value.ToString());


            DialogResult result = MessageBox.Show("Seguro que desea eliminar este Producto? \nCodigo: " + unProducto.Prod_Codigo + "\nCategoria: " + unProducto.Prod_Categoria + "\nDescripcion: " + unProducto.Prod_Descripcion + "\nPrecio: " + unProducto.Prod_Precio, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                string resultado = TrabajarUsuario.deleteProducto(codEliminar);
                if (resultado == "true")
                {
                    MessageBox.Show("Producto Eliminado Correctamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_dgvProductos();
                }
                else if (resultado == "false")
                {
                    MessageBox.Show("No se ha podido encontrar el producto", "Eliminacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar este producto, ya que existen ventas que lo poseen", "Eliminacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvProductos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                txtProdCodigo.Text = dgvProductos.CurrentRow.Cells["Codigo"].Value.ToString();
                txtProdCategoria.Text = dgvProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                txtProdDescripcion.Text = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtProdPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value.ToString();
            }
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            bool codIncorrecto = false;
            string mensajeMostrar = "";
            string codigoAEditar = dgvProductos.CurrentRow.Cells["Codigo"].Value.ToString();
            if (!TrabajarUsuario.comprobarCodigo(txtProdCodigo.Text) && !(txtProdCodigo.Text == codigoAEditar))
            {
                codIncorrecto = true;
                mensajeMostrar += "El Código del Producto al que se quiere modificar ya existe";
            }

            if (codIncorrecto)
            {
                MessageBox.Show(mensajeMostrar, "No se pudo realizar la edición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if(Decimal.TryParse(txtProdPrecio.Text, out n1){
            //decimal decimalConvertido = Decimal.TryParse(txtProdPrecio.Text);
            //}

            decimal decimalConvertido = Convert.ToDecimal(txtProdPrecio.Text);

            TrabajarUsuario.editarProducto(codigoAEditar, txtProdCodigo.Text, txtProdCategoria.Text, txtProdDescripcion.Text, decimalConvertido);
            MessageBox.Show("Producto Editado Correctamente", "Edicion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_dgvProductos();
            //dgvCliBuscar.DataSource = null;
        }

        private void btnObraSocial_Click(object sender, EventArgs e)
        {
            string obraSocial = cmbObraSocial.SelectedValue.ToString();
            DataTable dt = TrabajarUsuario.list_Cliente_segun_ObraSocial(obraSocial);
            dgvCliBuscar.DataSource = dt;
            lblClientesBuscar.Text = "Clientes segun filtro: " + dt.Rows.Count;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            load_dgvClientes();
            dgvClientes.Rows[0].Cells[0].Selected = false;
            dgvProductos.Rows[0].Cells[0].Selected = false;
            dgvClientes.ClearSelection();
            txtCliDni.Text = "";
            txtCliApellido.Text = "";
            txtCliNombre.Text = "";
            txtCliNroCarnet.Text = "";
            txtCliDireccion.Text = "";
            cmbOS.SelectedIndex = 0;
        }

    }
}
