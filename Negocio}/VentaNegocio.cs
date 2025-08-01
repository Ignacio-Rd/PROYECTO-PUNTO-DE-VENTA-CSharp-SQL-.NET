using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocios;
using System.Data.SqlClient;

namespace Negocio_
{
    public class VentaNegocio
    {

        public List<Ventas> Listar_ventas()
        {
            List<Ventas> lista = new List<Ventas>();

            AccesoDATOS datos = new AccesoDATOS();

            try
            {

                datos.SetearConsulta("select Fecha, Total, Id from Ventas");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {

                    Ventas aux = new Ventas();
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Total = (decimal)datos.Lector["Total"];
                    aux.Id = (int)datos.Lector["Id"];

                    lista.Add(aux);
                }

                return lista;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        public void Agregar_venta (DateTime fecha , decimal Total)
        {
            Ventas venta = new Ventas();

            AccesoDATOS datos = new AccesoDATOS();

            try
            {

                datos.SetearConsulta("insert into Ventas(Fecha, Total) values (@fecha, @total)");
                datos.setearParametro("@fecha", fecha);
                datos.setearParametro("@total", Total);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public List<Ventas> FiltrarFecha(DateTime fecha)
        {
            List<Ventas> lista = new List<Ventas>();
            AccesoDATOS datos = new AccesoDATOS();

            try
            {

                string consulta = "SELECT Fecha, Total FROM Ventas WHERE CONVERT(date, Fecha) = @fecha";

                datos.SetearConsulta(consulta);
                datos.setearParametro("@fecha", fecha.Date);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {

                    Ventas aux = new Ventas();
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Total = (decimal)datos.Lector["Total"];
                    

                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                datos.CerrarConexion();
            }
        }


            public void EliminarVenta (int Id)
            {
                try
                {

                    AccesoDATOS datos = new AccesoDATOS();
                    datos.SetearConsulta("DELETE FROM VENTAS WHERE Id = @id");
                    datos.setearParametro("@id", Id);

                    datos.EjecutarAccion();

                }
                catch (Exception ex)
                {



                    throw ex;
                }
            }



        }
}

        


       