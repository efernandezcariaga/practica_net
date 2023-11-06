namespace FernandezCariaga.Escritorio
{
    partial class frmPrincipal
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
            label1 = new Label();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 69);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 1;
            label1.Text = "BIENVENIDO AL FORMULARIO PRINCIPAL";
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(60, 127);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(268, 96);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "ADMINISTRADOR DE CLIENTES";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click_1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 273);
            Controls.Add(btnAdmin);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdmin;
    }
}