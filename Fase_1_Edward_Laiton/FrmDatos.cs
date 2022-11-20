using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fase_1_Edward_Laiton
{
    public partial class FrmDatos : Form

    {
        Nomina nomina = new Nomina();
        Imprimir imprimir = new Imprimir();
        DateTime fecha = DateTime.Now;

        public FrmDatos()
        {
            InitializeComponent();
            txtIdentificacion.Focus();
        }
        public void FrmDatos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = fecha.ToString("G");
            cbmCargo.Items.Add("Servicios Generales");
            cbmCargo.Items.Add("Administrativo");
            cbmCargo.Items.Add("Electricista");
            cbmCargo.Items.Add("Mecanico");
            cbmCargo.Items.Add("Soldador");

        }

        public void cbmCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmCargo.Text == "Servicios Generales")
            {
                txtSalarioDia.Text = "40000";

            }
            else if (cbmCargo.Text == "Administrativo")
            {
                txtSalarioDia.Text = "50000";
            }
            else if (cbmCargo.Text == "Electricista")
            {
                txtSalarioDia.Text = "60000";
            }
            else if (cbmCargo.Text == "Mecanico")
            {
                txtSalarioDia.Text = "65000";
            }
            else if (cbmCargo.Text == "Soldador")
            {
                txtSalarioDia.Text = "700000";
            }
        }

        private void rbtnFemenino_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtnFemenino.Checked)
            {
                imprimir.lblGeneroImprimir.Text = "Femenino";
            }

        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)

        {
            if (rbtnMasculino.Checked)
            {
                imprimir.lblGeneroImprimir.Text = "Masculino";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nomina.identificacion = txtIdentificacion.Text;
            nomina.nombre = txtNombre.Text;
            nomina.cargo = cbmCargo.Text;
            if (txtIdentificacion.Text == "")
            {
                errorProvider1.SetError(txtIdentificacion, "No se admiten campos vacios");
            }
            if (!int.TryParse(txtDiasLaborados.Text, out int numero))
            {
                errorProvider1.SetError(txtDiasLaborados, "Ingrese un numero");
            }
            else
            {
                nomina.dLaborados = numero;
            }
            if (!int.TryParse(txtSalarioDia.Text, out int SalDia))
            {
                errorProvider1.SetError(txtDiasLaborados, "Ingrese un numero");
            }
            else
            {
                nomina.salarioDia = SalDia;
            }

            // MessageBox.Show("Gracias por ingresar tus datos, registro exitoso");
        }
        
      
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            imprimir.Show();
            this.Hide();
            imprimir.lblIdentificacion.Text = nomina.identificacion;
            imprimir.lblNombre.Text = nomina.nombre;
            imprimir.lblCargo.Text = nomina.cargo;
            imprimir.lblDiasLaborados.Text = nomina.dLaborados.ToString();
            imprimir.lblSalarioDia.Text = nomina.salarioDia.ToString();
            imprimir.lblSalario.Text = nomina.CalcularSueldo(nomina.salarioDia,nomina.dLaborados).ToString();

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Si = MessageBox.Show("Esta seguro que desea salir de la aplicacion", "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Si == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Si == DialogResult.No)
            {
                FrmDatos frmDatos = new FrmDatos();
                frmDatos.Show();
                this.Hide();
            }
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            bool ok = false;
            foreach (char cedula in txtIdentificacion.Text)
            {
                if (char.IsLetter(cedula))
                {
                    ok = true;
                    break;
                }
            }
            if (ok)
            {
                errorProvider1.SetError(txtIdentificacion, "No se admiten letras");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            bool ok = false;
            foreach (char nombre in txtNombre.Text)
            {
                if (char.IsDigit(nombre))
                {
                    ok = true;
                    break;
                }
            }
            if (ok)
            {
                errorProvider1.SetError(txtNombre, "No se admiten numeros");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }  
}
