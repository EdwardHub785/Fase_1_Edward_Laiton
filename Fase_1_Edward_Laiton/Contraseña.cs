using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase_1_Edward_Laiton
{
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Now;
            lblFechaC.Text = fecha.ToString("G");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            txtContraseña.Focus();
        }
        private void button1_Click(object sender, EventArgs e)

        {
            if (txtContraseña.Text.Trim() == "123")
            {
                FrmDatos llamar = new FrmDatos();
                llamar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Clave Errada Intente de nuevo");
            }
            {
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
            
        }

        private void btnSalirContra_Click(object sender, EventArgs e)
        {
            DialogResult Si = MessageBox.Show("Esta seguro que desea salir de la aplicacion", "titulo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (Si == DialogResult.Yes)
            {
                Application.Exit();  
            }
            if (Si == DialogResult.No)
            {
                Contraseña frmContraseña = new Contraseña();
                frmContraseña.Show();
                this.Hide();
            }

        }

        private void Contraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
