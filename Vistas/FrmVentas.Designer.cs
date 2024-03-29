﻿namespace Vistas
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.NumUDCantProd = new System.Windows.Forms.NumericUpDown();
            this.btnAddProdVenta = new System.Windows.Forms.Button();
            this.dgvProdVenta = new System.Windows.Forms.DataGridView();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(84, 18);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(224, 21);
            this.cmbClientes.TabIndex = 0;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(84, 56);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(327, 20);
            this.dtpFechaVenta.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 21);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 62);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(12, 103);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(53, 13);
            this.lblProd.TabIndex = 4;
            this.lblProd.Text = "Producto:";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(84, 100);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(192, 21);
            this.cmbProductos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad:";
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Location = new System.Drawing.Point(155, 272);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(113, 23);
            this.btnGuardarVenta.TabIndex = 8;
            this.btnGuardarVenta.Text = "Guardar Venta";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // NumUDCantProd
            // 
            this.NumUDCantProd.Location = new System.Drawing.Point(337, 101);
            this.NumUDCantProd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDCantProd.Name = "NumUDCantProd";
            this.NumUDCantProd.Size = new System.Drawing.Size(74, 20);
            this.NumUDCantProd.TabIndex = 9;
            this.NumUDCantProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddProdVenta
            // 
            this.btnAddProdVenta.Location = new System.Drawing.Point(150, 128);
            this.btnAddProdVenta.Name = "btnAddProdVenta";
            this.btnAddProdVenta.Size = new System.Drawing.Size(123, 23);
            this.btnAddProdVenta.TabIndex = 10;
            this.btnAddProdVenta.Text = "Añadir Producto";
            this.btnAddProdVenta.UseVisualStyleBackColor = true;
            this.btnAddProdVenta.Click += new System.EventHandler(this.btnAddProdVenta_Click);
            // 
            // dgvProdVenta
            // 
            this.dgvProdVenta.AllowUserToAddRows = false;
            this.dgvProdVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdVenta.Location = new System.Drawing.Point(12, 157);
            this.dgvProdVenta.Name = "dgvProdVenta";
            this.dgvProdVenta.ReadOnly = true;
            this.dgvProdVenta.Size = new System.Drawing.Size(399, 109);
            this.dgvProdVenta.TabIndex = 11;
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Location = new System.Drawing.Point(314, 10);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(97, 34);
            this.btnBuscarClientes.TabIndex = 12;
            this.btnBuscarClientes.Text = "Buscador de Clientes";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 307);
            this.Controls.Add(this.btnBuscarClientes);
            this.Controls.Add(this.dgvProdVenta);
            this.Controls.Add(this.btnAddProdVenta);
            this.Controls.Add(this.NumUDCantProd);
            this.Controls.Add(this.btnGuardarVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.cmbClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentas";
            this.Text = "Crear Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.NumericUpDown NumUDCantProd;
        private System.Windows.Forms.Button btnAddProdVenta;
        private System.Windows.Forms.DataGridView dgvProdVenta;
        private System.Windows.Forms.Button btnBuscarClientes;
    }
}