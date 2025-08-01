using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocios;

namespace Negocios
{
   public class ArticuloNegocio
    {

        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB_RECUPERADA; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre, A.Descripcion Descripcion, ImagenUrl, Precio, C.Descripcion Tipo, M.Descripcion Marca, A.IdMarca, A.IdCategoria, A.Id, Stock from ARTICULOS A, CATEGORIAS C, MARCAS M where IdMarca = M.Id and IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {


                    Articulos aux = new Articulos();
                    aux.Id = (int)lector["Id"];
                    aux.codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];


                    if (!(lector["ImagenUrl"] is DBNull))
                    {
                        aux.URL = (string)lector["ImagenUrl"];
                    }

                    aux.Precio = Math.Round(lector.GetDecimal(4), 2, MidpointRounding.AwayFromZero);
                    aux.Categoria = new categoria();
                    aux.Categoria.Descripcion = (string)lector["Tipo"];
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Stock = (int)lector["Stock"];

                    lista.Add(aux);


                }

                conexion.Close();

                return lista;




            }
            catch (Exception ex)
            {

                throw ex;
            }


          

        }

        public void Agregar(Articulos nuevo)
        {

            AccesoDATOS datos = new AccesoDATOS();

            try
            {

                datos.SetearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio, Stock) values ('" + nuevo.codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "', @idMarca, @idCategoria, @Precio, @stock )");

                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@stock", nuevo.Stock);

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

        public void Modificar(Articulos modificar)
        {

            AccesoDATOS datos = new AccesoDATOS();

            try
            {
                datos.SetearConsulta("update ARTICULOS set  Codigo = @codigo , Nombre = @nombre, Descripcion = @descripcion , IdMarca = @idmarca, IdCategoria = @idcategoria, Precio = @precio, Stock = @stock where id = @id");
                datos.setearParametro("@codigo", modificar.codigo );
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@idmarca", modificar.Marca.Id);
                datos.setearParametro("@idcategoria", modificar.Categoria.Id);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@id", modificar.Id);
                datos.setearParametro("@stock", modificar.Stock);

                datos.EjecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Articulos> filtrar(string campo, string criterio, string filtro)
        {

            //"Código","Precio","Nombre","Marca","Cateogoria")

            List<Articulos> lista = new List<Articulos>();
            AccesoDATOS datos = new AccesoDATOS();
            try
            {
                string consulta = "select Codigo, Nombre, A.Descripcion Descripcion, ImagenUrl, Precio, C.Descripcion Tipo, M.Descripcion Marca, A.IdMarca, A.IdCategoria, A.Id, Stock from ARTICULOS A, CATEGORIAS C, MARCAS M where IdMarca = M.Id and IdCategoria = C.Id and ";

                if (campo == "Precio")
                {

                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += " Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += " Precio < " + filtro;
                            break;
                        default:
                            consulta += " Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Código")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Codigo like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Codigo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Codigo like '%" + filtro + "%'";
                            break;
                    }
                }
                else if(campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else if(campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "M.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "M.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "C.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {


                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];


                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.URL = (string)datos.Lector["ImagenUrl"];
                    }

                    aux.Precio = datos.Lector.GetDecimal(4);
                    aux.Categoria = new categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Stock = (int)datos.Lector["Stock"];

                    lista.Add(aux);


                }


                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar (int Id)
        {
            try
            {

                AccesoDATOS datos = new AccesoDATOS();
                datos.SetearConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
                datos.setearParametro("@id", Id);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {



                throw ex;
            }
        }

        public List<Articulos> Obtener_Por_Codigo(string codigo)
        {

            try
            {
                List<Articulos> lista = new List<Articulos>();
                AccesoDATOS datos = new AccesoDATOS();
                Articulos articulos = new Articulos();


                datos.SetearConsulta("select Codigo, Nombre, A.Descripcion Descripcion, ImagenUrl, Precio, C.Descripcion Tipo, M.Descripcion Marca, A.IdMarca, A.IdCategoria, A.Id, Stock from ARTICULOS A, CATEGORIAS C, MARCAS M where IdMarca = M.Id and IdCategoria = C.Id and A.Codigo = @codigo");
                datos.setearParametro("@codigo", codigo);

                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {


                    Articulos aux = new Articulos();
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    



                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.URL = (string)datos.Lector["ImagenUrl"];
                    }

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];

                    lista.Add(aux);


                }

                Descontar_Stock(codigo);

                return lista;

            }
            
            catch (Exception EX)
            {

                throw EX;
            }

         }

        public void Descontar_Stock(string producto)
        {
            AccesoDATOS datos = new AccesoDATOS();

            try
            {
                // Resta 1 al stock del producto cuyo código coincide
                datos.SetearConsulta("UPDATE ARTICULOS SET Stock = Stock - 1 WHERE Codigo = @codigo AND Stock > 0");
                datos.setearParametro("@codigo", producto);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex; // o podrías manejarlo con un mensaje personalizado
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Reponer_Stock(string producto)
        {
            AccesoDATOS datos = new AccesoDATOS();

            try
            {
                // Suma 1 al stock del producto cuyo código coincide
                datos.SetearConsulta("UPDATE ARTICULOS SET Stock = Stock + 1 WHERE Codigo = @codigo");
                datos.setearParametro("@codigo", producto);
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






    }


}

    

