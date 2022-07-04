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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

        }
        
        private void btnCargarUsuario_Click(object sender, EventArgs e)
        {
            Usuario userAux = new Usuario();

            bool bVacio = false;
            // Buscamos en cada Control.
            foreach (var ctrl in Controls)
            {
                //Preguntamos por cada TextBox de los controles del formulario
                if (ctrl is TextBox)
                {
                    TextBox textBox = ctrl as TextBox;
                    if (textBox.Text == String.Empty)
                    {
                        if ((textBox.Name.ToString() != "txtBuscarNombreUsuario" && textBox.Name.ToString() != "txtNombreBorrar"))
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
                string usernameAux = txtNombre.Text;
                Boolean unicidad = TrabajarUsuario.comprobarUsername(usernameAux);
                if (unicidad == true)
                {
                    userAux.Rol_Codigo = (int)cmbRol.SelectedValue;
                    userAux.Usu_ApellidoNombre = txtApellido.Text;
                    userAux.Usu_Contrasenia = txtContraseña.Text;
                    userAux.Usu_NombreUsuario = txtNombre.Text;

                    TrabajarUsuario.insert_Usuario(userAux);

                    foreach (var ctrl in Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            TextBox textBox = ctrl as TextBox;
                            if ((textBox.Name.ToString() != "txtBuscarNombreUsuario" && textBox.Name.ToString() != "txtNombreBorrar"))
                            {
                                textBox.Clear();
                            }
                        }
                    }
                    load_dgvUsuarios();
                    MessageBox.Show("Usuario Agregado Satisfactoriamente", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha agregado el usuario, ya que posee un Username ya existente", "Carga Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            load_comboRoles();
            load_dgvUsuarios();
            dgvUsuarios.Rows[0].Cells[0].Selected = false;
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtContraseña.Text = "";
            cmbRol.SelectedValue = 1;

        }

        private void btnBuscarUserName_Click(object sender, EventArgs e)
        {
            string userName = txtBuscarNombreUsuario.Text;
            dgvConsultaUsuarios.DataSource = TrabajarUsuario.consultarUsuariosUserName(userName);
        }

        private void load_comboRoles()
        {
            cmbRol.DisplayMember = "rol_Descripcion";
            cmbRol.ValueMember = "rol_Codigo";
            cmbRol.DataSource = TrabajarUsuario.list_roles();
        }

        private void load_dgvUsuarios()
        {
            dgvUsuarios.DataSource = TrabajarUsuario.list_users();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string username = txtNombreBorrar.Text;
            Boolean resultado=TrabajarUsuario.deleteUsuario(username);
            if (resultado == true)
            {
                MessageBox.Show("Usuario Eliminado Correctamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_dgvUsuarios();
                dgvConsultaUsuarios.DataSource = TrabajarUsuario.consultarUsuariosUserName(username);
            }
            else {
                MessageBox.Show("No se ha podido encontrar el usuario a eliminar", "Eliminacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null) 
            { 
            txtApellido.Text=dgvUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Username"].Value.ToString();
            cmbRol.SelectedValue = dgvUsuarios.CurrentRow.Cells["CodigoRol"].Value.ToString();
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            string usernameAEditar = dgvUsuarios.CurrentRow.Cells["Username"].Value.ToString();
            TrabajarUsuario.editarUsuario(usernameAEditar, txtApellido.Text, txtContraseña.Text, txtNombre.Text, (int) cmbRol.SelectedValue);
            MessageBox.Show("Usuario Editado Correctamente", "Edicion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_dgvUsuarios();
            dgvConsultaUsuarios.DataSource = null;
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string username = dgvUsuarios.CurrentRow.Cells["Username"].Value.ToString();
            Usuario unUsuario = new Usuario();
            unUsuario=TrabajarUsuario.devolverUsuario(username);
            unUsuario.Usu_NombreUsuario = username;


            DialogResult result = MessageBox.Show("Seguro que desea eliminar este usuario? \nID: " + unUsuario.Usu_ID + "\nUsername: "+ unUsuario.Usu_NombreUsuario.ToString()+"\nApellido: "+unUsuario.Usu_ApellidoNombre.ToString()+"\nContraseña: "+unUsuario.Usu_Contrasenia.ToString(), "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                TrabajarUsuario.deleteUsuario(username);
                MessageBox.Show("Usuario Eliminado Correctamente", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_dgvUsuarios();
                dgvConsultaUsuarios.DataSource = null;
            }
        }
    }
}
