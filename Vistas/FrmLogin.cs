﻿using System;
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
    public partial class FrmLogin : Form
    {
        public static string rol="";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Boolean bUserfound = false;

            FrmMain oFrmMain = new FrmMain();
            int i;


            for (i = 0; i < TrabajarUsuario.count_of_users(); i++)
            {
                if ((TrabajarUsuario.list_users().Rows[i]["Username"].ToString() == txtUserName.Text) && TrabajarUsuario.list_users().Rows[i]["Contraseña"].ToString() == txtPassword.Text)
                {
                    bUserfound = true;
                    break;
                }
            }

            if (bUserfound)
            {
                MessageBox.Show("Bienvenido/a: " + TrabajarUsuario.list_users().Rows[i]["Apellido"], "Inicio Sesión Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rol = TrabajarUsuario.list_users().Rows[i]["Rol"].ToString();
                FrmLogin.ActiveForm.Hide();
                oFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Datos de Acceso Incorrectos", "Inicio Sesión incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccept_MHover(object sender, EventArgs e)
        {
            btnIngresar.Size = new Size(130, 30);
            btnIngresar.ForeColor = Color.DarkGreen;
            btnIngresar.BackColor = SystemColors.Highlight;
            btnIngresar.Font = new Font("Impact", 10, FontStyle.Regular);
        }

        private void btnAccept_MLeave(object sender, EventArgs e)
        {
            btnIngresar.Size = new Size(121, 30);
            btnIngresar.ForeColor = Color.DarkGreen;
            btnIngresar.BackColor = SystemColors.GradientActiveCaption;
            btnIngresar.Font = new Font("Impact", 9, FontStyle.Regular);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Version version = assembly.GetName().Version;
            MessageBox.Show("Gracias por usar nuestro Software! \n\nVersion: "+version, "Informacion del producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
