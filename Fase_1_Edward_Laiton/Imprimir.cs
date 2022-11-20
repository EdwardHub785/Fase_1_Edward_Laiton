using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fase_1_Edward_Laiton
{
    
    public partial class Imprimir : Form

    {

        public Imprimir()
            
        {
            InitializeComponent();
        }

        public void Imprimir_Load(object sender, EventArgs e)
            
        {
           
        }

        public void lblGenero_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmDatos MyfrmDatos = new FrmDatos();
            MyfrmDatos.Show();
            this.Hide();
        }
    }
}
