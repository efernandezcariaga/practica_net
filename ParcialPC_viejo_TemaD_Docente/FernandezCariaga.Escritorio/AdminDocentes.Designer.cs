namespace FernandezCariaga.Escritorio
{
    partial class AdminDocentes
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
            label1 = new Label();
            btnBuscar = new Button();
            dgvDocentes = new DataGridView();
            Antiguedad = new DataGridViewTextBoxColumn();
            ApellidoNombre = new DataGridViewTextBoxColumn();
            CUIL = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            FechaIngreso = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            label2 = new Label();
            txtApellidoNombre = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtFechaIngreso = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtSalario = new TextBox();
            btnCargar = new Button();
            btnAdd = new Button();
            btnCancel = new Button();
            txtCuil = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(271, 15);
            label1.TabIndex = 0;
            label1.Text = "INGRESAR CUIL DE DOCENTE QUE DESEA BUSCAR";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(657, 37);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvDocentes
            // 
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Columns.AddRange(new DataGridViewColumn[] { Antiguedad, ApellidoNombre, CUIL, Email, FechaIngreso, Id, Salario });
            dgvDocentes.Location = new Point(12, 66);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowTemplate.Height = 25;
            dgvDocentes.Size = new Size(720, 150);
            dgvDocentes.TabIndex = 2;
            // 
            // Antiguedad
            // 
            Antiguedad.DataPropertyName = "Antiguedad";
            Antiguedad.HeaderText = "Antiguedad";
            Antiguedad.Name = "Antiguedad";
            Antiguedad.ReadOnly = true;
            // 
            // ApellidoNombre
            // 
            ApellidoNombre.DataPropertyName = "ApellidoNombre";
            ApellidoNombre.HeaderText = "ApellidoNombre";
            ApellidoNombre.Name = "ApellidoNombre";
            // 
            // CUIL
            // 
            CUIL.DataPropertyName = "CUIL";
            CUIL.HeaderText = "CUIL";
            CUIL.Name = "CUIL";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // FechaIngreso
            // 
            FechaIngreso.DataPropertyName = "FechaIngreso";
            FechaIngreso.HeaderText = "FechaIngreso";
            FechaIngreso.Name = "FechaIngreso";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Salario
            // 
            Salario.DataPropertyName = "Salario";
            Salario.HeaderText = "Salario";
            Salario.Name = "Salario";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 37);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(639, 23);
            txtBuscar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 237);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "ApellidoNombre";
            // 
            // txtApellidoNombre
            // 
            txtApellidoNombre.Location = new Point(113, 234);
            txtApellidoNombre.Name = "txtApellidoNombre";
            txtApellidoNombre.Size = new Size(185, 23);
            txtApellidoNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 307);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 304);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 23);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 351);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 8;
            label4.Text = "FechaIngreso";
            // 
            // txtFechaIngreso
            // 
            txtFechaIngreso.Location = new Point(113, 343);
            txtFechaIngreso.Name = "txtFechaIngreso";
            txtFechaIngreso.Size = new Size(185, 23);
            txtFechaIngreso.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 386);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 10;
            label5.Text = "Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 427);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Salario";
            // 
            // txtId
            // 
            txtId.Location = new Point(113, 383);
            txtId.Name = "txtId";
            txtId.Size = new Size(185, 23);
            txtId.TabIndex = 12;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(113, 419);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(185, 23);
            txtSalario.TabIndex = 13;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(591, 224);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(141, 40);
            btnCargar.TabIndex = 14;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(591, 272);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "AGREGAR";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(657, 423);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(113, 272);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(185, 23);
            txtCuil.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 275);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 17;
            label7.Text = "CUIL";
            // 
            // AdminDocentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 455);
            Controls.Add(txtCuil);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(btnCargar);
            Controls.Add(txtSalario);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtFechaIngreso);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtApellidoNombre);
            Controls.Add(label2);
            Controls.Add(txtBuscar);
            Controls.Add(dgvDocentes);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Name = "AdminDocentes";
            Text = "AdminDocentes";
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBuscar;
        private DataGridView dgvDocentes;
        private TextBox txtBuscar;
        private Label label2;
        private TextBox txtApellidoNombre;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtFechaIngreso;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtSalario;
        private Button btnCargar;
        private Button btnAdd;
        private Button btnCancel;
        private DataGridViewTextBoxColumn Antiguedad;
        private DataGridViewTextBoxColumn ApellidoNombre;
        private DataGridViewTextBoxColumn CUIL;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Salario;
        private TextBox txtCuil;
        private Label label7;
    }
}