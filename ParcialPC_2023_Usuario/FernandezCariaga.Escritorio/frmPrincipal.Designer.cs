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
            btnAdminUsers = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 54);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO AL FORMULARIO PRINCIPAL";
            // 
            // btnAdminUsers
            // 
            btnAdminUsers.Location = new Point(92, 122);
            btnAdminUsers.Name = "btnAdminUsers";
            btnAdminUsers.Size = new Size(173, 65);
            btnAdminUsers.TabIndex = 1;
            btnAdminUsers.Text = "Administrar Usuarios";
            btnAdminUsers.UseVisualStyleBackColor = true;
            btnAdminUsers.Click += btnAdminUsers_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 262);
            Controls.Add(btnAdminUsers);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdminUsers;
    }
}