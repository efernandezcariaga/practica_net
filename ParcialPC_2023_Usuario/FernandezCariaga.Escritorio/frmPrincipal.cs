namespace FernandezCariaga.Escritorio
{
    public partial class frmPrincipal : Form
    {
        public AdminUsers? AdminUsers { get; set; }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void OpenAdminUsers()
        {
            if (AdminUsers == null)
            {
                AdminUsers = new AdminUsers();
                AdminUsers.ShowDialog();
            }
            else
            {
                AdminUsers.ShowDialog();
            }
        }

        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            OpenAdminUsers();
        }
    }
}