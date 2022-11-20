
namespace Fase_1_Edward_Laiton
{
    partial class Contraseña
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalirContra = new System.Windows.Forms.Button();
            this.lblFechaC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edward Laiton Zarate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nomina1.1";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContraseña.Location = new System.Drawing.Point(292, 129);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(138, 23);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "CONTRASEÑA";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtContraseña.Location = new System.Drawing.Point(311, 190);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 23);
            this.txtContraseña.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Tomato;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(307, 261);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 38);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "INGRESAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalirContra
            // 
            this.btnSalirContra.BackColor = System.Drawing.Color.Tomato;
            this.btnSalirContra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirContra.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalirContra.Location = new System.Drawing.Point(542, 261);
            this.btnSalirContra.Name = "btnSalirContra";
            this.btnSalirContra.Size = new System.Drawing.Size(104, 38);
            this.btnSalirContra.TabIndex = 5;
            this.btnSalirContra.Text = "SALIR";
            this.btnSalirContra.UseVisualStyleBackColor = false;
            this.btnSalirContra.Click += new System.EventHandler(this.btnSalirContra_Click);
            // 
            // lblFechaC
            // 
            this.lblFechaC.AutoSize = true;
            this.lblFechaC.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblFechaC.ForeColor = System.Drawing.Color.Black;
            this.lblFechaC.Location = new System.Drawing.Point(23, 60);
            this.lblFechaC.Name = "lblFechaC";
            this.lblFechaC.Size = new System.Drawing.Size(0, 14);
            this.lblFechaC.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFechaC);
            this.Controls.Add(this.btnSalirContra);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Contraseña";
            this.Text = "Nomina1.1";
            this.Load += new System.EventHandler(this.Contraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalirContra;
        private System.Windows.Forms.Label lblFechaC;
        private System.Windows.Forms.Timer timer1;
    }
}

