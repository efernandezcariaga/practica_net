namespace FernandezCariaga.Escritorio
{
    public partial class frmPrincipal : Form
    {
        public AdminDocentes? AdminDocentes { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void OpenAdminDocentes()
        {
            if (AdminDocentes != null)
            {
                AdminDocentes.ShowDialog();
            }
            else
            {
                AdminDocentes = new AdminDocentes();
                AdminDocentes.ShowDialog();
            }
        }

        private void btnAdminDocentes_Click(object sender, EventArgs e)
        {
            OpenAdminDocentes();
        }
    }

}