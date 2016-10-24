namespace proyectoBanco
{
    partial class FormCliente
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
            this.lblClienteRUT = new System.Windows.Forms.Label();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateHistoricoHasta = new System.Windows.Forms.DateTimePicker();
            this.dateHistoricoDesde = new System.Windows.Forms.DateTimePicker();
            this.gridHistorico = new System.Windows.Forms.DataGridView();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Transferencia = new System.Windows.Forms.TabPage();
            this.btnRealizarTransferencia = new System.Windows.Forms.Button();
            this.txtCodigoTransferencia3 = new System.Windows.Forms.TextBox();
            this.txtCodigoTransferencia2 = new System.Windows.Forms.TextBox();
            this.txtCodigoTransferencia1 = new System.Windows.Forms.TextBox();
            this.lblCodigo3 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComentarioTransferencia = new System.Windows.Forms.TextBox();
            this.txtMontoTransferencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumCuentaDestinatario = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.txtContraseñaConfirmar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorCambiarContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorico)).BeginInit();
            this.Transferencia.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCambiarContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClienteRUT
            // 
            this.lblClienteRUT.AutoSize = true;
            this.lblClienteRUT.Location = new System.Drawing.Point(498, 18);
            this.lblClienteRUT.Name = "lblClienteRUT";
            this.lblClienteRUT.Size = new System.Drawing.Size(42, 13);
            this.lblClienteRUT.TabIndex = 3;
            this.lblClienteRUT.Text = "[$RUT]";
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(12, 9);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(212, 25);
            this.lblClienteNombre.TabIndex = 2;
            this.lblClienteNombre.Text = "Bienvenido: [$Nombre]";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Transferencia);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 423);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dateHistoricoHasta);
            this.tabPage1.Controls.Add(this.dateHistoricoDesde);
            this.tabPage1.Controls.Add(this.gridHistorico);
            this.tabPage1.Controls.Add(this.txtSaldo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Historico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Desde";
            // 
            // dateHistoricoHasta
            // 
            this.dateHistoricoHasta.Location = new System.Drawing.Point(331, 40);
            this.dateHistoricoHasta.Name = "dateHistoricoHasta";
            this.dateHistoricoHasta.Size = new System.Drawing.Size(200, 20);
            this.dateHistoricoHasta.TabIndex = 27;
            // 
            // dateHistoricoDesde
            // 
            this.dateHistoricoDesde.Location = new System.Drawing.Point(60, 40);
            this.dateHistoricoDesde.Name = "dateHistoricoDesde";
            this.dateHistoricoDesde.Size = new System.Drawing.Size(200, 20);
            this.dateHistoricoDesde.TabIndex = 26;
            // 
            // gridHistorico
            // 
            this.gridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistorico.Location = new System.Drawing.Point(8, 72);
            this.gridHistorico.MultiSelect = false;
            this.gridHistorico.Name = "gridHistorico";
            this.gridHistorico.ReadOnly = true;
            this.gridHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHistorico.Size = new System.Drawing.Size(523, 308);
            this.gridHistorico.TabIndex = 25;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(60, 10);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(124, 20);
            this.txtSaldo.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Saldo:";
            // 
            // Transferencia
            // 
            this.Transferencia.Controls.Add(this.btnRealizarTransferencia);
            this.Transferencia.Controls.Add(this.txtCodigoTransferencia3);
            this.Transferencia.Controls.Add(this.txtCodigoTransferencia2);
            this.Transferencia.Controls.Add(this.txtCodigoTransferencia1);
            this.Transferencia.Controls.Add(this.lblCodigo3);
            this.Transferencia.Controls.Add(this.lblCodigo2);
            this.Transferencia.Controls.Add(this.lblCodigo1);
            this.Transferencia.Controls.Add(this.label7);
            this.Transferencia.Controls.Add(this.txtComentarioTransferencia);
            this.Transferencia.Controls.Add(this.txtMontoTransferencia);
            this.Transferencia.Controls.Add(this.label6);
            this.Transferencia.Controls.Add(this.label5);
            this.Transferencia.Controls.Add(this.label1);
            this.Transferencia.Controls.Add(this.txtNumCuentaDestinatario);
            this.Transferencia.Location = new System.Drawing.Point(4, 22);
            this.Transferencia.Name = "Transferencia";
            this.Transferencia.Padding = new System.Windows.Forms.Padding(3);
            this.Transferencia.Size = new System.Drawing.Size(539, 397);
            this.Transferencia.TabIndex = 1;
            this.Transferencia.Text = "Realizar transferencia";
            this.Transferencia.UseVisualStyleBackColor = true;
            // 
            // btnRealizarTransferencia
            // 
            this.btnRealizarTransferencia.Location = new System.Drawing.Point(97, 316);
            this.btnRealizarTransferencia.Name = "btnRealizarTransferencia";
            this.btnRealizarTransferencia.Size = new System.Drawing.Size(320, 23);
            this.btnRealizarTransferencia.TabIndex = 13;
            this.btnRealizarTransferencia.Text = "Realizar Transferencia";
            this.btnRealizarTransferencia.UseVisualStyleBackColor = true;
            this.btnRealizarTransferencia.Click += new System.EventHandler(this.btnRealizarTransferencia_Click);
            // 
            // txtCodigoTransferencia3
            // 
            this.txtCodigoTransferencia3.Location = new System.Drawing.Point(329, 252);
            this.txtCodigoTransferencia3.Name = "txtCodigoTransferencia3";
            this.txtCodigoTransferencia3.Size = new System.Drawing.Size(36, 20);
            this.txtCodigoTransferencia3.TabIndex = 12;
            // 
            // txtCodigoTransferencia2
            // 
            this.txtCodigoTransferencia2.Location = new System.Drawing.Point(226, 252);
            this.txtCodigoTransferencia2.Name = "txtCodigoTransferencia2";
            this.txtCodigoTransferencia2.Size = new System.Drawing.Size(36, 20);
            this.txtCodigoTransferencia2.TabIndex = 11;
            // 
            // txtCodigoTransferencia1
            // 
            this.txtCodigoTransferencia1.Location = new System.Drawing.Point(118, 252);
            this.txtCodigoTransferencia1.Name = "txtCodigoTransferencia1";
            this.txtCodigoTransferencia1.Size = new System.Drawing.Size(36, 20);
            this.txtCodigoTransferencia1.TabIndex = 10;
            // 
            // lblCodigo3
            // 
            this.lblCodigo3.AutoSize = true;
            this.lblCodigo3.Location = new System.Drawing.Point(336, 224);
            this.lblCodigo3.Name = "lblCodigo3";
            this.lblCodigo3.Size = new System.Drawing.Size(20, 13);
            this.lblCodigo3.TabIndex = 9;
            this.lblCodigo3.Text = "C6";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(233, 224);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(20, 13);
            this.lblCodigo2.TabIndex = 8;
            this.lblCodigo2.Text = "B4";
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(124, 224);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(20, 13);
            this.lblCodigo1.TabIndex = 7;
            this.lblCodigo1.Text = "A8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Codigo Transferencia:";
            // 
            // txtComentarioTransferencia
            // 
            this.txtComentarioTransferencia.Location = new System.Drawing.Point(197, 114);
            this.txtComentarioTransferencia.Name = "txtComentarioTransferencia";
            this.txtComentarioTransferencia.Size = new System.Drawing.Size(282, 20);
            this.txtComentarioTransferencia.TabIndex = 5;
            // 
            // txtMontoTransferencia
            // 
            this.txtMontoTransferencia.Location = new System.Drawing.Point(197, 73);
            this.txtMontoTransferencia.Name = "txtMontoTransferencia";
            this.txtMontoTransferencia.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTransferencia.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Comentario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Cuenta Destinatario:";
            // 
            // txtNumCuentaDestinatario
            // 
            this.txtNumCuentaDestinatario.Location = new System.Drawing.Point(197, 31);
            this.txtNumCuentaDestinatario.Name = "txtNumCuentaDestinatario";
            this.txtNumCuentaDestinatario.Size = new System.Drawing.Size(100, 20);
            this.txtNumCuentaDestinatario.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnCambiarContraseña);
            this.tabPage2.Controls.Add(this.txtContraseñaConfirmar);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtContraseñaNueva);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtContraseñaActual);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 397);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Cambiar contraseña";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(206, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Complete los campos:";
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(153, 250);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(218, 23);
            this.btnCambiarContraseña.TabIndex = 6;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // txtContraseñaConfirmar
            // 
            this.txtContraseñaConfirmar.Location = new System.Drawing.Point(271, 171);
            this.txtContraseñaConfirmar.Name = "txtContraseñaConfirmar";
            this.txtContraseñaConfirmar.PasswordChar = '*';
            this.txtContraseñaConfirmar.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaConfirmar.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Confirme Contraseña";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Location = new System.Drawing.Point(271, 133);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.PasswordChar = '*';
            this.txtContraseñaNueva.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaNueva.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nueva Contraseña";
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Location = new System.Drawing.Point(271, 97);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.PasswordChar = '*';
            this.txtContraseñaActual.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaActual.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Contraseña Actual";
            // 
            // errorCambiarContraseña
            // 
            this.errorCambiarContraseña.ContainerControl = this;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 481);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblClienteRUT);
            this.Controls.Add(this.lblClienteNombre);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Cliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorico)).EndInit();
            this.Transferencia.ResumeLayout(false);
            this.Transferencia.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCambiarContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClienteRUT;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Transferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateHistoricoHasta;
        private System.Windows.Forms.DateTimePicker dateHistoricoDesde;
        private System.Windows.Forms.DataGridView gridHistorico;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumCuentaDestinatario;
        private System.Windows.Forms.TextBox txtMontoTransferencia;
        private System.Windows.Forms.TextBox txtComentarioTransferencia;
        private System.Windows.Forms.Label lblCodigo3;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoTransferencia1;
        private System.Windows.Forms.TextBox txtCodigoTransferencia3;
        private System.Windows.Forms.TextBox txtCodigoTransferencia2;
        private System.Windows.Forms.Button btnRealizarTransferencia;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.TextBox txtContraseñaConfirmar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorCambiarContraseña;
    }
}