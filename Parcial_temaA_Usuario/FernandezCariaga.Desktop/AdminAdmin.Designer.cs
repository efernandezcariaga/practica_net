namespace FernandezCariaga.Desktop
{
    partial class AdminAdmin
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
            btn_admUsers = new Button();
            lbl_welcome = new Label();
            SuspendLayout();
            // 
            // btn_admUsers
            // 
            btn_admUsers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_admUsers.Location = new Point(83, 112);
            btn_admUsers.Name = "btn_admUsers";
            btn_admUsers.Size = new Size(125, 62);
            btn_admUsers.TabIndex = 0;
            btn_admUsers.Text = "Administrar usuarios";
            btn_admUsers.UseVisualStyleBackColor = true;
            btn_admUsers.Click += btn_admUsers_Click;
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_welcome.Location = new Point(12, 62);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(264, 17);
            lbl_welcome.TabIndex = 1;
            lbl_welcome.Text = "Bienvenido al administrador del proyecto";
            // 
            // AdminAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 215);
            Controls.Add(lbl_welcome);
            Controls.Add(btn_admUsers);
            Name = "AdminAdmin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_admUsers;
        private Label lbl_welcome;
    }
}