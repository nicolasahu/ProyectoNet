namespace proyectoBanco
{
    partial class FormAdmin
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
            this.lblAdminNombre = new System.Windows.Forms.Label();
            this.lblAdminRUT = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.btnCiudadCancelar = new System.Windows.Forms.Button();
            this.btnCiudadActualizar = new System.Windows.Forms.Button();
            this.btnCiudadCrear = new System.Windows.Forms.Button();
            this.gridCiudad = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEjecutivoApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEjecutivoRut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEjecutivoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEjecutivoCancelar = new System.Windows.Forms.Button();
            this.btnEjecutivoActualizar = new System.Windows.Forms.Button();
            this.btnEjecutivoCrear = new System.Windows.Forms.Button();
            this.gridEjecutivo = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCiudad)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEjecutivo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminNombre
            // 
            this.lblAdminNombre.AutoSize = true;
            this.lblAdminNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNombre.Location = new System.Drawing.Point(12, 9);
            this.lblAdminNombre.Name = "lblAdminNombre";
            this.lblAdminNombre.Size = new System.Drawing.Size(212, 25);
            this.lblAdminNombre.TabIndex = 0;
            this.lblAdminNombre.Text = "Bienvenido: [$Nombre]";
            this.lblAdminNombre.Click += new System.EventHandler(this.lblAdminNombre_Click);
            // 
            // lblAdminRUT
            // 
            this.lblAdminRUT.AutoSize = true;
            this.lblAdminRUT.Location = new System.Drawing.Point(477, 21);
            this.lblAdminRUT.Name = "lblAdminRUT";
            this.lblAdminRUT.Size = new System.Drawing.Size(42, 13);
            this.lblAdminRUT.TabIndex = 1;
            this.lblAdminRUT.Text = "[$RUT]";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(17, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(526, 279);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNombreCiudad);
            this.tabPage1.Controls.Add(this.btnCiudadCancelar);
            this.tabPage1.Controls.Add(this.btnCiudadActualizar);
            this.tabPage1.Controls.Add(this.btnCiudadCrear);
            this.tabPage1.Controls.Add(this.gridCiudad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(518, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ciudades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre Ciudad: ";
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Location = new System.Drawing.Point(103, 8);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCiudad.TabIndex = 8;
            // 
            // btnCiudadCancelar
            // 
            this.btnCiudadCancelar.Enabled = false;
            this.btnCiudadCancelar.Location = new System.Drawing.Point(437, 224);
            this.btnCiudadCancelar.Name = "btnCiudadCancelar";
            this.btnCiudadCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCiudadCancelar.TabIndex = 7;
            this.btnCiudadCancelar.Text = "Cancelar";
            this.btnCiudadCancelar.UseVisualStyleBackColor = true;
            this.btnCiudadCancelar.Click += new System.EventHandler(this.btnCiudadCancelar_Click);
            // 
            // btnCiudadActualizar
            // 
            this.btnCiudadActualizar.Enabled = false;
            this.btnCiudadActualizar.Location = new System.Drawing.Point(437, 35);
            this.btnCiudadActualizar.Name = "btnCiudadActualizar";
            this.btnCiudadActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnCiudadActualizar.TabIndex = 5;
            this.btnCiudadActualizar.Text = "Actualizar";
            this.btnCiudadActualizar.UseVisualStyleBackColor = true;
            this.btnCiudadActualizar.Click += new System.EventHandler(this.btnCiudadActualizar_Click);
            // 
            // btnCiudadCrear
            // 
            this.btnCiudadCrear.Location = new System.Drawing.Point(437, 6);
            this.btnCiudadCrear.Name = "btnCiudadCrear";
            this.btnCiudadCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCiudadCrear.TabIndex = 4;
            this.btnCiudadCrear.Text = "Crear";
            this.btnCiudadCrear.UseVisualStyleBackColor = true;
            this.btnCiudadCrear.Click += new System.EventHandler(this.btnCiudadCrear_Click);
            // 
            // gridCiudad
            // 
            this.gridCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCiudad.Location = new System.Drawing.Point(3, 35);
            this.gridCiudad.MultiSelect = false;
            this.gridCiudad.Name = "gridCiudad";
            this.gridCiudad.ReadOnly = true;
            this.gridCiudad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCiudad.Size = new System.Drawing.Size(428, 212);
            this.gridCiudad.TabIndex = 0;
            this.gridCiudad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCiudad_CellContentClick);
            this.gridCiudad.DoubleClick += new System.EventHandler(this.gridCiudad_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtEjecutivoApellido);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtEjecutivoRut);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtEjecutivoNombre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnEjecutivoCancelar);
            this.tabPage2.Controls.Add(this.btnEjecutivoActualizar);
            this.tabPage2.Controls.Add(this.btnEjecutivoCrear);
            this.tabPage2.Controls.Add(this.gridEjecutivo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(518, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ejecutivos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtEjecutivoApellido
            // 
            this.txtEjecutivoApellido.Location = new System.Drawing.Point(291, 8);
            this.txtEjecutivoApellido.Name = "txtEjecutivoApellido";
            this.txtEjecutivoApellido.Size = new System.Drawing.Size(100, 20);
            this.txtEjecutivoApellido.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Apellido:";
            // 
            // txtEjecutivoRut
            // 
            this.txtEjecutivoRut.Location = new System.Drawing.Point(88, 35);
            this.txtEjecutivoRut.Name = "txtEjecutivoRut";
            this.txtEjecutivoRut.Size = new System.Drawing.Size(100, 20);
            this.txtEjecutivoRut.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rut:";
            // 
            // txtEjecutivoNombre
            // 
            this.txtEjecutivoNombre.Location = new System.Drawing.Point(88, 8);
            this.txtEjecutivoNombre.Name = "txtEjecutivoNombre";
            this.txtEjecutivoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtEjecutivoNombre.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // btnEjecutivoCancelar
            // 
            this.btnEjecutivoCancelar.Enabled = false;
            this.btnEjecutivoCancelar.Location = new System.Drawing.Point(437, 224);
            this.btnEjecutivoCancelar.Name = "btnEjecutivoCancelar";
            this.btnEjecutivoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutivoCancelar.TabIndex = 12;
            this.btnEjecutivoCancelar.Text = "Cancelar";
            this.btnEjecutivoCancelar.UseVisualStyleBackColor = true;
            this.btnEjecutivoCancelar.Click += new System.EventHandler(this.btnEjecutivoCancelar_Click);
            // 
            // btnEjecutivoActualizar
            // 
            this.btnEjecutivoActualizar.Enabled = false;
            this.btnEjecutivoActualizar.Location = new System.Drawing.Point(437, 35);
            this.btnEjecutivoActualizar.Name = "btnEjecutivoActualizar";
            this.btnEjecutivoActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutivoActualizar.TabIndex = 10;
            this.btnEjecutivoActualizar.Text = "Actualizar";
            this.btnEjecutivoActualizar.UseVisualStyleBackColor = true;
            this.btnEjecutivoActualizar.Click += new System.EventHandler(this.btnEjecutivoActualizar_Click);
            // 
            // btnEjecutivoCrear
            // 
            this.btnEjecutivoCrear.Location = new System.Drawing.Point(437, 6);
            this.btnEjecutivoCrear.Name = "btnEjecutivoCrear";
            this.btnEjecutivoCrear.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutivoCrear.TabIndex = 9;
            this.btnEjecutivoCrear.Text = "Crear";
            this.btnEjecutivoCrear.UseVisualStyleBackColor = true;
            this.btnEjecutivoCrear.Click += new System.EventHandler(this.btnEjecutivoCrear_Click);
            // 
            // gridEjecutivo
            // 
            this.gridEjecutivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEjecutivo.Location = new System.Drawing.Point(6, 64);
            this.gridEjecutivo.Name = "gridEjecutivo";
            this.gridEjecutivo.ReadOnly = true;
            this.gridEjecutivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEjecutivo.Size = new System.Drawing.Size(425, 183);
            this.gridEjecutivo.TabIndex = 8;
            this.gridEjecutivo.DoubleClick += new System.EventHandler(this.gridEjecutivo_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(518, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estadisticas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 340);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblAdminRUT);
            this.Controls.Add(this.lblAdminNombre);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Administrador";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCiudad)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEjecutivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminNombre;
        private System.Windows.Forms.Label lblAdminRUT;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridCiudad;
        private System.Windows.Forms.Button btnCiudadCancelar;
        private System.Windows.Forms.Button btnCiudadActualizar;
        private System.Windows.Forms.Button btnCiudadCrear;
        private System.Windows.Forms.Button btnEjecutivoCancelar;
        private System.Windows.Forms.Button btnEjecutivoActualizar;
        private System.Windows.Forms.Button btnEjecutivoCrear;
        private System.Windows.Forms.DataGridView gridEjecutivo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.TextBox txtEjecutivoRut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEjecutivoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEjecutivoApellido;
        private System.Windows.Forms.Label label4;
    }
}