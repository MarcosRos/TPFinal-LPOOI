﻿namespace Vistas
{
    partial class FrmMain
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
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquilinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMainSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageProd = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnProdAlta = new System.Windows.Forms.Button();
            this.txtProdDescripcion = new System.Windows.Forms.TextBox();
            this.txtProdPrecio = new System.Windows.Forms.TextBox();
            this.txtProdCodigo = new System.Windows.Forms.TextBox();
            this.txtProdCategoria = new System.Windows.Forms.TextBox();
            this.lblProdDescripcion = new System.Windows.Forms.Label();
            this.lblProdPrecio = new System.Windows.Forms.Label();
            this.lblProdCodigo = new System.Windows.Forms.Label();
            this.lblProdCategoria = new System.Windows.Forms.Label();
            this.tabPageCli = new System.Windows.Forms.TabPage();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.txtBuscarEliminarCliApellido = new System.Windows.Forms.TextBox();
            this.txtBuscarEliminarCliDni = new System.Windows.Forms.TextBox();
            this.dgvCliBuscar = new System.Windows.Forms.DataGridView();
            this.lblApellidoEliminar = new System.Windows.Forms.Label();
            this.lblDNIEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cmbOS = new System.Windows.Forms.ComboBox();
            this.btnCliAlta = new System.Windows.Forms.Button();
            this.txtCliDireccion = new System.Windows.Forms.TextBox();
            this.txtCliNroCarnet = new System.Windows.Forms.TextBox();
            this.txtCliDni = new System.Windows.Forms.TextBox();
            this.txtCliApellido = new System.Windows.Forms.TextBox();
            this.txtCliNombre = new System.Windows.Forms.TextBox();
            this.lblCliDireccion = new System.Windows.Forms.Label();
            this.lblCliCuit = new System.Windows.Forms.Label();
            this.lblCliNroCarnet = new System.Windows.Forms.Label();
            this.lblCliDni = new System.Windows.Forms.Label();
            this.lblCliApellido = new System.Windows.Forms.Label();
            this.lblCliNombre = new System.Windows.Forms.Label();
            this.tControlGestion = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPageProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabPageCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tControlGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // inquilinosToolStripMenuItem
            // 
            this.inquilinosToolStripMenuItem.Name = "inquilinosToolStripMenuItem";
            this.inquilinosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.inquilinosToolStripMenuItem.Text = "Inquilinos";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // alquilerToolStripMenuItem
            // 
            this.alquilerToolStripMenuItem.Name = "alquilerToolStripMenuItem";
            this.alquilerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.alquilerToolStripMenuItem.Text = "Alquiler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.inquilinosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.alquilerToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.MenuItemMainSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarVentasToolStripMenuItem,
            this.agregarVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // listarVentasToolStripMenuItem
            // 
            this.listarVentasToolStripMenuItem.Name = "listarVentasToolStripMenuItem";
            this.listarVentasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarVentasToolStripMenuItem.Text = "Listar Ventas";
            this.listarVentasToolStripMenuItem.Click += new System.EventHandler(this.listarVentasToolStripMenuItem_Click);
            // 
            // agregarVentasToolStripMenuItem
            // 
            this.agregarVentasToolStripMenuItem.Name = "agregarVentasToolStripMenuItem";
            this.agregarVentasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarVentasToolStripMenuItem.Text = "Agregar Venta";
            this.agregarVentasToolStripMenuItem.Click += new System.EventHandler(this.agregarVentasToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usuariosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // MenuItemMainSalir
            // 
            this.MenuItemMainSalir.Name = "MenuItemMainSalir";
            this.MenuItemMainSalir.Size = new System.Drawing.Size(41, 20);
            this.MenuItemMainSalir.Text = "Salir";
            this.MenuItemMainSalir.Click += new System.EventHandler(this.MenuItemMainSalir_Click);
            // 
            // tabPageProd
            // 
            this.tabPageProd.Controls.Add(this.dgvProductos);
            this.tabPageProd.Controls.Add(this.btnProdAlta);
            this.tabPageProd.Controls.Add(this.txtProdDescripcion);
            this.tabPageProd.Controls.Add(this.txtProdPrecio);
            this.tabPageProd.Controls.Add(this.txtProdCodigo);
            this.tabPageProd.Controls.Add(this.txtProdCategoria);
            this.tabPageProd.Controls.Add(this.lblProdDescripcion);
            this.tabPageProd.Controls.Add(this.lblProdPrecio);
            this.tabPageProd.Controls.Add(this.lblProdCodigo);
            this.tabPageProd.Controls.Add(this.lblProdCategoria);
            this.tabPageProd.Location = new System.Drawing.Point(4, 22);
            this.tabPageProd.Name = "tabPageProd";
            this.tabPageProd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProd.Size = new System.Drawing.Size(887, 534);
            this.tabPageProd.TabIndex = 1;
            this.tabPageProd.Text = "Producto";
            this.tabPageProd.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(15, 22);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(443, 298);
            this.dgvProductos.TabIndex = 15;
            // 
            // btnProdAlta
            // 
            this.btnProdAlta.Location = new System.Drawing.Point(736, 298);
            this.btnProdAlta.Name = "btnProdAlta";
            this.btnProdAlta.Size = new System.Drawing.Size(145, 35);
            this.btnProdAlta.TabIndex = 8;
            this.btnProdAlta.Text = "Dar Alta";
            this.btnProdAlta.UseVisualStyleBackColor = true;
            this.btnProdAlta.Click += new System.EventHandler(this.btnProdAlta_Click);
            // 
            // txtProdDescripcion
            // 
            this.txtProdDescripcion.Location = new System.Drawing.Point(550, 167);
            this.txtProdDescripcion.Name = "txtProdDescripcion";
            this.txtProdDescripcion.Size = new System.Drawing.Size(323, 20);
            this.txtProdDescripcion.TabIndex = 5;
            // 
            // txtProdPrecio
            // 
            this.txtProdPrecio.Location = new System.Drawing.Point(550, 216);
            this.txtProdPrecio.Name = "txtProdPrecio";
            this.txtProdPrecio.Size = new System.Drawing.Size(323, 20);
            this.txtProdPrecio.TabIndex = 7;
            // 
            // txtProdCodigo
            // 
            this.txtProdCodigo.Location = new System.Drawing.Point(550, 69);
            this.txtProdCodigo.Name = "txtProdCodigo";
            this.txtProdCodigo.Size = new System.Drawing.Size(323, 20);
            this.txtProdCodigo.TabIndex = 1;
            // 
            // txtProdCategoria
            // 
            this.txtProdCategoria.Location = new System.Drawing.Point(550, 118);
            this.txtProdCategoria.Name = "txtProdCategoria";
            this.txtProdCategoria.Size = new System.Drawing.Size(323, 20);
            this.txtProdCategoria.TabIndex = 3;
            // 
            // lblProdDescripcion
            // 
            this.lblProdDescripcion.AutoSize = true;
            this.lblProdDescripcion.Location = new System.Drawing.Point(482, 170);
            this.lblProdDescripcion.Name = "lblProdDescripcion";
            this.lblProdDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblProdDescripcion.TabIndex = 4;
            this.lblProdDescripcion.Text = "Descripción";
            // 
            // lblProdPrecio
            // 
            this.lblProdPrecio.AutoSize = true;
            this.lblProdPrecio.Location = new System.Drawing.Point(482, 219);
            this.lblProdPrecio.Name = "lblProdPrecio";
            this.lblProdPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblProdPrecio.TabIndex = 6;
            this.lblProdPrecio.Text = "Precio";
            // 
            // lblProdCodigo
            // 
            this.lblProdCodigo.AutoSize = true;
            this.lblProdCodigo.Location = new System.Drawing.Point(482, 72);
            this.lblProdCodigo.Name = "lblProdCodigo";
            this.lblProdCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblProdCodigo.TabIndex = 0;
            this.lblProdCodigo.Text = "Código";
            // 
            // lblProdCategoria
            // 
            this.lblProdCategoria.AutoSize = true;
            this.lblProdCategoria.Location = new System.Drawing.Point(482, 121);
            this.lblProdCategoria.Name = "lblProdCategoria";
            this.lblProdCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblProdCategoria.TabIndex = 2;
            this.lblProdCategoria.Text = "Categoría";
            // 
            // tabPageCli
            // 
            this.tabPageCli.Controls.Add(this.btnEditarCliente);
            this.tabPageCli.Controls.Add(this.btnEliminarCliente);
            this.tabPageCli.Controls.Add(this.btnBuscarCli);
            this.tabPageCli.Controls.Add(this.txtBuscarEliminarCliApellido);
            this.tabPageCli.Controls.Add(this.txtBuscarEliminarCliDni);
            this.tabPageCli.Controls.Add(this.dgvCliBuscar);
            this.tabPageCli.Controls.Add(this.lblApellidoEliminar);
            this.tabPageCli.Controls.Add(this.lblDNIEliminar);
            this.tabPageCli.Controls.Add(this.btnEliminar);
            this.tabPageCli.Controls.Add(this.dgvClientes);
            this.tabPageCli.Controls.Add(this.cmbOS);
            this.tabPageCli.Controls.Add(this.btnCliAlta);
            this.tabPageCli.Controls.Add(this.txtCliDireccion);
            this.tabPageCli.Controls.Add(this.txtCliNroCarnet);
            this.tabPageCli.Controls.Add(this.txtCliDni);
            this.tabPageCli.Controls.Add(this.txtCliApellido);
            this.tabPageCli.Controls.Add(this.txtCliNombre);
            this.tabPageCli.Controls.Add(this.lblCliDireccion);
            this.tabPageCli.Controls.Add(this.lblCliCuit);
            this.tabPageCli.Controls.Add(this.lblCliNroCarnet);
            this.tabPageCli.Controls.Add(this.lblCliDni);
            this.tabPageCli.Controls.Add(this.lblCliApellido);
            this.tabPageCli.Controls.Add(this.lblCliNombre);
            this.tabPageCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageCli.Location = new System.Drawing.Point(4, 22);
            this.tabPageCli.Name = "tabPageCli";
            this.tabPageCli.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCli.Size = new System.Drawing.Size(887, 534);
            this.tabPageCli.TabIndex = 0;
            this.tabPageCli.Text = "Cliente";
            this.tabPageCli.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(471, 265);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(202, 41);
            this.btnEditarCliente.TabIndex = 23;
            this.btnEditarCliente.Text = "Editar Clientes";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(679, 265);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(202, 41);
            this.btnEliminarCliente.TabIndex = 22;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(471, 455);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(202, 41);
            this.btnBuscarCli.TabIndex = 20;
            this.btnBuscarCli.Text = "Buscar Clientes";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // txtBuscarEliminarCliApellido
            // 
            this.txtBuscarEliminarCliApellido.Location = new System.Drawing.Point(558, 417);
            this.txtBuscarEliminarCliApellido.Name = "txtBuscarEliminarCliApellido";
            this.txtBuscarEliminarCliApellido.Size = new System.Drawing.Size(323, 20);
            this.txtBuscarEliminarCliApellido.TabIndex = 19;
            // 
            // txtBuscarEliminarCliDni
            // 
            this.txtBuscarEliminarCliDni.Location = new System.Drawing.Point(558, 384);
            this.txtBuscarEliminarCliDni.Name = "txtBuscarEliminarCliDni";
            this.txtBuscarEliminarCliDni.Size = new System.Drawing.Size(323, 20);
            this.txtBuscarEliminarCliDni.TabIndex = 18;
            // 
            // dgvCliBuscar
            // 
            this.dgvCliBuscar.AllowUserToAddRows = false;
            this.dgvCliBuscar.AllowUserToDeleteRows = false;
            this.dgvCliBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliBuscar.Location = new System.Drawing.Point(15, 329);
            this.dgvCliBuscar.Name = "dgvCliBuscar";
            this.dgvCliBuscar.ReadOnly = true;
            this.dgvCliBuscar.Size = new System.Drawing.Size(443, 199);
            this.dgvCliBuscar.TabIndex = 15;
            // 
            // lblApellidoEliminar
            // 
            this.lblApellidoEliminar.AutoSize = true;
            this.lblApellidoEliminar.Location = new System.Drawing.Point(487, 420);
            this.lblApellidoEliminar.Name = "lblApellidoEliminar";
            this.lblApellidoEliminar.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoEliminar.TabIndex = 21;
            this.lblApellidoEliminar.Text = "Apellido";
            // 
            // lblDNIEliminar
            // 
            this.lblDNIEliminar.AutoSize = true;
            this.lblDNIEliminar.Location = new System.Drawing.Point(487, 384);
            this.lblDNIEliminar.Name = "lblDNIEliminar";
            this.lblDNIEliminar.Size = new System.Drawing.Size(26, 13);
            this.lblDNIEliminar.TabIndex = 19;
            this.lblDNIEliminar.Text = "DNI";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(679, 455);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(202, 41);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(15, 19);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(443, 297);
            this.dgvClientes.TabIndex = 14;
            this.dgvClientes.CurrentCellChanged += new System.EventHandler(this.dgvClientes_CurrentCellChanged);
            // 
            // cmbOS
            // 
            this.cmbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOS.FormattingEnabled = true;
            this.cmbOS.Location = new System.Drawing.Point(558, 155);
            this.cmbOS.Name = "cmbOS";
            this.cmbOS.Size = new System.Drawing.Size(323, 21);
            this.cmbOS.TabIndex = 13;
            // 
            // btnCliAlta
            // 
            this.btnCliAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCliAlta.Location = new System.Drawing.Point(471, 215);
            this.btnCliAlta.Name = "btnCliAlta";
            this.btnCliAlta.Size = new System.Drawing.Size(410, 41);
            this.btnCliAlta.TabIndex = 12;
            this.btnCliAlta.Text = "Dar Alta";
            this.btnCliAlta.UseVisualStyleBackColor = true;
            this.btnCliAlta.Click += new System.EventHandler(this.btnCliAlta_Click);
            // 
            // txtCliDireccion
            // 
            this.txtCliDireccion.Location = new System.Drawing.Point(558, 121);
            this.txtCliDireccion.Name = "txtCliDireccion";
            this.txtCliDireccion.Size = new System.Drawing.Size(323, 20);
            this.txtCliDireccion.TabIndex = 7;
            // 
            // txtCliNroCarnet
            // 
            this.txtCliNroCarnet.Location = new System.Drawing.Point(558, 189);
            this.txtCliNroCarnet.Name = "txtCliNroCarnet";
            this.txtCliNroCarnet.Size = new System.Drawing.Size(323, 20);
            this.txtCliNroCarnet.TabIndex = 11;
            // 
            // txtCliDni
            // 
            this.txtCliDni.Location = new System.Drawing.Point(558, 19);
            this.txtCliDni.Name = "txtCliDni";
            this.txtCliDni.Size = new System.Drawing.Size(323, 20);
            this.txtCliDni.TabIndex = 1;
            // 
            // txtCliApellido
            // 
            this.txtCliApellido.Location = new System.Drawing.Point(558, 53);
            this.txtCliApellido.Name = "txtCliApellido";
            this.txtCliApellido.Size = new System.Drawing.Size(323, 20);
            this.txtCliApellido.TabIndex = 3;
            // 
            // txtCliNombre
            // 
            this.txtCliNombre.Location = new System.Drawing.Point(558, 87);
            this.txtCliNombre.Name = "txtCliNombre";
            this.txtCliNombre.Size = new System.Drawing.Size(323, 20);
            this.txtCliNombre.TabIndex = 5;
            // 
            // lblCliDireccion
            // 
            this.lblCliDireccion.AutoSize = true;
            this.lblCliDireccion.Location = new System.Drawing.Point(487, 124);
            this.lblCliDireccion.Name = "lblCliDireccion";
            this.lblCliDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblCliDireccion.TabIndex = 6;
            this.lblCliDireccion.Text = "Direccion";
            // 
            // lblCliCuit
            // 
            this.lblCliCuit.AutoSize = true;
            this.lblCliCuit.Location = new System.Drawing.Point(487, 158);
            this.lblCliCuit.Name = "lblCliCuit";
            this.lblCliCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCliCuit.TabIndex = 8;
            this.lblCliCuit.Text = "CUIT";
            // 
            // lblCliNroCarnet
            // 
            this.lblCliNroCarnet.AutoSize = true;
            this.lblCliNroCarnet.Location = new System.Drawing.Point(487, 192);
            this.lblCliNroCarnet.Name = "lblCliNroCarnet";
            this.lblCliNroCarnet.Size = new System.Drawing.Size(58, 13);
            this.lblCliNroCarnet.TabIndex = 10;
            this.lblCliNroCarnet.Text = "Nro Carnet";
            // 
            // lblCliDni
            // 
            this.lblCliDni.AutoSize = true;
            this.lblCliDni.Location = new System.Drawing.Point(487, 22);
            this.lblCliDni.Name = "lblCliDni";
            this.lblCliDni.Size = new System.Drawing.Size(26, 13);
            this.lblCliDni.TabIndex = 0;
            this.lblCliDni.Text = "DNI";
            // 
            // lblCliApellido
            // 
            this.lblCliApellido.AutoSize = true;
            this.lblCliApellido.Location = new System.Drawing.Point(487, 56);
            this.lblCliApellido.Name = "lblCliApellido";
            this.lblCliApellido.Size = new System.Drawing.Size(44, 13);
            this.lblCliApellido.TabIndex = 2;
            this.lblCliApellido.Text = "Apellido";
            // 
            // lblCliNombre
            // 
            this.lblCliNombre.AutoSize = true;
            this.lblCliNombre.Location = new System.Drawing.Point(487, 90);
            this.lblCliNombre.Name = "lblCliNombre";
            this.lblCliNombre.Size = new System.Drawing.Size(44, 13);
            this.lblCliNombre.TabIndex = 4;
            this.lblCliNombre.Text = "Nombre";
            // 
            // tControlGestion
            // 
            this.tControlGestion.Controls.Add(this.tabPageCli);
            this.tControlGestion.Controls.Add(this.tabPageProd);
            this.tControlGestion.Location = new System.Drawing.Point(12, 27);
            this.tControlGestion.Name = "tControlGestion";
            this.tControlGestion.SelectedIndex = 0;
            this.tControlGestion.Size = new System.Drawing.Size(895, 560);
            this.tControlGestion.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 591);
            this.Controls.Add(this.tControlGestion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Sistema Óptica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageProd.ResumeLayout(false);
            this.tabPageProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabPageCli.ResumeLayout(false);
            this.tabPageCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tControlGestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquilinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquilerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMainSalir;
        private System.Windows.Forms.TabPage tabPageProd;
        private System.Windows.Forms.Button btnProdAlta;
        private System.Windows.Forms.TextBox txtProdDescripcion;
        private System.Windows.Forms.TextBox txtProdPrecio;
        private System.Windows.Forms.TextBox txtProdCodigo;
        private System.Windows.Forms.TextBox txtProdCategoria;
        private System.Windows.Forms.Label lblProdDescripcion;
        private System.Windows.Forms.Label lblProdPrecio;
        private System.Windows.Forms.Label lblProdCodigo;
        private System.Windows.Forms.Label lblProdCategoria;
        private System.Windows.Forms.TabPage tabPageCli;
        private System.Windows.Forms.Button btnCliAlta;
        private System.Windows.Forms.TextBox txtCliDireccion;
        private System.Windows.Forms.TextBox txtCliNroCarnet;
        private System.Windows.Forms.TextBox txtCliDni;
        private System.Windows.Forms.TextBox txtCliApellido;
        private System.Windows.Forms.TextBox txtCliNombre;
        private System.Windows.Forms.Label lblCliDireccion;
        private System.Windows.Forms.Label lblCliCuit;
        private System.Windows.Forms.Label lblCliNroCarnet;
        private System.Windows.Forms.Label lblCliDni;
        private System.Windows.Forms.Label lblCliApellido;
        private System.Windows.Forms.Label lblCliNombre;
        private System.Windows.Forms.TabControl tControlGestion;
        private System.Windows.Forms.ComboBox cmbOS;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.TextBox txtBuscarEliminarCliApellido;
        private System.Windows.Forms.TextBox txtBuscarEliminarCliDni;
        private System.Windows.Forms.DataGridView dgvCliBuscar;
        private System.Windows.Forms.Label lblApellidoEliminar;
        private System.Windows.Forms.Label lblDNIEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
//revisar
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;


    }
}