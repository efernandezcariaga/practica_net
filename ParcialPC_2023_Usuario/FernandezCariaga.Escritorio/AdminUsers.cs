using FernandezCariaga.Entidades;
using FernandezCariaga.Escritorio.Helpers;

namespace FernandezCariaga.Escritorio
{
    public partial class AdminUsers : Form
    {
        private List<Usuario> _usuarios;
        private string _baseEndpointUrl = "usuarios";
        private Usuario? _selectedItem;
        public AdminUsers()
        {
            InitializeComponent();
        }

        private async Task LoadUsersAsync()
        {
            var allUsers = await HttpClientHelper.GetAsync<List<Usuario>>(_baseEndpointUrl);
            if (allUsers != null)
            {
                _usuarios = allUsers;
            }
        }

        private void LoadUsers(Usuario user)
        {
            txtClave.Text = user.Clave;
            txtEmail.Text = user.Email;
            txtNombreUsuario.Text = user.NombreUsuario;
            txtTipoUsuario.Text = user.TipoUsuario.ToString();
        }

        private async Task RefreshGridAsync()
        {
            await LoadUsersAsync();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _usuarios;
            dgvUsuarios.DataSource = bindingSource;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            await RefreshGridAsync();
        }

        private async void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = _usuarios[e.RowIndex];
            var selectedItemNombreUsuario = selectedItem.NombreUsuario;

            var usuario = await HttpClientHelper.GetAsync<Usuario>($"({_baseEndpointUrl}/{selectedItemNombreUsuario})");
            if (usuario != null)
            {
                _selectedItem = usuario;
                LoadUsers(usuario);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            string nombreUser = txtNombreUsuario.Text;
            string email = txtEmail.Text;
            string tipoUser = txtTipoUsuario.Text;

            try
            {

                Validaciones.CamposRequeridos(clave, email, nombreUser, tipoUser);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            var newItem = new Usuario
            {
                Clave = txtClave.Text,
                Email = txtEmail.Text,
                NombreUsuario = txtNombreUsuario.Text,
                TipoUsuario = Int32.Parse(txtTipoUsuario.Text),
                UltimoIngreso = DateTime.Now,
            };

            var result = await HttpClientHelper.PostAsync<Usuario>($"{_baseEndpointUrl}", newItem);
            await RefreshGridAsync();
            MessageBox.Show("Usuario creado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public class GenericResponse
        {
            public bool Success { get; set; }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var itemToUpdate = new Usuario
            {
                Clave = txtClave.Text,
                Email = txtEmail.Text,
                NombreUsuario = txtNombreUsuario.Text,
                TipoUsuario = Int32.Parse(txtTipoUsuario.Text)
            };
            var result = await HttpClientHelper.PutAsync<GenericResponse>($"{_baseEndpointUrl}", itemToUpdate);

            await RefreshGridAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var itemToDelete = _selectedItem.NombreUsuario;
            var result = await HttpClientHelper.DeleteAsync<GenericResponse>($"{_baseEndpointUrl}", itemToDelete);
            await RefreshGridAsync();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreUsuarioABuscar = txtBuscar.Text;
            var usuariosEncontrados = await HttpClientHelper.GetAsync<List<Usuario>>($"({_baseEndpointUrl}/{nombreUsuarioABuscar})");

            if (usuariosEncontrados != null)
            {
                foreach (var usuario in usuariosEncontrados)
                {
                    dgvUsuarios.Rows.Add(usuario.Clave, usuario.Email, usuario.NombreUsuario, usuario.TipoUsuario);
                }
            }
            else
            {
                MessageBox.Show("No se encontro ningun usuario con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
