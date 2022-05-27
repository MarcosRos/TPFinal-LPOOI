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
            this.tabListarVentaProd = new System.Windows.Forms.TabControl();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.tabVentaDetalle = new System.Windows.Forms.TabPage();
            this.cmbVentaCliente = new System.Windows.Forms.ComboBox();
            this.lblListarVentaCli = new System.Windows.Forms.Label();
            this.dgvVentaCli = new System.Windows.Forms.DataGridView();
            this.dtpDesdeVenta = new System.Windows.Forms.DateTimePicker();
            this.dtpHastaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblVentasFechas = new System.Windows.Forms.Label();
            this.lblDesdeVenta = new System.Windows.Forms.Label();
            this.lblHastaVenta = new System.Windows.Forms.Label();
            this.btnListarVentaFecha = new System.Windows.Forms.Button();
            this.btnListarVentaCliente = new System.Windows.Forms.Button();
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
            this.tabVentaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaCli)).BeginInit();
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
            this.tabListarVentaProd.Size = new System.Drawing.Size(634, 303);
            this.tabListarVentaProd.TabIndex = 8;
            // 
            // tabVentas
            // 
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
            this.tabVentas.Size = new System.Drawing.Size(626, 277);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // tabVentaDetalle
            // 
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
            this.tabVentaDetalle.Size = new System.Drawing.Size(626, 277);
            this.tabVentaDetalle.TabIndex = 1;
            this.tabVentaDetalle.Text = "Detalles de Venta";
            this.tabVentaDetalle.UseVisualStyleBackColor = true;
            // 
            // cmbVentaCliente
            // 
            this.cmbVentaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVentaCliente.FormattingEnabled = true;
            this.cmbVentaCliente.Location = new System.Drawing.Point(190, 6);
            this.cmbVentaCliente.Name = "cmbVentaCliente";
            this.cmbVentaCliente.Size = new System.Drawing.Size(327, 21);
            this.cmbVentaCliente.TabIndex = 1;
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
            // dgvVentaCli
            // 
            this.dgvVentaCli.AllowUserToAddRows = false;
            this.dgvVentaCli.AllowUserToDeleteRows = false;
            this.dgvVentaCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentaCli.Location = new System.Drawing.Point(9, 87);
            this.dgvVentaCli.Name = "dgvVentaCli";
            this.dgvVentaCli.ReadOnly = true;
            this.dgvVentaCli.Size = new System.Drawing.Size(611, 184);
            this.dgvVentaCli.TabIndex = 3;
            // 
            // dtpDesdeVenta
            // 
            this.dtpDesdeVenta.Location = new System.Drawing.Point(47, 59);
            this.dtpDesdeVenta.Name = "dtpDesdeVenta";
            this.dtpDesdeVenta.Size = new System.Drawing.Size(210, 20);
            this.dtpDesdeVenta.TabIndex = 4;
            // 
            // dtpHastaVenta
            // 
            this.dtpHastaVenta.Location = new System.Drawing.Point(307, 59);
            this.dtpHastaVenta.Name = "dtpHastaVenta";
            this.dtpHastaVenta.Size = new System.Drawing.Size(210, 20);
            this.dtpHastaVenta.TabIndex = 5;
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
            // lblDesdeVenta
            // 
            this.lblDesdeVenta.AutoSize = true;
            this.lblDesdeVenta.Location = new System.Drawing.Point(6, 63);
            this.lblDesdeVenta.Name = "lblDesdeVenta";
            this.lblDesdeVenta.Size = new System.Drawing.Size(41, 13);
            this.lblDesdeVenta.TabIndex = 7;
            this.lblDesdeVenta.Text = "Desde:";
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
            // btnListarVentaFecha
            // 
            this.btnListarVentaFecha.Location = new System.Drawing.Point(523, 58);
            this.btnListarVentaFecha.Name = "btnListarVentaFecha";
            this.btnListarVentaFecha.Size = new System.Drawing.Size(97, 23);
            this.btnListarVentaFecha.TabIndex = 9;
            this.btnListarVentaFecha.Text = "Listar";
            this.btnListarVentaFecha.UseVisualStyleBackColor = true;
            // 
            // btnListarVentaCliente
            // 
            this.btnListarVentaCliente.Location = new System.Drawing.Point(523, 6);
            this.btnListarVentaCliente.Name = "btnListarVentaCliente";
            this.btnListarVentaCliente.Size = new System.Drawing.Size(97, 23);
            this.btnListarVentaCliente.TabIndex = 10;
            this.btnListarVentaCliente.Text = "Listar";
            this.btnListarVentaCliente.UseVisualStyleBackColor = true;
            // 
            // btnListarProdCli
            // 
            this.btnListarProdCli.Location = new System.Drawing.Point(523, 6);
            this.btnListarProdCli.Name = "btnListarProdCli";
            this.btnListarProdCli.Size = new System.Drawing.Size(97, 23);
            this.btnListarProdCli.TabIndex = 20;
            this.btnListarProdCli.Text = "Listar";
            this.btnListarProdCli.UseVisualStyleBackColor = true;
            // 
            // btnListarProdFecha
            // 
            this.btnListarProdFecha.Location = new System.Drawing.Point(523, 58);
            this.btnListarProdFecha.Name = "btnListarProdFecha";
            this.btnListarProdFecha.Size = new System.Drawing.Size(97, 23);
            this.btnListarProdFecha.TabIndex = 19;
            this.btnListarProdFecha.Text = "Listar";
            this.btnListarProdFecha.UseVisualStyleBackColor = true;
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
            this.cmbCliProd.Size = new System.Drawing.Size(327, 21);
            this.cmbCliProd.TabIndex = 11;
            // 
            // FrmListarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 327);
            this.Controls.Add(this.tabListarVentaProd);
            this.Name = "FrmListarVentas";
            this.Text = "FrmListarVentas";
            this.Load += new System.EventHandler(this.FrmListarVentas_Load);
            this.tabListarVentaProd.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.tabVentas.PerformLayout();
            this.tabVentaDetalle.ResumeLayout(false);
            this.tabVentaDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaCli)).EndInit();
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
    }
}