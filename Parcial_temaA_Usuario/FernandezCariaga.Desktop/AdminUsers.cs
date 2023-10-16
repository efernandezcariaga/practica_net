using FernandezCariaga.Desktop.Helper;
using FernandezCariaga.Entidades;
using FernandezCariaga.Models.Responses;

namespace FernandezCariaga.Desktop
{
    public partial class AdminUsers : Form
    {
        private List<Usuario> _usuarios;
        private Usuario? _selectedItem;
        private bool _isEdit;
        private string _baseEndpointUrl = "usuarios";

        public AdminUsers()
        {
            InitializeComponent();
            CheckActions();
        }

        private async Task LoadUsersAsync()
        {
            var allUsers = await HttpClientHelper.GetAsync<List<Usuario>>(_baseEndpointUrl);
            if (allUsers is not null)
            {
                _usuarios = allUsers;
            }
        }

        private void LoadUsers(Usuario user)
        {
            txtId.Text = user.id.ToString();
            txtClave.Text = user.Clave;
            txtEmail.Text = user.Email;
            txtNombreUser.Text = user.NombreUsuario;
            txtTipoUser.Text = user.TipoUsuario.ToString();
        }

        private async Task RefreshGridAsync()
        {
            await LoadUsersAsync();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _usuarios;
            dgvUsers.DataSource = bindingSource;
        }

        private void CheckActions()
        {
            btnAdd.Enabled = !_isEdit;
            btnDelete.Enabled = !_isEdit;
            btnSave.Enabled = !_isEdit;
        }

        private async void btnCargarUsers_Click(object sender, EventArgs e)
        {
            _isEdit = false;
            await RefreshGridAsync();
        }

        private async void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = _usuarios[e.RowIndex];
            var selectedItemId = selectedItem.id;

            var user = await HttpClientHelper.GetAsync<Usuario>($"{_baseEndpointUrl}/{selectedItemId.ToString()}");
            if (user is not null)
            {
                _isEdit = true;
                _selectedItem = user;
                LoadUsers(user);
                CheckActions();
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var newItemAdd = new Usuario
            {
                Clave = txtClave.Text,
                Email = txtEmail.Text,
                NombreUsuario = txtNombreUser.Text,
                TipoUsuario = Int32.Parse(txtTipoUser.Text),
            };

            var result = await HttpClientHelper.PostAsync<Usuario>($"{_baseEndpointUrl}", newItemAdd);

            await RefreshGridAsync();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var itemToUpdate = new Usuario
            {
                Clave = txtClave.Text,
                Email = txtEmail.Text,
                NombreUsuario = txtNombreUser.Text,
                TipoUsuario = Int32.Parse(txtTipoUser.Text),
            };

            var result = await HttpClientHelper.PutAsync<GenericResponse>($"{_baseEndpointUrl}", itemToUpdate);

            _isEdit = false;

            await RefreshGridAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var itemToDelete = _selectedItem.id;

            var result = await HttpClientHelper.DeleteAsync<GenericResponse>($"{_baseEndpointUrl}", itemToDelete);

            await RefreshGridAsync();
        }
    }
}
