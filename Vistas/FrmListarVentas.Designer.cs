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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.txtBuscarDNI = new System.Windows.Forms.TextBox();
            this.lblBuscarVenta = new System.Windows.Forms.Label();
            this.lblBuscarID = new System.Windows.Forms.Label();
            this.btnBuscarDNI = new System.Windows.Forms.Button();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 42);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(634, 273);
            this.dgvVentas.TabIndex = 0;
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.Location = new System.Drawing.Point(98, 12);
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.Size = new System.Drawing.Size(133, 20);
            this.txtBuscarDNI.TabIndex = 1;
            // 
            // lblBuscarVenta
            // 
            this.lblBuscarVenta.AutoSize = true;
            this.lblBuscarVenta.Location = new System.Drawing.Point(9, 16);
            this.lblBuscarVenta.Name = "lblBuscarVenta";
            this.lblBuscarVenta.Size = new System.Drawing.Size(83, 13);
            this.lblBuscarVenta.TabIndex = 2;
            this.lblBuscarVenta.Text = "Buscar por DNI:";
            // 
            // lblBuscarID
            // 
            this.lblBuscarID.AutoSize = true;
            this.lblBuscarID.Location = new System.Drawing.Point(276, 16);
            this.lblBuscarID.Name = "lblBuscarID";
            this.lblBuscarID.Size = new System.Drawing.Size(105, 13);
            this.lblBuscarID.TabIndex = 4;
            this.lblBuscarID.Text = "Buscar por ID venta:";
            // 
            // btnBuscarDNI
            // 
            this.btnBuscarDNI.BackgroundImage = global::Vistas.Properties.Resources._0404_09_search;
            this.btnBuscarDNI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarDNI.Location = new System.Drawing.Point(237, 7);
            this.btnBuscarDNI.Name = "btnBuscarDNI";
            this.btnBuscarDNI.Size = new System.Drawing.Size(30, 30);
            this.btnBuscarDNI.TabIndex = 5;
            this.btnBuscarDNI.UseVisualStyleBackColor = true;
            this.btnBuscarDNI.Click += new System.EventHandler(this.btnBuscarDNI_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.BackgroundImage = global::Vistas.Properties.Resources._0404_09_search;
            this.btnBuscarID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarID.Location = new System.Drawing.Point(517, 7);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(30, 30);
            this.btnBuscarID.TabIndex = 6;
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(563, 7);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(83, 30);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Location = new System.Drawing.Point(380, 13);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(133, 20);
            this.txtBuscarID.TabIndex = 3;
            // 
            // FrmListarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 327);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtBuscarID);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.btnBuscarDNI);
            this.Controls.Add(this.lblBuscarID);
            this.Controls.Add(this.lblBuscarVenta);
            this.Controls.Add(this.txtBuscarDNI);
            this.Controls.Add(this.dgvVentas);
            this.Name = "FrmListarVentas";
            this.Text = "FrmListarVentas";
            this.Load += new System.EventHandler(this.FrmListarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private System.Windows.Forms.Label lblBuscarVenta;
        private System.Windows.Forms.Label lblBuscarID;
        private System.Windows.Forms.Button btnBuscarDNI;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtBuscarID;
    }
}