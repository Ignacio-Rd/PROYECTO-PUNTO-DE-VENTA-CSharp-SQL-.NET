using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocios;


namespace Negocio_
{
   public class MetodoDePagoNegocio
    {

        public List<Metodo_de_pago> Listametodo()
        {
            List<Metodo_de_pago> lista = new List<Metodo_de_pago>();

            AccesoDATOS datos = new AccesoDATOS();

            try
            {

                datos.SetearConsulta("select id_metodo, metodo_pago, porcentaje from metodos_de_pago");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Metodo_de_pago aux = new Metodo_de_pago();
                    aux.id = (int)datos.Lector["id_metodo"];
                    aux.MetodoPago = (string)datos.Lector["metodo_pago"];
                    aux.porcentaje = (decimal)datos.Lector["porcentaje"];


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

        public void agregarMetodopago(Metodo_de_pago nuevo)
        {
            AccesoDATOS datos = new AccesoDATOS();

            try
            {
                datos.SetearConsulta("insert into metodos_de_pago(metodo_pago, porcentaje) values(@metodo, @porcentaje)");
                datos.setearParametro("@metodo", nuevo.MetodoPago);
                datos.setearParametro("@porcentaje", nuevo.porcentaje);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void EliminarMetodoPago (int id)
        {
            try
            {
                AccesoDATOS datos = new AccesoDATOS();
                datos.SetearConsulta("delete from metodos_de_pago where id_metodo = @id");
                datos.setearParametro("@id", id);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public decimal Elegir_metodopago(decimal precio, string metodo)
        {
            decimal porcentaje = 0;


            if (!string.IsNullOrEmpty(metodo))
            {
                AccesoDATOS datos = new AccesoDATOS();

                try
                {
                    datos.SetearConsulta("select porcentaje from metodos_de_pago where metodo_pago = @metodo");
                    datos.setearParametro("@metodo", metodo);

                    datos.EjecutarLectura();


                    if (datos.Lector.Read())
                    {
                        porcentaje = (decimal)datos.Lector["porcentaje"];
                    }

                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    datos.CerrarConexion();
                }

                precio += precio * (porcentaje / 100);

                return precio;


            }

            return precio;
        }





    }
    }

