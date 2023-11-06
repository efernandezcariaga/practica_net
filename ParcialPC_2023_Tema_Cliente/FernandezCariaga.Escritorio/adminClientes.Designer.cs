namespace FernandezCariaga.Escritorio
{
    partial class adminClientes
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
            txtRazonSocial = new TextBox();
            txtNivelCliente = new TextBox();
            txtEmail = new TextBox();
            txtCodigoCliente = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            btnCargar = new Button();
            txtBuscar = new TextBox();
            dgvClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CodigoCliente = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            NivelCliente = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            UltimaCompraRealizada = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(173, 351);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(121, 23);
            txtRazonSocial.TabIndex = 34;
            // 
            // txtNivelCliente
            // 
            txtNivelCliente.Location = new Point(173, 310);
            txtNivelCliente.Name = "txtNivelCliente";
            txtNivelCliente.Size = new Size(121, 23);
            txtNivelCliente.TabIndex = 33;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(173, 271);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 32;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(173, 235);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(121, 23);
            txtCodigoCliente.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 357);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 30;
            label5.Text = "RazonSocial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 315);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 29;
            label4.Text = "NivelCliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 274);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 28;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 238);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 27;
            label2.Text = "CodigoCliente";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(642, 412);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(596, 331);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "BORRAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(642, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 24;
            btnSave.Text = "GUARDAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(544, 302);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 23);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "AGREGAR";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(544, 227);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(173, 69);
            btnCargar.TabIndex = 22;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(89, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(530, 23);
            txtBuscar.TabIndex = 21;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Id, CodigoCliente, Email, NivelCliente, RazonSocial, UltimaCompraRealizada });
            dgvClientes.Location = new Point(76, 62);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(650, 159);
            dgvClientes.TabIndex = 20;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // CodigoCliente
            // 
            CodigoCliente.DataPropertyName = "CodigoCliente";
            CodigoCliente.HeaderText = "CodigoCliente";
            CodigoCliente.Name = "CodigoCliente";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // NivelCliente
            // 
            NivelCliente.DataPropertyName = "NivelCliente";
            NivelCliente.HeaderText = "NivelCliente";
            NivelCliente.Name = "NivelCliente";
            // 
            // RazonSocial
            // 
            RazonSocial.DataPropertyName = "RazonSocial";
            RazonSocial.HeaderText = "RazonSocial";
            RazonSocial.Name = "RazonSocial";
            // 
            // UltimaCompraRealizada
            // 
            UltimaCompraRealizada.DataPropertyName = "UltimaCompraRealizada";
            UltimaCompraRealizada.HeaderText = "UltimaCompraRealizada";
            UltimaCompraRealizada.Name = "UltimaCompraRealizada";
            UltimaCompraRealizada.ReadOnly = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(642, 32);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 15);
            label1.Name = "label1";
            label1.Size = new Size(265, 15);
            label1.TabIndex = 18;
            label1.Text = "INGRESE LA RAZON SOCIAL QUE DESEA BUSCAR";
            // 
            // adminClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRazonSocial);
            Controls.Add(txtNivelCliente);
            Controls.Add(txtEmail);
            Controls.Add(txtCodigoCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(btnCargar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvClientes);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Name = "adminClientes";
            Text = "adminClientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRazonSocial;
        private TextBox txtNivelCliente;
        private TextBox txtEmail;
        private TextBox txtCodigoCliente;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private Button btnCargar;
        private TextBox txtBuscar;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CodigoCliente;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn NivelCliente;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn UltimaCompraRealizada;
        private Button btnBuscar;
        private Label label1;
    }
}