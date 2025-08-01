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
using Negocio_;
using Dominio;

namespace TPFinalNivel2_RuizDiaz
{
    public partial class FormularioPrincipal : Form
    {

        private Timer timerCierre = new Timer();
        private bool cierreHechoHoy = false;

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirFormulario_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.ShowDialog();

        }



      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registradora_Click(object sender, EventArgs e)
        {
            REGISTRADORA_DE_COMPRAS formulario = new REGISTRADORA_DE_COMPRAS();
            formulario.ShowDialog();
        }

        private void Metodo_de_pago_Click(object sender, EventArgs e)
        {
            formas_de_pago formulario = new formas_de_pago();
            formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venta_Por_Venta formulario = new Venta_Por_Venta();
            formulario.ShowDialog();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            timerCierre.Interval = 60000; // 1 minuto
            timerCierre.Tick += TimerCierre_Tick;
            timerCierre.Start();
        }

        private void TimerCierre_Tick(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;

            // Chequeamos si son las 23:59 y aún no hicimos el cierre hoy
            if (ahora.Hour == 23 && ahora.Minute == 59 && !cierreHechoHoy)
            {
                RegistrarGananciaDelDia();
                cierreHechoHoy = true;
            }

            // Si cambia el día, reseteamos la bandera
            if (ahora.Hour == 0 && ahora.Minute == 0)
            {
                cierreHechoHoy = false;
            }
        }

        private void RegistrarGananciaDelDia()
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            TtotalPorFechNegocio totalNegocio = new TtotalPorFechNegocio();
            decimal total;

            

            DateTime hoy = DateTime.Today;

           
            decimal totalHoy = totalNegocio.CalcularTotalDelDia(hoy);

            totalNegocio.Agregar_Total_Diario(hoy, totalHoy);


            if (totalHoy > 0)
            {
                totalNegocio.Agregar_Total_Diario(hoy, totalHoy);
                MessageBox.Show("Ganancia diaria registrada automáticamente: $" + totalHoy);
            }

            MessageBox.Show("Ganancia diaria registrada automáticamente: $" + totalHoy);

        }
    }
}
