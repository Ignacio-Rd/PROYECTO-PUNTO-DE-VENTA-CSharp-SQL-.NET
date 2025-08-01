using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Negocios;


namespace Negocios
{
    class AccesoDATOS
    {

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDATOS()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB_RECUPERADA; integrated security=true");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select Codigo, Nombre, A.Descripcion Descripcion, ImagenUrl, Precio, C.Descripcion Tipo, M.Descripcion Marca , Stock from ARTICULOS A, CATEGORIAS C, MARCAS M where IdMarca = M.Id and IdCategoria = C.Id";
            comando.Connection = conexion;
        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }


        public void EjecutarLectura()
        {
            comando.Connection = conexion;

            try
            {

                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EjecutarAccion()
        {
            comando.Connection = conexion;


            try
            {

                conexion.Open();
                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);

        }

        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();


        }


    }
}
