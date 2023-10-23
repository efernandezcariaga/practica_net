namespace FernandezCariaga.Escritorio
{
    partial class AdminUsers
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
            dgvUsuarios = new DataGridView();
            Clave = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            TipoUsuario = new DataGridViewTextBoxColumn();
            UltimoIngreso = new DataGridViewTextBoxColumn();
            lblClave = new Label();
            lblEmail = new Label();
            lblNombreUsuario = new Label();
            lblTipoUsuario = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            txtClave = new TextBox();
            txtEmail = new TextBox();
            txtNombreUsuario = new TextBox();
            txtTipoUsuario = new TextBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Clave, Email, NombreUsuario, TipoUsuario, UltimoIngreso });
            dgvUsuarios.Location = new Point(12, 66);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(547, 151);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // Clave
            // 
            Clave.DataPropertyName = "Clave";
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            // 
            // TipoUsuario
            // 
            TipoUsuario.DataPropertyName = "TipoUsuario";
            TipoUsuario.HeaderText = "TipoUsuario";
            TipoUsuario.Name = "TipoUsuario";
            // 
            // UltimoIngreso
            // 
            UltimoIngreso.DataPropertyName = "UltimoIngreso";
            UltimoIngreso.HeaderText = "UltimoIngreso";
            UltimoIngreso.Name = "UltimoIngreso";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(19, 234);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 1;
            lblClave.Text = "Clave";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(19, 270);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(19, 305);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(91, 15);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "NombreUsuario";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(19, 343);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(70, 15);
            lblTipoUsuario.TabIndex = 4;
            lblTipoUsuario.Text = "TipoUsuario";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(400, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(481, 263);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(439, 298);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(481, 343);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(131, 231);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 267);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(131, 302);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 11;
            // 
            // txtTipoUsuario
            // 
            txtTipoUsuario.Location = new Point(131, 340);
            txtTipoUsuario.Name = "txtTipoUsuario";
            txtTipoUsuario.Size = new Size(100, 23);
            txtTipoUsuario.TabIndex = 12;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(466, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(19, 31);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(441, 23);
            txtBuscar.TabIndex = 14;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(19, 12);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(242, 15);
            lblBuscar.TabIndex = 15;
            lblBuscar.Text = "Ingrese nombre de usuario que desea buscar";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(400, 223);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(159, 34);
            btnCargar.TabIndex = 16;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // AdminUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 379);
            Controls.Add(btnCargar);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(txtTipoUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtEmail);
            Controls.Add(txtClave);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lblTipoUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblEmail);
            Controls.Add(lblClave);
            Controls.Add(dgvUsuarios);
            Name = "AdminUsers";
            Text = "AdminUsers";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn TipoUsuario;
        private DataGridViewTextBoxColumn UltimoIngreso;
        private Label lblClave;
        private Label lblEmail;
        private Label lblNombreUsuario;
        private Label lblTipoUsuario;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
        private TextBox txtClave;
        private TextBox txtEmail;
        private TextBox txtNombreUsuario;
        private TextBox txtTipoUsuario;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Button btnCargar;
    }
}