namespace proyectoBanco
{
    partial class RegistroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtCrearCliente_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCrearCliente_RUT = new System.Windows.Forms.TextBox();
            this.txtCrearCliente_Nombre = new System.Windows.Forms.TextBox();
            this.txtCrearCliente_Apellido = new System.Windows.Forms.TextBox();
            this.txtCrearCliente_Direccion = new System.Windows.Forms.TextBox();
            this.txtCrearCliente_Correo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboCrearCliente_Ciudad = new System.Windows.Forms.ComboBox();
            this.errorRegistroCliente = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ciudad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo Electronico:";
            // 
            // dtCrearCliente_Nacimiento
            // 
            this.dtCrearCliente_Nacimiento.Location = new System.Drawing.Point(127, 176);
            this.dtCrearCliente_Nacimiento.Name = "dtCrearCliente_Nacimiento";
            this.dtCrearCliente_Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtCrearCliente_Nacimiento.TabIndex = 6;
            // 
            // txtCrearCliente_RUT
            // 
            this.txtCrearCliente_RUT.Location = new System.Drawing.Point(127, 9);
            this.txtCrearCliente_RUT.Name = "txtCrearCliente_RUT";
            this.txtCrearCliente_RUT.Size = new System.Drawing.Size(176, 20);
            this.txtCrearCliente_RUT.TabIndex = 7;
            this.txtCrearCliente_RUT.Validated += new System.EventHandler(this.txtCrearCliente_RUT_Validated);
            // 
            // txtCrearCliente_Nombre
            // 
            this.txtCrearCliente_Nombre.Location = new System.Drawing.Point(127, 35);
            this.txtCrearCliente_Nombre.Name = "txtCrearCliente_Nombre";
            this.txtCrearCliente_Nombre.Size = new System.Drawing.Size(176, 20);
            this.txtCrearCliente_Nombre.TabIndex = 8;
            // 
            // txtCrearCliente_Apellido
            // 
            this.txtCrearCliente_Apellido.Location = new System.Drawing.Point(127, 61);
            this.txtCrearCliente_Apellido.Name = "txtCrearCliente_Apellido";
            this.txtCrearCliente_Apellido.Size = new System.Drawing.Size(176, 20);
            this.txtCrearCliente_Apellido.TabIndex = 9;
            // 
            // txtCrearCliente_Direccion
            // 
            this.txtCrearCliente_Direccion.Location = new System.Drawing.Point(127, 89);
            this.txtCrearCliente_Direccion.Name = "txtCrearCliente_Direccion";
            this.txtCrearCliente_Direccion.Size = new System.Drawing.Size(176, 20);
            this.txtCrearCliente_Direccion.TabIndex = 10;
            // 
            // txtCrearCliente_Correo
            // 
            this.txtCrearCliente_Correo.Location = new System.Drawing.Point(127, 141);
            this.txtCrearCliente_Correo.Name = "txtCrearCliente_Correo";
            this.txtCrearCliente_Correo.Size = new System.Drawing.Size(176, 20);
            this.txtCrearCliente_Correo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de nacimiento:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboCrearCliente_Ciudad
            // 
            this.cboCrearCliente_Ciudad.FormattingEnabled = true;
            this.cboCrearCliente_Ciudad.Location = new System.Drawing.Point(127, 115);
            this.cboCrearCliente_Ciudad.Name = "cboCrearCliente_Ciudad";
            this.cboCrearCliente_Ciudad.Size = new System.Drawing.Size(176, 21);
            this.cboCrearCliente_Ciudad.TabIndex = 15;
            // 
            // errorRegistroCliente
            // 
            this.errorRegistroCliente.ContainerControl = this;
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 257);
            this.Controls.Add(this.cboCrearCliente_Ciudad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCrearCliente_Correo);
            this.Controls.Add(this.txtCrearCliente_Direccion);
            this.Controls.Add(this.txtCrearCliente_Apellido);
            this.Controls.Add(this.txtCrearCliente_Nombre);
            this.Controls.Add(this.txtCrearCliente_RUT);
            this.Controls.Add(this.dtCrearCliente_Nacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroCliente";
            this.Text = "RegistroCliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistroCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtCrearCliente_Nacimiento;
        private System.Windows.Forms.TextBox txtCrearCliente_RUT;
        private System.Windows.Forms.TextBox txtCrearCliente_Nombre;
        private System.Windows.Forms.TextBox txtCrearCliente_Apellido;
        private System.Windows.Forms.TextBox txtCrearCliente_Direccion;
        private System.Windows.Forms.TextBox txtCrearCliente_Correo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboCrearCliente_Ciudad;
        private System.Windows.Forms.ErrorProvider errorRegistroCliente;
    }
}