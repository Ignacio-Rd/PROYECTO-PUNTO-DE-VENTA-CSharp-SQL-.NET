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
using Negocio_;

namespace TPFinalNivel2_RuizDiaz
{
    public partial class Venta_Por_Venta : Form
    {
        private List<Ventas> listaventas = new List<Ventas>();

        private List<TotalPorFecha> listafechas = new List<TotalPorFecha>();

        

        private Ventas ventas = null;


        public Venta_Por_Venta()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            VentaNegocio negocio = new VentaNegocio();
            listaventas = negocio.Listar_ventas();
            DgvVentas.DataSource = listaventas;
            



        }

        private void cargarVolver()
        {
            VentaNegocio negocio = new VentaNegocio();

            listaventas = negocio.Listar_ventas();

            DgvVentas.DataSource = listaventas;
        }

        private void cargarFecha(List<Ventas> listafecha, DateTime fecha)
        {
            
            VentaNegocio negocio = new VentaNegocio();

            listafecha = negocio.FiltrarFecha(fecha);

            DgvVentas.DataSource = listafecha;



        }

        private void cargarFechaTotal (List<TotalPorFecha> totalPorFechas, DateTime fecha)
        {
            TtotalPorFechNegocio negocio = new TtotalPorFechNegocio();

            totalPorFechas = negocio.TotalPorFechas(fecha);

            DgvTotalDia.DataSource = totalPorFechas;


        }

        private void VENTAS_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void BtnFiltrarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaseleccionada = DtpFiltro.Value.Date;

            VentaNegocio negocio = new VentaNegocio();

            List < Ventas > listafecha = negocio.FiltrarFecha(fechaseleccionada);


            cargarFecha(listafecha, fechaseleccionada);


        }

        private void BtnFiltrarTotal_Click(object sender, EventArgs e)
        {
            DateTime fechaseleccionada = DtpFiltro.Value.Date;

            TtotalPorFechNegocio negocio = new TtotalPorFechNegocio();

            List<TotalPorFecha> totalPorFechas = negocio.TotalPorFechas(fechaseleccionada);

            




        }

        private void BtnVolverVenta_Click(object sender, EventArgs e)
        {
            VentaNegocio negocio = new VentaNegocio();

            listaventas = negocio.Listar_ventas();

            DgvVentas.DataSource = listaventas;
        }

        private void BtnVolverFecha_Click(object sender, EventArgs e)
        {

            TtotalPorFechNegocio negocio = new TtotalPorFechNegocio();

            listafechas = negocio.listarFecha();

            DgvVentas.DataSource = listafechas;

        }

        private void BtnBorrarVenta_Click(object sender, EventArgs e)
        {
            VentaNegocio negocio = new VentaNegocio();
            Ventas seleccionado;

            try
            {

                DialogResult respuesta = MessageBox.Show("De verdad queres eliminar ese articulo?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Ventas)DgvVentas.CurrentRow.DataBoundItem;

                    negocio.EliminarVenta(seleccionado.Id);

                    cargarVolver();

        }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
