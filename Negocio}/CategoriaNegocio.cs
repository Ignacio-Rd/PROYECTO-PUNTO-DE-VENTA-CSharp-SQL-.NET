﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocios;

namespace Negocios
{
   public class CategoriaNegocio
    {
        public List<categoria> listarCategoria()
        {
            List<categoria> lista = new List<categoria>();

            AccesoDATOS datos = new AccesoDATOS();

            try
            {
                datos.SetearConsulta("select id, descripcion from CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    categoria aux = new categoria();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Descripcion = (string)datos.Lector["descripcion"];

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

        public void agregarCategoria (categoria nuevo)
        {
            AccesoDATOS datos = new AccesoDATOS();

            try
            {

                datos.SetearConsulta("insert into CATEGORIAS(Descripcion)values(@categoria)");

                datos.setearParametro("categoria", nuevo.Descripcion);

                datos.EjecutarAccion();
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

        public void eliminarCategoria(int id)
        {
            try
            {

                AccesoDATOS datos = new AccesoDATOS();
                datos.SetearConsulta("DELETE FROM CATEGORIAS WHERE Id = @id");
                datos.setearParametro("@id", id);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {



                throw ex;
            }
        }




    }
}
