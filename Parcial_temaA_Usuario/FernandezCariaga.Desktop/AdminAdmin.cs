namespace FernandezCariaga.Desktop
{
    public partial class AdminAdmin : Form
    {
        public AdminUsers? AdminUsers { get; set; }
        public AdminAdmin()
        {
            InitializeComponent();
        }

        public void OpenAdminUsers()
        {
            if (AdminUsers is not null)
            {
                AdminUsers.ShowDialog();
            }
            else
            {
                AdminUsers = new AdminUsers();
                AdminUsers.ShowDialog();
            }
        }

        private void btn_admUsers_Click(object sender, EventArgs e)
        {
            OpenAdminUsers();
        }
    }
}