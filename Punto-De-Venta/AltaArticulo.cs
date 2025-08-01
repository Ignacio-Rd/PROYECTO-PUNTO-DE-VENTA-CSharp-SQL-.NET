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
using System.IO;
using System.Configuration;

namespace TPFinalNivel2_RuizDiaz
{
    public partial class AltaArticulo : Form
    {
        private Dominio.Articulos articulo = null;
        private OpenFileDialog archivo = null;

        public AltaArticulo()
        {
            InitializeComponent();
        }

        public AltaArticulo(Dominio.Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulos articulo = new Articulos();
            ArticuloNegocio negocio = new ArticuloNegocio();


            try
            {

                ResetearColores();

                if (articulo == null)
                    articulo = new Dominio.Articulos();

                articulo.codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbxMarcas.SelectedItem;
                articulo.Categoria = (categoria)cbxCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Stock = int.Parse(txtStock.Text);


                if (!CamposValidos())
                {
                    MessageBox.Show("Complete todos los campos requeridos");
                    return; 
                }


                if (articulo.Id != 0)
                {
                        negocio.Modificar(articulo);
                        MessageBox.Show("modificaar exitosamente"); }



                else
                {

                    negocio.Agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");

                }

             

               



                Close();


            }
            catch (Exception )
            {
                if (!CamposValidos())
                {
                    MessageBox.Show("Complete todos los campos requeridos");
                    return;
                }

            }

        }

     

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categorianegocio = new CategoriaNegocio();

            MarcasNegocio marcasnegocio = new MarcasNegocio();



            try
            {

                cbxCategoria.DataSource = categorianegocio.listarCategoria();



                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";


                cbxMarcas.DataSource = marcasnegocio.listarmarca();


                cbxMarcas.ValueMember = "Id";
                cbxMarcas.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarcas.SelectedValue = articulo.Marca.Id;
                    txtStock.Text = articulo.Stock.ToString();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


      

        private void ResetearColores()
        {
            txtCodigo.BackColor = SystemColors.Window;
            txtNombre.BackColor = SystemColors.Window;
            txtDescripcion.BackColor = SystemColors.Window;
            txtPrecio.BackColor = SystemColors.Window;
        }

        private bool CamposValidos()
        {
            bool camposValidos = true;

            // Validación de campos de texto
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                txtCodigo.BackColor = Color.Firebrick;
                camposValidos = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.Firebrick;
                camposValidos = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.BackColor = Color.Firebrick;
                camposValidos = false;
            }

            // Validación numérica con TryParse
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                txtPrecio.BackColor = Color.Firebrick;
                camposValidos = false;
            }

            // Validación de comboboxes
            if (cbxMarcas.SelectedItem == null)
            {
                cbxMarcas.BackColor = Color.Firebrick;
                camposValidos = false;
            }

            if (cbxCategoria.SelectedItem == null)
            {
                cbxCategoria.BackColor = Color.Firebrick;
                camposValidos = false;
            }

            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                txtStock.BackColor = Color.Firebrick;
                camposValidos = false;
            }

            return camposValidos;
        }


    }
}
