using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionGUI
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textUser_MouseEnter(object sender, EventArgs e)
        {
            if(textUser.Text == "USUARIO")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.LightGray;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "USUARIO";
                textUser.ForeColor = Color.DimGray;
            }
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if(textPass.Text == "CONTRASEÑA")
            {
                textPass.Text = "";
                textPass.ForeColor = Color.LightGray;
                textPass.UseSystemPasswordChar = true;
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if(textPass.Text == "")
            {
                textPass.Text = "CONTRASEÑA";
                textPass.ForeColor = Color.DimGray;
                textPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textUser.Text == "admi" && textPass.Text == "admin")
            {
                Inicio inicio = new Inicio();
                this.Hide();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                textUser.Clear();
                textPass.Clear();
            }
        }   
    }
}
