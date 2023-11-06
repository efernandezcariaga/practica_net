using FernandezCariaga.Entidades;
using FernandezCariaga.Escritorio.Helpers;
using FernandezCariaga.Modelos.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FernandezCariaga.Escritorio
{
    public partial class adminClientes : Form
    {
        private List<Cliente> _clientes;
        private Cliente? _selectedItem;
        private bool _isEdit;
        private string _baseEndpointUrl = "clientes";

        public adminClientes()
        {
            InitializeComponent();
            CheckActions();
        }

        private async Task LoadClientesAsync()
        {
            var allClients = await HttpClientHelper.GetAsync<List<Cliente>>(_baseEndpointUrl);
            if (allClients is not null)
            {
                _clientes = allClients;
            }
        }

        private void LoadCliente(Cliente cliente)
        {
            txtCodigoCliente.Text = cliente.CodigoCliente;
            txtEmail.Text = cliente.Email;
            txtNivelCliente.Text = cliente.NivelCliente.ToString();
            txtRazonSocial.Text = cliente.RazonSocial;
        }

        private void CheckActions()
        {
            btnAdd.Enabled = !_isEdit;
            btnDelete.Enabled = _isEdit;
            btnSave.Enabled = _isEdit;
        }

        private async Task RefreshGridAsync()
        {
            await LoadClientesAsync();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _clientes;
            dgvClientes.DataSource = bindingSource;
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            _isEdit = false;
            await RefreshGridAsync();
        }

        private async void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = _clientes[e.RowIndex];
            var selectedItemId = selectedItem.Id;

            var cliente = await HttpClientHelper.GetAsync<Cliente>($"{_baseEndpointUrl}/{selectedItemId}");
            if (cliente is not null)
            {
                _isEdit = true;
                _selectedItem = cliente;
                LoadCliente(cliente);
                CheckActions();
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string codigoCliente = txtCodigoCliente.Text;
            string email = txtEmail.Text;
            string nivelCliente = txtNivelCliente.Text;
            string razonSocial = txtRazonSocial.Text;

            try
            {
                Validaciones.CamposRequeridos(codigoCliente, email, nivelCliente, razonSocial);
                var newItemAdd = new
                {
                    CodigoCliente = txtCodigoCliente.Text,
                    Email = txtEmail.Text,
                    NivelCliente = txtNivelCliente.Text,
                    RazonSocial = txtRazonSocial.Text,
                    UltimaCompraRealizada = DateTime.Now,
                };

                var result = await HttpClientHelper.PostAsync<Cliente>($"{_baseEndpointUrl}", newItemAdd);

                await RefreshGridAsync();

                MessageBox.Show("Creacion de cliente exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                throw new Exception("Error");
            }

            string codigoCliente = txtCodigoCliente.Text;
            string email = txtEmail.Text;
            string nivelCliente = txtNivelCliente.Text;
            string razonSocial = txtRazonSocial.Text;

            try
            {
                var itemToUpdate = new
                {
                    Id = _selectedItem.Id,
                    CodigoCliente = txtCodigoCliente.Text,
                    Email = txtEmail.Text,
                    NivelCliente = txtNivelCliente.Text,
                    RazonSocial = txtRazonSocial.Text,
                };

                var result = await HttpClientHelper.PutAsync<GenericResponse>($"{_baseEndpointUrl}", itemToUpdate);

                _isEdit = false;

                await RefreshGridAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var itemToDelete = _selectedItem.Id;

            var result = await HttpClientHelper.DeleteAsync<GenericResponse>($"{_baseEndpointUrl}", itemToDelete);

            await RefreshGridAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string razonSocialABuscar = txtBuscar.Text;
            var razonSocialEncontrada = await HttpClientHelper.GetAsync<List<Cliente>>($"{_baseEndpointUrl}/filtro/{razonSocialABuscar}");

            if(razonSocialEncontrada != null)
            {
                dgvClientes.DataSource = razonSocialEncontrada;
            }
        }
    }
}
