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
            this.SuspendLayout();
            // 
            // lblAdminNombre
            // 
            this.lblAdminNombre.AutoSize = true;
            this.lblAdminNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNombre.Location = new System.Drawing.Point(36, 86);
            this.lblAdminNombre.Name = "lblAdminNombre";
            this.lblAdminNombre.Size = new System.Drawing.Size(212, 25);
            this.lblAdminNombre.TabIndex = 0;
            this.lblAdminNombre.Text = "Bienvenido: [$Nombre]";
            // 
            // lblAdminRUT
            // 
            this.lblAdminRUT.AutoSize = true;
            this.lblAdminRUT.Location = new System.Drawing.Point(117, 128);
            this.lblAdminRUT.Name = "lblAdminRUT";
            this.lblAdminRUT.Size = new System.Drawing.Size(42, 13);
            this.lblAdminRUT.TabIndex = 1;
            this.lblAdminRUT.Text = "[$RUT]";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAdminRUT);
            this.Controls.Add(this.lblAdminNombre);
            this.Name = "FormAdmin";
            this.Text = "Menu Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminNombre;
        private System.Windows.Forms.Label lblAdminRUT;
    }
}