namespace FernandezCariaga.Escritorio
{
    public partial class frmPrincipal : Form
    {
        public adminClientes? adminClientes { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public void OpenAdminClientes()
        {
            if (adminClientes != null)
            {
                adminClientes.ShowDialog();
            }
            else
            {
                adminClientes = new adminClientes();
                adminClientes.ShowDialog();
            }
        }
        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            OpenAdminClientes();
        }
    }
}