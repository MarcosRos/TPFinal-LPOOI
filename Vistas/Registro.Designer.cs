namespace Vistas
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnCargarUsuario = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombreUsu = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnBuscarUserName = new System.Windows.Forms.Button();
            this.lblBuscarUsername = new System.Windows.Forms.Label();
            this.txtBuscarNombreUsuario = new System.Windows.Forms.TextBox();
            this.dgvConsultaUsuarios = new System.Windows.Forms.DataGridView();
            this.txtNombreBorrar = new System.Windows.Forms.TextBox();
            this.lblNombreBorrar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(652, 40);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(155, 21);
            this.cmbRol.TabIndex = 0;
            // 
            // btnCargarUsuario
            // 
            this.btnCargarUsuario.Location = new System.Drawing.Point(515, 127);
            this.btnCargarUsuario.Name = "btnCargarUsuario";
            this.btnCargarUsuario.Size = new System.Drawing.Size(292, 35);
            this.btnCargarUsuario.TabIndex = 1;
            this.btnCargarUsuario.Text = "Cargar Usuario";
            this.btnCargarUsuario.UseVisualStyleBackColor = true;
            this.btnCargarUsuario.Click += new System.EventHandler(this.btnCargarUsuario_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(512, 43);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol:";
            // 
            // lblNombreUsu
            // 
            this.lblNombreUsu.AutoSize = true;
            this.lblNombreUsu.Location = new System.Drawing.Point(512, 13);
            this.lblNombreUsu.Name = "lblNombreUsu";
            this.lblNombreUsu.Size = new System.Drawing.Size(101, 13);
            this.lblNombreUsu.TabIndex = 3;
            this.lblNombreUsu.Text = "Nombre de Usuario:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(512, 73);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(512, 103);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(652, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(652, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(652, 101);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(155, 20);
            this.txtContraseña.TabIndex = 8;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(13, 13);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(493, 190);
            this.dgvUsuarios.TabIndex = 9;
            this.dgvUsuarios.CurrentCellChanged += new System.EventHandler(this.dgvUsuarios_CurrentCellChanged);
            // 
            // btnBuscarUserName
            // 
            this.btnBuscarUserName.Location = new System.Drawing.Point(515, 278);
            this.btnBuscarUserName.Name = "btnBuscarUserName";
            this.btnBuscarUserName.Size = new System.Drawing.Size(292, 36);
            this.btnBuscarUserName.TabIndex = 10;
            this.btnBuscarUserName.Text = "Buscar Usuarios";
            this.btnBuscarUserName.UseVisualStyleBackColor = true;
            this.btnBuscarUserName.Click += new System.EventHandler(this.btnBuscarUserName_Click);
            // 
            // lblBuscarUsername
            // 
            this.lblBuscarUsername.AutoSize = true;
            this.lblBuscarUsername.Location = new System.Drawing.Point(512, 255);
            this.lblBuscarUsername.Name = "lblBuscarUsername";
            this.lblBuscarUsername.Size = new System.Drawing.Size(113, 13);
            this.lblBuscarUsername.TabIndex = 12;
            this.lblBuscarUsername.Text = "Buscar Por Username:";
            // 
            // txtBuscarNombreUsuario
            // 
            this.txtBuscarNombreUsuario.Location = new System.Drawing.Point(652, 252);
            this.txtBuscarNombreUsuario.Name = "txtBuscarNombreUsuario";
            this.txtBuscarNombreUsuario.Size = new System.Drawing.Size(155, 20);
            this.txtBuscarNombreUsuario.TabIndex = 13;
            // 
            // dgvConsultaUsuarios
            // 
            this.dgvConsultaUsuarios.AllowUserToAddRows = false;
            this.dgvConsultaUsuarios.AllowUserToDeleteRows = false;
            this.dgvConsultaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaUsuarios.Location = new System.Drawing.Point(13, 236);
            this.dgvConsultaUsuarios.Name = "dgvConsultaUsuarios";
            this.dgvConsultaUsuarios.ReadOnly = true;
            this.dgvConsultaUsuarios.Size = new System.Drawing.Size(493, 164);
            this.dgvConsultaUsuarios.TabIndex = 14;
            // 
            // txtNombreBorrar
            // 
            this.txtNombreBorrar.Location = new System.Drawing.Point(652, 338);
            this.txtNombreBorrar.Name = "txtNombreBorrar";
            this.txtNombreBorrar.Size = new System.Drawing.Size(155, 20);
            this.txtNombreBorrar.TabIndex = 17;
            // 
            // lblNombreBorrar
            // 
            this.lblNombreBorrar.AutoSize = true;
            this.lblNombreBorrar.Location = new System.Drawing.Point(512, 341);
            this.lblNombreBorrar.Name = "lblNombreBorrar";
            this.lblNombreBorrar.Size = new System.Drawing.Size(115, 13);
            this.lblNombreBorrar.TabIndex = 16;
            this.lblNombreBorrar.Text = "Eliminar por Username:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(515, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(292, 36);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar Usuarios";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(512, 168);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(146, 35);
            this.btnEditarUsuario.TabIndex = 18;
            this.btnEditarUsuario.Text = "Editar Usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(664, 168);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(146, 35);
            this.btnEliminarUsuario.TabIndex = 19;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 412);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.txtNombreBorrar);
            this.Controls.Add(this.lblNombreBorrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvConsultaUsuarios);
            this.Controls.Add(this.txtBuscarNombreUsuario);
            this.Controls.Add(this.lblBuscarUsername);
            this.Controls.Add(this.btnBuscarUserName);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreUsu);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnCargarUsuario);
            this.Controls.Add(this.cmbRol);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnCargarUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombreUsu;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnBuscarUserName;
        private System.Windows.Forms.Label lblBuscarUsername;
        private System.Windows.Forms.TextBox txtBuscarNombreUsuario;
        private System.Windows.Forms.DataGridView dgvConsultaUsuarios;
        private System.Windows.Forms.TextBox txtNombreBorrar;
        private System.Windows.Forms.Label lblNombreBorrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
    }
}