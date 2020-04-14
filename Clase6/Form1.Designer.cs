namespace Clase6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.chkArgentino = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.otro = new System.Windows.Forms.RadioButton();
            this.Femenino = new System.Windows.Forms.RadioButton();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.grbVive = new System.Windows.Forms.GroupBox();
            this.Si = new System.Windows.Forms.RadioButton();
            this.No = new System.Windows.Forms.RadioButton();
            this.lstViveCon = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grbGenero.SuspendLayout();
            this.grbVive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 428);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(489, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(108, 78);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '0';
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(48, 81);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(108, 108);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 9;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(48, 111);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "DNI";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(410, 59);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(35, 13);
            this.lblSalida.TabIndex = 10;
            this.lblSalida.Text = "label1";
            // 
            // chkArgentino
            // 
            this.chkArgentino.AutoSize = true;
            this.chkArgentino.Checked = true;
            this.chkArgentino.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkArgentino.Location = new System.Drawing.Point(51, 150);
            this.chkArgentino.Name = "chkArgentino";
            this.chkArgentino.Size = new System.Drawing.Size(98, 17);
            this.chkArgentino.TabIndex = 11;
            this.chkArgentino.Text = "¿Es Argentino?";
            this.chkArgentino.ThreeState = true;
            this.chkArgentino.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(184, 150);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(174, 182);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(115, 20);
            this.dtpFechaNac.TabIndex = 13;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(51, 188);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblNacimiento.TabIndex = 14;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.otro);
            this.grbGenero.Controls.Add(this.Femenino);
            this.grbGenero.Controls.Add(this.Masculino);
            this.grbGenero.Location = new System.Drawing.Point(31, 218);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(331, 56);
            this.grbGenero.TabIndex = 18;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Genero";
            // 
            // otro
            // 
            this.otro.AutoSize = true;
            this.otro.Location = new System.Drawing.Point(235, 19);
            this.otro.Name = "otro";
            this.otro.Size = new System.Drawing.Size(45, 17);
            this.otro.TabIndex = 20;
            this.otro.Text = "Otro";
            this.otro.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            this.Femenino.AutoSize = true;
            this.Femenino.Location = new System.Drawing.Point(113, 20);
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(71, 17);
            this.Femenino.TabIndex = 19;
            this.Femenino.Text = "Femenino";
            this.Femenino.UseVisualStyleBackColor = true;
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Checked = true;
            this.Masculino.Location = new System.Drawing.Point(10, 20);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(73, 17);
            this.Masculino.TabIndex = 18;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // grbVive
            // 
            this.grbVive.Controls.Add(this.No);
            this.grbVive.Controls.Add(this.Si);
            this.grbVive.Location = new System.Drawing.Point(39, 286);
            this.grbVive.Name = "grbVive";
            this.grbVive.Size = new System.Drawing.Size(323, 45);
            this.grbVive.TabIndex = 19;
            this.grbVive.TabStop = false;
            this.grbVive.Text = "groupBox2";
            // 
            // Si
            // 
            this.Si.AutoSize = true;
            this.Si.Location = new System.Drawing.Point(35, 19);
            this.Si.Name = "Si";
            this.Si.Size = new System.Drawing.Size(85, 17);
            this.Si.TabIndex = 0;
            this.Si.TabStop = true;
            this.Si.Text = "radioButton4";
            this.Si.UseVisualStyleBackColor = true;
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(165, 19);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(85, 17);
            this.No.TabIndex = 1;
            this.No.TabStop = true;
            this.No.Text = "radioButton5";
            this.No.UseVisualStyleBackColor = true;
            // 
            // lstViveCon
            // 
            this.lstViveCon.FormattingEnabled = true;
            this.lstViveCon.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Abuelo",
            "Abuela",
            "Hijo",
            "Hija",
            "Hermana",
            "Hermano",
            "Otro"});
            this.lstViveCon.Location = new System.Drawing.Point(427, 184);
            this.lstViveCon.Name = "lstViveCon";
            this.lstViveCon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstViveCon.Size = new System.Drawing.Size(120, 147);
            this.lstViveCon.TabIndex = 20;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(41, 351);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "CABA",
            "Buenos Aires",
            "La Pampa",
            "Santa Fe",
            "Entre Rios",
            "Cordoba"});
            this.cmbProvincia.Location = new System.Drawing.Point(464, 28);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 22;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(328, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 463);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lstViveCon);
            this.Controls.Add(this.grbVive);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chkArgentino);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grbVive.ResumeLayout(false);
            this.grbVive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.CheckBox chkArgentino;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.RadioButton otro;
        private System.Windows.Forms.RadioButton Femenino;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.GroupBox grbVive;
        private System.Windows.Forms.RadioButton No;
        private System.Windows.Forms.RadioButton Si;
        private System.Windows.Forms.ListBox lstViveCon;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

