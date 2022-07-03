namespace Vistas
{
    partial class FrmListarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarVentas));
            this.tabListarVentaProd = new System.Windows.Forms.TabControl();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.lblEliminarVenta = new System.Windows.Forms.Label();
            this.txtIdAEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.btnListarVentaCliente = new System.Windows.Forms.Button();
            this.btnListarVentaFecha = new System.Windows.Forms.Button();
            this.lblHastaVenta = new System.Windows.Forms.Label();
            this.lblDesdeVenta = new System.Windows.Forms.Label();
            this.lblVentasFechas = new System.Windows.Forms.Label();
            this.dtpHastaVenta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeVenta = new System.Windows.Forms.DateTimePicker();
            this.dgvVentaCli = new System.Windows.Forms.DataGridView();
            this.lblListarVentaCli = new System.Windows.Forms.Label();
            this.cmbVentaCliente = new System.Windows.Forms.ComboBox();
            this.tabVentaDetalle = new System.Windows.Forms.TabPage();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.btn_BuscarCli = new System.Windows.Forms.Button();
            this.btnListarProdCli = new System.Windows.Forms.Button();
            this.btnListarProdFecha = new System.Windows.Forms.Button();
            this.lblHastaProd = new System.Windows.Forms.Label();
            this.lblDesdeProd = new System.Windows.Forms.Label();
            this.lblProdFecha = new System.Windows.Forms.Label();
            this.dtpHastaProd = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeProd = new System.Windows.Forms.DateTimePicker();
            this.dgvProdCliente = new System.Windows.Forms.DataGridView();
            this.lblProdCli = new System.Windows.Forms.Label();
            this.cmbCliProd = new System.Windows.Forms.ComboBox();
            this.tabListarVentaProd.SuspendLayout();
            this.tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaCli)).BeginInit();
            this.tabVentaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabListarVentaProd
            // 
            this.tabListarVentaProd.Controls.Add(this.tabVentas);
            this.tabListarVentaProd.Controls.Add(this.tabVentaDetalle);
            this.tabListarVentaProd.Location = new System.Drawing.Point(12, 12);
            this.tabListarVentaProd.Name = "tabListarVentaProd";
            this.tabListarVentaProd.SelectedIndex = 0;
            this.tabListarVentaProd.Size = new System.Drawing.Size(634, 353);
            this.tabListarVentaProd.TabIndex = 8;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.lblEliminarVenta);
            this.tabVentas.Controls.Add(this.txtIdAEliminar);
            this.tabVentas.Controls.Add(this.label1);
            this.tabVentas.Controls.Add(this.btnEliminarVenta);
            this.tabVentas.Controls.Add(this.lblVentas);
            this.tabVentas.Controls.Add(this.btnBuscarClientes);
            this.tabVentas.Controls.Add(this.btnListarVentaCliente);
            this.tabVentas.Controls.Add(this.btnListarVentaFecha);
            this.tabVentas.Controls.Add(this.lblHastaVenta);
            this.tabVentas.Controls.Add(this.lblDesdeVenta);
            this.tabVentas.Controls.Add(this.lblVentasFechas);
            this.tabVentas.Controls.Add(this.dtpHastaVenta);
            this.tabVentas.Controls.Add(this.dtpDesdeVenta);
            this.tabVentas.Controls.Add(this.dgvVentaCli);
            this.tabVentas.Controls.Add(this.lblListarVentaCli);
            this.tabVentas.Controls.Add(this.cmbVentaCliente);
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(626, 327);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // lblEliminarVenta
            // 
            this.lblEliminarVenta.AutoSize = true;
            this.lblEliminarVenta.Location = new System.Drawing.Point(6, 88);
            this.lblEliminarVenta.Name = "lblEliminarVenta";
            this.lblEliminarVenta.Size = new System.Drawing.Size(115, 13);
            this.lblEliminarVenta.TabIndex = 15;
            this.lblEliminarVenta.Text = "ID de Venta a Eliminar:";
            // 
            // txtIdAEliminar
            // 
            this.txtIdAEliminar.Location = new System.Drawing.Point(127, 85);
            this.txtIdAEliminar.Name = "txtIdAEliminar";
            this.txtIdAEliminar.Size = new System.Drawing.Size(287, 20);
            this.txtIdAEliminar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(420, 85);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(200, 21);
            this.btnEliminarVenta.TabIndex = 9;
            this.btnEliminarVenta.Text = "Eliminar una venta";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(9, 305);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(0, 13);
            this.lblVentas.TabIndex = 12;
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Location = new System.Drawing.Point(523, 6);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(97, 46);
            this.btnBuscarClientes.TabIndex = 11;
            this.btnBuscarClientes.Text = "Buscador de Clientes";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // btnListarVentaCliente
            // 
            this.btnListarVentaCliente.Location = new System.Drawing.Point(420, 6);
            this.btnListarVentaCliente.Name = "btnListarVentaCliente";
            this.btnListarVentaCliente.Size = new System.Drawing.Size(97, 23);
            this.btnListarVentaCliente.TabIndex = 10;
            this.btnListarVentaCliente.Text = "Listar";
            this.btnListarVentaCliente.UseVisualStyleBackColor = true;
            this.btnListarVentaCliente.Click += new System.EventHandler(this.btnListarVentaCliente_Click);
            // 
            // btnListarVentaFecha
            // 
            this.btnListarVentaFecha.Location = new System.Drawing.Point(523, 58);
            this.btnListarVentaFecha.Name = "btnListarVentaFecha";
            this.btnListarVentaFecha.Size = new System.Drawing.Size(97, 23);
            this.btnListarVentaFecha.TabIndex = 9;
            this.btnListarVentaFecha.Text = "Listar";
            this.btnListarVentaFecha.UseVisualStyleBackColor = true;
            this.btnListarVentaFecha.Click += new System.EventHandler(this.btnListarVentaFecha_Click);
            // 
            // lblHastaVenta
            // 
            this.lblHastaVenta.AutoSize = true;
            this.lblHastaVenta.Location = new System.Drawing.Point(263, 63);
            this.lblHastaVenta.Name = "lblHastaVenta";
            this.lblHastaVenta.Size = new System.Drawing.Size(38, 13);
            this.lblHastaVenta.TabIndex = 8;
            this.lblHastaVenta.Text = "Hasta:";
            // 
            // lblDesdeVenta
            // 
            this.lblDesdeVenta.AutoSize = true;
            this.lblDesdeVenta.Location = new System.Drawing.Point(6, 63);
            this.lblDesdeVenta.Name = "lblDesdeVenta";
            this.lblDesdeVenta.Size = new System.Drawing.Size(41, 13);
            this.lblDesdeVenta.TabIndex = 7;
            this.lblDesdeVenta.Text = "Desde:";
            // 
            // lblVentasFechas
            // 
            this.lblVentasFechas.AutoSize = true;
            this.lblVentasFechas.Location = new System.Drawing.Point(6, 39);
            this.lblVentasFechas.Name = "lblVentasFechas";
            this.lblVentasFechas.Size = new System.Drawing.Size(178, 13);
            this.lblVentasFechas.TabIndex = 6;
            this.lblVentasFechas.Text = "Listar Ventas Por Rango de Fechas:";
            // 
            // dtpHastaVenta
            // 
            this.dtpHastaVenta.Location = new System.Drawing.Point(307, 59);
            this.dtpHastaVenta.Name = "dtpHastaVenta";
            this.dtpHastaVenta.Size = new System.Drawing.Size(210, 20);
            this.dtpHastaVenta.TabIndex = 5;
            // 
            // dtpDesdeVenta
            // 
            this.dtpDesdeVenta.Location = new System.Drawing.Point(47, 59);
            this.dtpDesdeVenta.Name = "dtpDesdeVenta";
            this.dtpDesdeVenta.Size = new System.Drawing.Size(210, 20);
            this.dtpDesdeVenta.TabIndex = 4;
            // 
            // dgvVentaCli
            // 
            this.dgvVentaCli.AllowUserToAddRows = false;
            this.dgvVentaCli.AllowUserToDeleteRows = false;
            this.dgvVentaCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentaCli.Location = new System.Drawing.Point(9, 117);
            this.dgvVentaCli.Name = "dgvVentaCli";
            this.dgvVentaCli.ReadOnly = true;
            this.dgvVentaCli.Size = new System.Drawing.Size(611, 184);
            this.dgvVentaCli.TabIndex = 3;
            // 
            // lblListarVentaCli
            // 
            this.lblListarVentaCli.AutoSize = true;
            this.lblListarVentaCli.Location = new System.Drawing.Point(6, 9);
            this.lblListarVentaCli.Name = "lblListarVentaCli";
            this.lblListarVentaCli.Size = new System.Drawing.Size(125, 13);
            this.lblListarVentaCli.TabIndex = 2;
            this.lblListarVentaCli.Text = "Listar Ventas Por Cliente:";
            // 
            // cmbVentaCliente
            // 
            this.cmbVentaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVentaCliente.FormattingEnabled = true;
            this.cmbVentaCliente.Location = new System.Drawing.Point(190, 6);
            this.cmbVentaCliente.Name = "cmbVentaCliente";
            this.cmbVentaCliente.Size = new System.Drawing.Size(224, 21);
            this.cmbVentaCliente.TabIndex = 1;
            // 
            // tabVentaDetalle
            // 
            this.tabVentaDetalle.Controls.Add(this.lblDetalleVenta);
            this.tabVentaDetalle.Controls.Add(this.btn_BuscarCli);
            this.tabVentaDetalle.Controls.Add(this.btnListarProdCli);
            this.tabVentaDetalle.Controls.Add(this.btnListarProdFecha);
            this.tabVentaDetalle.Controls.Add(this.lblHastaProd);
            this.tabVentaDetalle.Controls.Add(this.lblDesdeProd);
            this.tabVentaDetalle.Controls.Add(this.lblProdFecha);
            this.tabVentaDetalle.Controls.Add(this.dtpHastaProd);
            this.tabVentaDetalle.Controls.Add(this.dtpDesdeProd);
            this.tabVentaDetalle.Controls.Add(this.dgvProdCliente);
            this.tabVentaDetalle.Controls.Add(this.lblProdCli);
            this.tabVentaDetalle.Controls.Add(this.cmbCliProd);
            this.tabVentaDetalle.Location = new System.Drawing.Point(4, 22);
            this.tabVentaDetalle.Name = "tabVentaDetalle";
            this.tabVentaDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentaDetalle.Size = new System.Drawing.Size(626, 327);
            this.tabVentaDetalle.TabIndex = 1;
            this.tabVentaDetalle.Text = "Detalles de Venta";
            this.tabVentaDetalle.UseVisualStyleBackColor = true;
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Location = new System.Drawing.Point(9, 278);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(0, 13);
            this.lblDetalleVenta.TabIndex = 22;
            // 
            // btn_BuscarCli
            // 
            this.btn_BuscarCli.Location = new System.Drawing.Point(523, 6);
            this.btn_BuscarCli.Name = "btn_BuscarCli";
            this.btn_BuscarCli.Size = new System.Drawing.Size(97, 46);
            this.btn_BuscarCli.TabIndex = 21;
            this.btn_BuscarCli.Text = "Buscador de Clientes";
            this.btn_BuscarCli.UseVisualStyleBackColor = true;
            this.btn_BuscarCli.Click += new System.EventHandler(this.btn_BuscarCli_Click);
            // 
            // btnListarProdCli
            // 
            this.btnListarProdCli.Location = new System.Drawing.Point(420, 6);
            this.btnListarProdCli.Name = "btnListarProdCli";
            this.btnListarProdCli.Size = new System.Drawing.Size(97, 23);
            this.btnListarProdCli.TabIndex = 20;
            this.btnListarProdCli.Text = "Listar";
            this.btnListarProdCli.UseVisualStyleBackColor = true;
            this.btnListarProdCli.Click += new System.EventHandler(this.btnListarProdCli_Click);
            // 
            // btnListarProdFecha
            // 
            this.btnListarProdFecha.Location = new System.Drawing.Point(523, 58);
            this.btnListarProdFecha.Name = "btnListarProdFecha";
            this.btnListarProdFecha.Size = new System.Drawing.Size(97, 23);
            this.btnListarProdFecha.TabIndex = 19;
            this.btnListarProdFecha.Text = "Listar";
            this.btnListarProdFecha.UseVisualStyleBackColor = true;
            this.btnListarProdFecha.Click += new System.EventHandler(this.btnListarProdFecha_Click);
            // 
            // lblHastaProd
            // 
            this.lblHastaProd.AutoSize = true;
            this.lblHastaProd.Location = new System.Drawing.Point(263, 63);
            this.lblHastaProd.Name = "lblHastaProd";
            this.lblHastaProd.Size = new System.Drawing.Size(38, 13);
            this.lblHastaProd.TabIndex = 18;
            this.lblHastaProd.Text = "Hasta:";
            // 
            // lblDesdeProd
            // 
            this.lblDesdeProd.AutoSize = true;
            this.lblDesdeProd.Location = new System.Drawing.Point(6, 63);
            this.lblDesdeProd.Name = "lblDesdeProd";
            this.lblDesdeProd.Size = new System.Drawing.Size(41, 13);
            this.lblDesdeProd.TabIndex = 17;
            this.lblDesdeProd.Text = "Desde:";
            // 
            // lblProdFecha
            // 
            this.lblProdFecha.AutoSize = true;
            this.lblProdFecha.Location = new System.Drawing.Point(6, 39);
            this.lblProdFecha.Name = "lblProdFecha";
            this.lblProdFecha.Size = new System.Drawing.Size(193, 13);
            this.lblProdFecha.TabIndex = 16;
            this.lblProdFecha.Text = "Listar Productos Por Rango de Fechas:";
            // 
            // dtpHastaProd
            // 
            this.dtpHastaProd.Location = new System.Drawing.Point(307, 59);
            this.dtpHastaProd.Name = "dtpHastaProd";
            this.dtpHastaProd.Size = new System.Drawing.Size(210, 20);
            this.dtpHastaProd.TabIndex = 15;
            // 
            // dtpDesdeProd
            // 
            this.dtpDesdeProd.Location = new System.Drawing.Point(47, 59);
            this.dtpDesdeProd.Name = "dtpDesdeProd";
            this.dtpDesdeProd.Size = new System.Drawing.Size(210, 20);
            this.dtpDesdeProd.TabIndex = 14;
            // 
            // dgvProdCliente
            // 
            this.dgvProdCliente.AllowUserToAddRows = false;
            this.dgvProdCliente.AllowUserToDeleteRows = false;
            this.dgvProdCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdCliente.Location = new System.Drawing.Point(9, 87);
            this.dgvProdCliente.Name = "dgvProdCliente";
            this.dgvProdCliente.ReadOnly = true;
            this.dgvProdCliente.Size = new System.Drawing.Size(611, 184);
            this.dgvProdCliente.TabIndex = 13;
            // 
            // lblProdCli
            // 
            this.lblProdCli.AutoSize = true;
            this.lblProdCli.Location = new System.Drawing.Point(6, 9);
            this.lblProdCli.Name = "lblProdCli";
            this.lblProdCli.Size = new System.Drawing.Size(140, 13);
            this.lblProdCli.TabIndex = 12;
            this.lblProdCli.Text = "Listar Productos Por Cliente:";
            // 
            // cmbCliProd
            // 
            this.cmbCliProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliProd.FormattingEnabled = true;
            this.cmbCliProd.Location = new System.Drawing.Point(190, 6);
            this.cmbCliProd.Name = "cmbCliProd";
            this.cmbCliProd.Size = new System.Drawing.Size(224, 21);
            this.cmbCliProd.TabIndex = 11;
            // 
            // FrmListarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 373);
            this.Controls.Add(this.tabListarVentaProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListarVentas";
            this.Text = "Listar Ventas";
            this.Load += new System.EventHandler(this.FrmListarVentas_Load);
            this.tabListarVentaProd.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.tabVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaCli)).EndInit();
            this.tabVentaDetalle.ResumeLayout(false);
            this.tabVentaDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabListarVentaProd;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TabPage tabVentaDetalle;
        private System.Windows.Forms.ComboBox cmbVentaCliente;
        private System.Windows.Forms.Label lblListarVentaCli;
        private System.Windows.Forms.DataGridView dgvVentaCli;
        private System.Windows.Forms.Label lblVentasFechas;
        private System.Windows.Forms.DateTimePicker dtpHastaVenta;
        private System.Windows.Forms.DateTimePicker dtpDesdeVenta;
        private System.Windows.Forms.Label lblDesdeVenta;
        private System.Windows.Forms.Label lblHastaVenta;
        private System.Windows.Forms.Button btnListarVentaFecha;
        private System.Windows.Forms.Button btnListarVentaCliente;
        private System.Windows.Forms.Button btnListarProdCli;
        private System.Windows.Forms.Button btnListarProdFecha;
        private System.Windows.Forms.Label lblHastaProd;
        private System.Windows.Forms.Label lblDesdeProd;
        private System.Windows.Forms.Label lblProdFecha;
        private System.Windows.Forms.DateTimePicker dtpHastaProd;
        private System.Windows.Forms.DateTimePicker dtpDesdeProd;
        private System.Windows.Forms.DataGridView dgvProdCliente;
        private System.Windows.Forms.Label lblProdCli;
        private System.Windows.Forms.ComboBox cmbCliProd;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.Label lblDetalleVenta;
        private System.Windows.Forms.Button btn_BuscarCli;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Label lblEliminarVenta;
        private System.Windows.Forms.TextBox txtIdAEliminar;
    }
}