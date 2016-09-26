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
            this.SuspendLayout();
            // 
            // lblEjecRUT
            // 
            this.lblEjecRUT.AutoSize = true;
            this.lblEjecRUT.Location = new System.Drawing.Point(117, 145);
            this.lblEjecRUT.Name = "lblEjecRUT";
            this.lblEjecRUT.Size = new System.Drawing.Size(42, 13);
            this.lblEjecRUT.TabIndex = 3;
            this.lblEjecRUT.Text = "[$RUT]";
            // 
            // lblEjecNombre
            // 
            this.lblEjecNombre.AutoSize = true;
            this.lblEjecNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjecNombre.Location = new System.Drawing.Point(36, 103);
            this.lblEjecNombre.Name = "lblEjecNombre";
            this.lblEjecNombre.Size = new System.Drawing.Size(212, 25);
            this.lblEjecNombre.TabIndex = 2;
            this.lblEjecNombre.Text = "Bienvenido: [$Nombre]";
            // 
            // FormEjec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblEjecRUT);
            this.Controls.Add(this.lblEjecNombre);
            this.Name = "FormEjec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Ejecutivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjecRUT;
        private System.Windows.Forms.Label lblEjecNombre;
    }
}