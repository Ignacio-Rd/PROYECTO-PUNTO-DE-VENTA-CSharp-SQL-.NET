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
using Negocio_;

namespace TPFinalNivel2_RuizDiaz
{
    public partial class formas_de_pago : Form
    {
        private List<Metodo_de_pago> listametodo = new List<Metodo_de_pago>();

        private Metodo_de_pago metodo = null;

        public formas_de_pago()
        {
            InitializeComponent();
        }

    

        private void cargar()
        {
            MetodoDePagoNegocio negocio = new MetodoDePagoNegocio();
            listametodo = negocio.Listametodo();
            dgv_metodopago.DataSource = listametodo;
            dgv_metodopago.Columns["id"].Visible = false;
        }

        private void btnAgregarMetodopago_Click(object sender, EventArgs e)
        {
            MetodoDePagoNegocio negocio = new MetodoDePagoNegocio();

            try
            {

                if (metodo == null && txtMetodoPago.Text != "" && txtMetodoPago.Text != "")
                {
                    metodo = new Metodo_de_pago();
                    metodo.MetodoPago = txtMetodoPago.Text;
                    metodo.porcentaje = decimal.Parse(Txtporcentaje.Text);
                    negocio.agregarMetodopago(metodo);
                    MessageBox.Show("agregado exitosamente");
                    cargar();

                

                

            }

            }
            catch (Exception ex)
            {

                if(string.IsNullOrWhiteSpace(txtMetodoPago.Text) || string.IsNullOrWhiteSpace(Txtporcentaje.Text))
                {
                    MessageBox.Show("COMPLETE TODOS LOS CAMPOS");
                }
            }
        }

        private void btn_eliminarmetodopago_Click(object sender, EventArgs e)
        {
            MetodoDePagoNegocio negocio = new MetodoDePagoNegocio();
            Metodo_de_pago seleccionado;

            try
            {

                DialogResult respuesta = MessageBox.Show("De verdad queres eliminar esta forma de pago?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Metodo_de_pago)dgv_metodopago.CurrentRow.DataBoundItem;

                    negocio.EliminarMetodoPago(seleccionado.id);
                    cargar();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void formas_de_pago_Load(object sender, EventArgs e)
        {
            cargar();
        }


    }
}
