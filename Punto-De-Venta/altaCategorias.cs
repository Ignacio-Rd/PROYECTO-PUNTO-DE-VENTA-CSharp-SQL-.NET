using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocios;

namespace TPFinalNivel2_RuizDiaz
{
    public partial class altaCategorias : Form
    {
        private categoria categoria = null;

        public altaCategorias()
        {
            InitializeComponent();
        }

        private List<Dominio.categoria> listaCategoria = new List<Dominio.categoria>();


        private void altaCategorias_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategoria = negocio.listarCategoria();
            dgvCategoria.DataSource = listaCategoria;
            dgvCategoria.Columns["id"].Visible = false;
         }

        private void btnAgregarCategorias_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {

                if (categoria == null && txtAgregarCategoria.Text != "")
                {
                    categoria = new categoria();
                    categoria.Descripcion = txtAgregarCategoria.Text;
                    negocio.agregarCategoria(categoria);
                    MessageBox.Show("agregado exitosamente");
                    cargar();

    }

                Close();




}
            catch (Exception ex)
            {

                if (txtAgregarCategoria.Text == "")
                    MessageBox.Show("categoría vacía"); ;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            categoria seleccionado;

            try
            {

                DialogResult respuesta = MessageBox.Show("De verdad queres eliminar ese marca?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (categoria)dgvCategoria.CurrentRow.DataBoundItem;

                    negocio.eliminarCategoria(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
