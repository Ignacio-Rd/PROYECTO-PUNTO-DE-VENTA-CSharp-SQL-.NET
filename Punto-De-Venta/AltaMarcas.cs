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
    public partial class AltaMarcas : Form
    {
        private List<Marca> listamarcas = new List<Marca>();

        private Marca marca = null;

        public AltaMarcas()
        {
            InitializeComponent();
        }

        private void AltaMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcasNegocio negocio = new MarcasNegocio();
            listamarcas = negocio.listarmarca();
            dgvMarcas.DataSource = listamarcas;
            dgvMarcas.Columns["id"].Visible = false;

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();

            try
            {

                if (marca == null && txtAgregarMarca.Text != "")
                {
                    marca = new Marca();
                    marca.Descripcion = txtAgregarMarca.Text;
                    negocio.agregarMarca(marca);
                    MessageBox.Show("agregado exitosamente");
                    cargar();

                }

                else if(txtAgregarMarca.Text == "")
                    MessageBox.Show("categoría vacía");

                Close();




            }
            catch (Exception ex)
            {
                throw ex;
               
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            Marca seleccionado;

            try
            {

                DialogResult respuesta = MessageBox.Show("De verdad queres eliminar ese marca?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                    negocio.eliminarMarca(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
