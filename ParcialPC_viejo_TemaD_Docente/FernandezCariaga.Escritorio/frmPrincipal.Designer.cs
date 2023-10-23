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
            btnAdminDocentes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 74);
            label1.Name = "label1";
            label1.Size = new Size(265, 15);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO AL ADMINISTRADOR DE DOCENTES";
            // 
            // btnAdminDocentes
            // 
            btnAdminDocentes.Location = new Point(60, 127);
            btnAdminDocentes.Name = "btnAdminDocentes";
            btnAdminDocentes.Size = new Size(265, 108);
            btnAdminDocentes.TabIndex = 1;
            btnAdminDocentes.Text = "ADMINISTRAR DOCENTES";
            btnAdminDocentes.UseVisualStyleBackColor = true;
            btnAdminDocentes.Click += btnAdminDocentes_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 337);
            Controls.Add(btnAdminDocentes);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdminDocentes;
    }
}