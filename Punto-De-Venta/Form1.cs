using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Dominio;

namespace TPFinalNivel2_RuizDiaz
{
    public partial class Form1 : Form
    {
        private List<Dominio.Articulos> listaArticulos = new List<Dominio.Articulos>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cbxCampo.Items.Add("Código");
            cbxCampo.Items.Add("Precio");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Cateogoria");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Dominio.Articulos seleccionado = (Dominio.Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.URL);
            }
        }

        private void cargar()
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            ocultarColumnas();
            dgvArticulos.ClearSelection();
            //pbxArticulos.Load(listaArticulos[0].URL);


        }

        private void ocultarColumnas()
        {

            dgvArticulos.Columns["URL"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["metodoDePago"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {

                pbxArticulos.Load(imagen);

            }
            catch (Exception ex)
            {

                pbxArticulos.Load("https://yaktribe.games/community/media/placeholder-jpg.84782/full");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AltaArticulo alta = new AltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null || dgvArticulos.Rows.Count == 0 || dgvArticulos.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("No se encontró ningún artículo para modificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Dominio.Articulos seleccionado;

                seleccionado = (Dominio.Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                AltaArticulo modificar = new AltaArticulo(seleccionado);

                modificar.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al intentar modificar el artículo.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            Dominio.Articulos seleccionado;

            try
            {
                if (dgvArticulos.CurrentRow == null || dgvArticulos.Rows.Count == 0 || dgvArticulos.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("No se encontró ningún artículo para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                DialogResult respuesta = MessageBox.Show("De verdad queres eliminar ese articulo?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Dominio.Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                    negocio.Eliminar(seleccionado.Id);

                    cargar();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al intentar modificar el artículo.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool validarFiltro()
        {
            if(cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar");
                return true;
            }
            if(cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar");
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "Numero")
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numerico");
                    return true;
                }
            if (!(soloNumeros(txtFiltroAvanzado.Text)))
            {
                MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                return true;
            }
            if (txtFiltroAvanzado.Text == "" || txtFiltroAvanzado.Text == null)
            {
                txtFiltroAvanzado.BackColor = Color.Firebrick;
            }
            else
            {
                txtFiltroAvanzado.BackColor = SystemColors.Window;
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            if (cbxCampo.SelectedItem.ToString() == "Precio")
            {
                foreach (char caracter in cadena)
                {
                    if ((char.IsLetter(caracter)))
                        return false;
                }
            }
            return true;
        }


        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {   if (validarFiltro())
                    return;

                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            
            }
            catch (Exception ex)
            {
                if (txtFiltroAvanzado.Text == "" || txtFiltroAvanzado.Text == null)
                {
                    txtFiltroAvanzado.BackColor = Color.Firebrick;
                }
                else
                {
                    txtFiltroAvanzado.BackColor = SystemColors.Window;
                }
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Dominio.Articulos> listafiltrada;

            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                listafiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listafiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listafiltrada;
            ocultarColumnas();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroAvanzado.Text = "";
            dgvArticulos.DataSource = listaArticulos;
            txtFiltroAvanzado.BackColor = SystemColors.Window;

        }

        private void btnVerdetalles_Click(object sender, EventArgs e)
        {
            

            Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            VerDetalles ver = new VerDetalles(seleccionado);
            ver.ShowDialog();

        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            AltaMarcas formulario = new AltaMarcas();
            formulario.ShowDialog();
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            altaCategorias formulario = new altaCategorias();
            formulario.ShowDialog();
        }
    }

}

