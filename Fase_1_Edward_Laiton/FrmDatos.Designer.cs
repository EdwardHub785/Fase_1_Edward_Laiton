
namespace Fase_1_Edward_Laiton
{
    partial class FrmDatos
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
            this.components = new System.ComponentModel.Container();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblSalarioDia = new System.Windows.Forms.Label();
            this.lblDiasL = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalarioDia = new System.Windows.Forms.TextBox();
            this.txtDiasLaborados = new System.Windows.Forms.TextBox();
            this.cbmCargo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblGeneroDatos = new System.Windows.Forms.Label();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.timerNomina = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblIdentificacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIdentificacion.Location = new System.Drawing.Point(63, 73);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(113, 19);
            this.lblIdentificacion.TabIndex = 3;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // lblSalarioDia
            // 
            this.lblSalarioDia.AutoSize = true;
            this.lblSalarioDia.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSalarioDia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalarioDia.Location = new System.Drawing.Point(63, 228);
            this.lblSalarioDia.Name = "lblSalarioDia";
            this.lblSalarioDia.Size = new System.Drawing.Size(93, 19);
            this.lblSalarioDia.TabIndex = 4;
            this.lblSalarioDia.Text = "Salario Dia";
            // 
            // lblDiasL
            // 
            this.lblDiasL.AutoSize = true;
            this.lblDiasL.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDiasL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDiasL.Location = new System.Drawing.Point(63, 279);
            this.lblDiasL.Name = "lblDiasL";
            this.lblDiasL.Size = new System.Drawing.Size(124, 19);
            this.lblDiasL.TabIndex = 5;
            this.lblDiasL.Text = "Dias Laborados";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(63, 117);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCargo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCargo.Location = new System.Drawing.Point(63, 172);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(54, 19);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "Cargo";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(201, 69);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(216, 23);
            this.txtIdentificacion.TabIndex = 8;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 23);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtSalarioDia
            // 
            this.txtSalarioDia.Enabled = false;
            this.txtSalarioDia.Location = new System.Drawing.Point(201, 224);
            this.txtSalarioDia.Name = "txtSalarioDia";
            this.txtSalarioDia.Size = new System.Drawing.Size(136, 23);
            this.txtSalarioDia.TabIndex = 10;
            // 
            // txtDiasLaborados
            // 
            this.txtDiasLaborados.Location = new System.Drawing.Point(201, 275);
            this.txtDiasLaborados.Name = "txtDiasLaborados";
            this.txtDiasLaborados.Size = new System.Drawing.Size(115, 23);
            this.txtDiasLaborados.TabIndex = 11;
            // 
            // cbmCargo
            // 
            this.cbmCargo.FormattingEnabled = true;
            this.cbmCargo.Location = new System.Drawing.Point(201, 168);
            this.cbmCargo.Name = "cbmCargo";
            this.cbmCargo.Size = new System.Drawing.Size(166, 23);
            this.cbmCargo.TabIndex = 12;
            this.cbmCargo.SelectedIndexChanged += new System.EventHandler(this.cbmCargo_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Tomato;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(201, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 36);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "GUARDAR REGISTRO";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Tomato;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Location = new System.Drawing.Point(384, 337);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 36);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tomato;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(553, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 36);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblGeneroDatos
            // 
            this.lblGeneroDatos.AutoSize = true;
            this.lblGeneroDatos.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblGeneroDatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGeneroDatos.Location = new System.Drawing.Point(518, 73);
            this.lblGeneroDatos.Name = "lblGeneroDatos";
            this.lblGeneroDatos.Size = new System.Drawing.Size(63, 19);
            this.lblGeneroDatos.TabIndex = 16;
            this.lblGeneroDatos.Text = "Género";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rbtnFemenino.Location = new System.Drawing.Point(592, 74);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(80, 19);
            this.rbtnFemenino.TabIndex = 17;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            this.rbtnFemenino.CheckedChanged += new System.EventHandler(this.rbtnFemenino_CheckedChanged);
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rbtnMasculino.Location = new System.Drawing.Point(592, 97);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(84, 19);
            this.rbtnMasculino.TabIndex = 18;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            this.rbtnMasculino.CheckedChanged += new System.EventHandler(this.rbtnMasculino_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(63, 408);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 14);
            this.lblFecha.TabIndex = 19;
            // 
            // timerNomina
            // 
            this.timerNomina.Enabled = true;
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.lblGeneroDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbmCargo);
            this.Controls.Add(this.txtDiasLaborados);
            this.Controls.Add(this.txtSalarioDia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDiasL);
            this.Controls.Add(this.lblSalarioDia);
            this.Controls.Add(this.lblIdentificacion);
            this.Name = "FrmDatos";
            this.Text = "FrmDatos";
            this.Load += new System.EventHandler(this.FrmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblSalarioDia;
        private System.Windows.Forms.Label lblDiasL;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCargo;
        public System.Windows.Forms.TextBox txtIdentificacion;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtSalarioDia;
        public System.Windows.Forms.TextBox txtDiasLaborados;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCalcular;
        public System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblGeneroDatos;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        public System.Windows.Forms.RadioButton rbtnMasculino;
        public System.Windows.Forms.ComboBox cbmCargo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timerNomina;
    }
}