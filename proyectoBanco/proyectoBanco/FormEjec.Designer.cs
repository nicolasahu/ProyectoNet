namespace proyectoBanco
{
    partial class FormEjec
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
            this.lblEjecRUT = new System.Windows.Forms.Label();
            this.lblEjecNombre = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridCuentasAdjudicadas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMonto_AprobarCredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridCreditosAprobados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridClientesDisponibles = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuentasAdjudicadas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCreditosAprobados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEjecRUT
            // 
            this.lblEjecRUT.AutoSize = true;
            this.lblEjecRUT.Location = new System.Drawing.Point(405, 21);
            this.lblEjecRUT.Name = "lblEjecRUT";
            this.lblEjecRUT.Size = new System.Drawing.Size(42, 13);
            this.lblEjecRUT.TabIndex = 3;
            this.lblEjecRUT.Text = "[$RUT]";
            // 
            // lblEjecNombre
            // 
            this.lblEjecNombre.AutoSize = true;
            this.lblEjecNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjecNombre.Location = new System.Drawing.Point(12, 9);
            this.lblEjecNombre.Name = "lblEjecNombre";
            this.lblEjecNombre.Size = new System.Drawing.Size(212, 25);
            this.lblEjecNombre.TabIndex = 2;
            this.lblEjecNombre.Text = "Bienvenido: [$Nombre]";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 374);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridCuentasAdjudicadas);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Creditos de Consumo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridCuentasAdjudicadas
            // 
            this.gridCuentasAdjudicadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCuentasAdjudicadas.Location = new System.Drawing.Point(120, 12);
            this.gridCuentasAdjudicadas.MultiSelect = false;
            this.gridCuentasAdjudicadas.Name = "gridCuentasAdjudicadas";
            this.gridCuentasAdjudicadas.ReadOnly = true;
            this.gridCuentasAdjudicadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCuentasAdjudicadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCuentasAdjudicadas.Size = new System.Drawing.Size(360, 114);
            this.gridCuentasAdjudicadas.TabIndex = 9;
            this.gridCuentasAdjudicadas.Click += new System.EventHandler(this.gridCuentasAdjudicadas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMonto_AprobarCredito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gridCreditosAprobados);
            this.groupBox1.Location = new System.Drawing.Point(9, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 210);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creditos Aprobados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Nuevo Credito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMonto_AprobarCredito
            // 
            this.txtMonto_AprobarCredito.Location = new System.Drawing.Point(49, 32);
            this.txtMonto_AprobarCredito.Name = "txtMonto_AprobarCredito";
            this.txtMonto_AprobarCredito.Size = new System.Drawing.Size(86, 20);
            this.txtMonto_AprobarCredito.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Monto";
            // 
            // gridCreditosAprobados
            // 
            this.gridCreditosAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCreditosAprobados.Location = new System.Drawing.Point(141, 32);
            this.gridCreditosAprobados.MultiSelect = false;
            this.gridCreditosAprobados.Name = "gridCreditosAprobados";
            this.gridCreditosAprobados.ReadOnly = true;
            this.gridCreditosAprobados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCreditosAprobados.Size = new System.Drawing.Size(330, 161);
            this.gridCreditosAprobados.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione cuenta:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridClientesDisponibles);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear Cuenta Corriente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(448, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Adjudicar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clientes Disponibles:";
            // 
            // gridClientesDisponibles
            // 
            this.gridClientesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientesDisponibles.Location = new System.Drawing.Point(20, 47);
            this.gridClientesDisponibles.MultiSelect = false;
            this.gridClientesDisponibles.Name = "gridClientesDisponibles";
            this.gridClientesDisponibles.ReadOnly = true;
            this.gridClientesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientesDisponibles.Size = new System.Drawing.Size(448, 227);
            this.gridClientesDisponibles.TabIndex = 3;
            // 
            // FormEjec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 432);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblEjecRUT);
            this.Controls.Add(this.lblEjecNombre);
            this.Name = "FormEjec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Ejecutivo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuentasAdjudicadas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCreditosAprobados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjecRUT;
        private System.Windows.Forms.Label lblEjecNombre;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridCreditosAprobados;
        private System.Windows.Forms.TextBox txtMonto_AprobarCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridCuentasAdjudicadas;
        private System.Windows.Forms.DataGridView gridClientesDisponibles;
    }
}