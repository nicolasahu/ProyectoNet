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
            this.lblClienteRUT = new System.Windows.Forms.Label();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClienteRUT
            // 
            this.lblClienteRUT.AutoSize = true;
            this.lblClienteRUT.Location = new System.Drawing.Point(117, 145);
            this.lblClienteRUT.Name = "lblClienteRUT";
            this.lblClienteRUT.Size = new System.Drawing.Size(42, 13);
            this.lblClienteRUT.TabIndex = 3;
            this.lblClienteRUT.Text = "[$RUT]";
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(36, 103);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(212, 25);
            this.lblClienteNombre.TabIndex = 2;
            this.lblClienteNombre.Text = "Bienvenido: [$Nombre]";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblClienteRUT);
            this.Controls.Add(this.lblClienteNombre);
            this.Name = "FormCliente";
            this.Text = "Menu Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClienteRUT;
        private System.Windows.Forms.Label lblClienteNombre;
    }
}