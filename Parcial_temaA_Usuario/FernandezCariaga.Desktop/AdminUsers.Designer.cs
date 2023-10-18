namespace FernandezCariaga.Desktop
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
            lbl_adminusers = new Label();
            dgvUsers = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            clave = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            nombreUsuario = new DataGridViewTextBoxColumn();
            tipoUsuario = new DataGridViewTextBoxColumn();
            ultimoIngreso = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDelete = new Button();
            btnCargarUsers = new Button();
            lblId = new Label();
            lblClave = new Label();
            lblTipoUser = new Label();
            lblEmail = new Label();
            lblNombreUser = new Label();
            txtId = new TextBox();
            txtClave = new TextBox();
            txtEmail = new TextBox();
            txtNombreUser = new TextBox();
            txtTipoUser = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // lbl_adminusers
            // 
            lbl_adminusers.AutoSize = true;
            lbl_adminusers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_adminusers.Location = new Point(254, 9);
            lbl_adminusers.Name = "lbl_adminusers";
            lbl_adminusers.Size = new Size(172, 17);
            lbl_adminusers.TabIndex = 0;
            lbl_adminusers.Text = "Administrador de usuarios";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { id, clave, email, nombreUsuario, tipoUsuario, ultimoIngreso });
            dgvUsers.Location = new Point(8, 29);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.Size = new Size(646, 240);
            dgvUsers.TabIndex = 1;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // clave
            // 
            clave.DataPropertyName = "Clave";
            clave.HeaderText = "clave";
            clave.Name = "clave";
            // 
            // email
            // 
            email.DataPropertyName = "Email";
            email.HeaderText = "email";
            email.Name = "email";
            // 
            // nombreUsuario
            // 
            nombreUsuario.DataPropertyName = "NombreUsuario";
            nombreUsuario.HeaderText = "nombre usuario";
            nombreUsuario.Name = "nombreUsuario";
            // 
            // tipoUsuario
            // 
            tipoUsuario.DataPropertyName = "TipoUsuario";
            tipoUsuario.HeaderText = "tipo usuario";
            tipoUsuario.Name = "tipoUsuario";
            // 
            // ultimoIngreso
            // 
            ultimoIngreso.DataPropertyName = "UltimoIngreso";
            ultimoIngreso.HeaderText = "ultimo ingreso";
            ultimoIngreso.Name = "ultimoIngreso";
            ultimoIngreso.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(498, 314);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(579, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCargarUsers
            // 
            btnCargarUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarUsers.Location = new Point(498, 275);
            btnCargarUsers.Name = "btnCargarUsers";
            btnCargarUsers.Size = new Size(156, 33);
            btnCargarUsers.TabIndex = 4;
            btnCargarUsers.Text = "Cargar usuarios";
            btnCargarUsers.UseVisualStyleBackColor = true;
            btnCargarUsers.Click += btnCargarUsers_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(11, 292);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 5;
            lblId.Text = "id";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(10, 320);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 6;
            lblClave.Text = "Clave";
            // 
            // lblTipoUser
            // 
            lblTipoUser.AutoSize = true;
            lblTipoUser.Location = new Point(10, 410);
            lblTipoUser.Name = "lblTipoUser";
            lblTipoUser.Size = new Size(73, 15);
            lblTipoUser.TabIndex = 7;
            lblTipoUser.Text = "Tipo Usuario";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 349);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblNombreUser
            // 
            lblNombreUser.AutoSize = true;
            lblNombreUser.Location = new Point(10, 379);
            lblNombreUser.Name = "lblNombreUser";
            lblNombreUser.Size = new Size(94, 15);
            lblNombreUser.TabIndex = 8;
            lblNombreUser.Text = "Nombre Usuario";
            // 
            // txtId
            // 
            txtId.Location = new Point(116, 287);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 9;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(116, 314);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 344);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(116, 373);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(100, 23);
            txtNombreUser.TabIndex = 12;
            // 
            // txtTipoUser
            // 
            txtTipoUser.Location = new Point(116, 402);
            txtTipoUser.Name = "txtTipoUser";
            txtTipoUser.Size = new Size(100, 23);
            txtTipoUser.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(537, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(579, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AdminUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 444);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtTipoUser);
            Controls.Add(txtNombreUser);
            Controls.Add(txtEmail);
            Controls.Add(txtClave);
            Controls.Add(txtId);
            Controls.Add(lblNombreUser);
            Controls.Add(lblEmail);
            Controls.Add(lblTipoUser);
            Controls.Add(lblClave);
            Controls.Add(lblId);
            Controls.Add(btnCargarUsers);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            Controls.Add(lbl_adminusers);
            Name = "AdminUsers";
            Text = "AdminUsers";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_adminusers;
        private DataGridView dgvUsers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnCargarUsers;
        private Label lblId;
        private Label lblClave;
        private Label lblTipoUser;
        private Label lblEmail;
        private Label lblNombreUser;
        private TextBox txtId;
        private TextBox txtClave;
        private TextBox txtEmail;
        private TextBox txtNombreUser;
        private TextBox txtTipoUser;
        private Button btnSave;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn clave;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn nombreUsuario;
        private DataGridViewTextBoxColumn tipoUsuario;
        private DataGridViewTextBoxColumn ultimoIngreso;
        private Button btnCancel;
    }
}