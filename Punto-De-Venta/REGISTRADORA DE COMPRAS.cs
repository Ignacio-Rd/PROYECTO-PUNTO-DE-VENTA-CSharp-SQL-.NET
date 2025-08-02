using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocios;
using Negocio_;

namespace TPFinalNivel2_RuizDiaz
{
    public partial class REGISTRADORA_DE_COMPRAS : Form
    {
        private List<Articulos> listaArticulos = new List<Articulos>();

        //private bool Total = false;

        //private bool Sumar = false;



        private decimal total_acumulado = 0;





        //string textoLabel = lblNumero.Text;  // Ejemplo: "123"
        //int numero = int.Parse(textoLabel);




        public REGISTRADORA_DE_COMPRAS()
        {
            InitializeComponent();
            lbl_precio.Text = "0";


        }



        private void Btn_Total_Click(object sender, EventArgs e)

        {
            string metodo;

            MetodoDePagoNegocio negocio = new MetodoDePagoNegocio();

            VentaNegocio venta = new VentaNegocio();

            metodo = cbx_metododepago.SelectedItem != null ? cbx_metododepago.SelectedItem.ToString() : "";

            total_acumulado = negocio.Elegir_metodopago(total_acumulado, metodo);

            TOTAL_A_COBRAR totalForm = new TOTAL_A_COBRAR(total_acumulado);
            totalForm.ShowDialog();

            venta.Agregar_venta(DateTime.Now, total_acumulado);

            total_acumulado = 0;

            lbl_precio.Text = "0";

            listaArticulos.Clear();
            DgvRegistradora.DataSource = null;

            
            
        }


        private bool Procesando_Codigo = false;

        private void codigo_Producto_TextChanged(object sender, EventArgs e)
        {

            if (Procesando_Codigo) return;

            if (codigo_Producto.Text.Length != 13) return;

            

            try
            {
                Procesando_Codigo = true;

                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulos articulo = negocio.Obtener_Por_Codigo(codigo_Producto.Text).FirstOrDefault();
                


                if (articulo == null)
                {
                    MessageBox.Show("Artículo no encontrado", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    codigo_Producto.Focus();
                    return;
                }

                if (articulo != null)
                {

                    //agregar a la lsita
                    listaArticulos.Add(articulo);

                    //actualizar data great view
                    DgvRegistradora.DataSource = null;
                    DgvRegistradora.DataSource = listaArticulos;
                    ocultarColumnas();
                    DgvRegistradora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    

                    //sumar al total
                    total_acumulado = total_acumulado + articulo.Precio;



                    lbl_precio.Text = total_acumulado.ToString("C");


                    //limpiar el text box para el proximo codigo

                    codigo_Producto.Text = "";
                    codigo_Producto.Focus();

                    DgvRegistradora.ClearSelection();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Procesando_Codigo = false;
            }

        }

        private void REGISTRADORA_DE_COMPRAS_Load(object sender, EventArgs e)
        {
            MetodoDePagoNegocio negocio = new MetodoDePagoNegocio();



            cbx_metododepago.DataSource = negocio.Listametodo();


            cbx_metododepago.SelectedIndex = 0;

        }
        private void ocultarColumnas()
        {
            // Verifica si hay columnas en el DataGridView antes de intentar acceder a ellas
            if (DgvRegistradora.Columns.Count > 0)
            {
                // Solo intenta ocultar si la columna existe para evitar errores
                if (DgvRegistradora.Columns.Contains("URL"))
                {
                    DgvRegistradora.Columns["URL"].Visible = false;
                }
                if (DgvRegistradora.Columns.Contains("Id"))
                {
                    DgvRegistradora.Columns["Id"].Visible = false;
                }

                if (DgvRegistradora.Columns.Contains("metodoDePago"))
                {
                    DgvRegistradora.Columns["metodoDePago"].Visible = false;
                }
                if (DgvRegistradora.Columns.Contains("Categoria"))
                {
                    DgvRegistradora.Columns["Categoria"].Visible = false;
                }
               
                    

                DgvRegistradora.Columns["Marca"].Visible = false;

                DgvRegistradora.Columns["Descripcion"].Visible = false;




            }
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulos seleccionado;
            

            if (DgvRegistradora.Rows.Count == 0)
    {
        MessageBox.Show("No hay artículos para eliminar.");
        return; // Salimos del método si no hay filas.
    }

    // Si llegamos hasta aquí, significa que hay al menos una fila en la grilla.
    // Ahora, verificamos si hay una fila SELECCIONADA.
    if (DgvRegistradora.CurrentRow == null || DgvRegistradora.Rows.Count == 0)
    {
        MessageBox.Show("Por favor, seleccione un artículo para eliminar.");
        return; // Salimos si no hay una fila seleccionada.
    }
            


            try
            {
                DialogResult respuesta = MessageBox.Show("De verdad queres eliminar este articulo?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {


                    seleccionado = (Articulos)DgvRegistradora.CurrentRow.DataBoundItem;

                    if(seleccionado == null)
                    {
                        return;
                    }

                    total_acumulado = total_acumulado - seleccionado.Precio;
                    lbl_precio.Text = total_acumulado.ToString("C");
                    listaArticulos.Remove(seleccionado);
                    negocio.Reponer_Stock(seleccionado.codigo);


                    cargar();
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Ocurrió un error inesperado al eliminar el artículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw; // Puedes comentar esta línea para que la aplicación no se cierre si quieres.
            }
        }




        private void cargar()
        {

            DgvRegistradora.DataSource = null;
            DgvRegistradora.DataSource = listaArticulos;
            ocultarColumnas();
            if (DgvRegistradora.Rows.Count > 0)
            {
                DgvRegistradora.ClearSelection();
            }



        }

       
    }
}
