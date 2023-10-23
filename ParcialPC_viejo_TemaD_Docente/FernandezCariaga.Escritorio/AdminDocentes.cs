using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FernandezCariaga.Entidades;
using FernandezCariaga.Escritorio.Helpers;

namespace FernandezCariaga.Escritorio
{
    public partial class AdminDocentes : Form
    {
        private List<Docente> _docentes;
        private Docente? _selectedItem;
        private string _baseEndpointUrl = "docentes";

        public AdminDocentes()
        {
            InitializeComponent();
        }

        private async Task LoadDocentesAsync()
        {
            var allDocentes = await HttpClientHelper.GetAsync<List<Docente>>(_baseEndpointUrl);
            if (allDocentes != null)
            {
                _docentes = allDocentes;
            }
        }

        private async Task RefreshGridAsync()
        {
            await LoadDocentesAsync();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _docentes;
            dgvDocentes.DataSource = bindingSource;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            await RefreshGridAsync();

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string cuil = txtCuil.Text;

            try
            {
                Validaciones.ValidacionCuil(cuil);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            var newItem = new Docente
            {
                ApellidoNombre = txtApellidoNombre.Text,
                CUIL = txtCuil.Text,
                Email = txtEmail.Text,
                FechaIngreso = DateTime.Parse(txtFechaIngreso.Text),
                Id = Int32.Parse(txtId.Text),
                Salario = Decimal.Parse(txtSalario.Text),
            };

            var result = await HttpClientHelper.PostAsync<Docente>($"{_baseEndpointUrl}", newItem);
            await RefreshGridAsync();
            MessageBox.Show("Docente creado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string docenteABuscar = txtBuscar.Text;
            var docenteEncontrado = await HttpClientHelper.GetAsync<List<Docente>>($"{_baseEndpointUrl}/{docenteABuscar}");

            if (docenteEncontrado != null)
            {
                dgvDocentes.DataSource = docenteEncontrado;

            }
        }
    }
}
