using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class  PedidosDAO
    {
        #region Atributos
        private static SqlConnection conexion;
        private static SqlCommand comando;
        #endregion

        #region Constructores
        static PedidosDAO()
        {
            conexion = new SqlConnection("Data Source=DESKTOP-VSLISER\\SQLEXPRESS; Initial Catalog=ComercioHamburguesas; Integrated Security=True;");
            comando = new SqlCommand();

            comando.Connection = conexion;

            comando.CommandType = CommandType.Text;
        }
        #endregion

        #region Métodos

        #region Getters
        public static List<Pedidos> ObtenerPedidos()
        {
            List<Pedidos> pedidos = new List<Pedidos>();

            try
            {
                comando.CommandText = "SELECT * FROM ComercioHamburguesas";
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
        
                while (lector.Read())
                {
                    pedidos.Add(new Pedidos( PedidosDAO.casteoProducto( lector["producto"].ToString() ),  int.Parse(lector["Id"].ToString()) , (EMedioPago)Enum.Parse(typeof(EMedioPago), lector["medioDePago"].ToString() ) , lector["domicilio"].ToString() , lector["contactoNumero"].ToString()  ) );
                }
                
                lector.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conexion.Close();
            }

            return pedidos;

            //(EHamburguesas)Enum.Parse(typeof(EHamburguesas), lector["producto"].ToString() )

        }
        #endregion

        #region Insertar Persona
        public static bool InsertarPedidos(Pedidos p)
        {
            int longitudProductoLetras = p.Producto.ToString().Length ;
            string producto = p.Producto.ToString().Substring(0, 11) + " " + p.Producto.ToString().Substring(11);

            string sql = "INSERT INTO ComercioHamburguesas(producto,medioDePago,domicilio,contactoNumero)" +
                $"VALUES(@producto,@medioDePago , @domicilio , @contactoNumero  )";

            if (string.IsNullOrWhiteSpace(p.Domicilio) && string.IsNullOrWhiteSpace(p.NumeroContacto))
            {
                p.Domicilio = "EN LOCAL";
                p.NumeroContacto = "EN LOCAL";
            }
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("producto", producto);
            comando.Parameters.AddWithValue("medioDePago", p.Pago.ToString()); 
            comando.Parameters.AddWithValue("domicilio", p.Domicilio);
            comando.Parameters.AddWithValue("contactoNumero", p.NumeroContacto);

            return EjecutarNonQuery(sql);

        }
        #endregion

        #region Modificar Producto
        public static bool ModificarPedidos(Pedidos p)
        {
            string sql = "UPDATE ComercioHamburguesas SET producto = @producto  , domicilio = @domicilio  , contactoNumero = @contacto , medioDePago = @medioDePago where Id = @id ";

            comando.Parameters.Clear();
            comando.Parameters.Add(new SqlParameter("@producto", p.Producto.ToString()));
            comando.Parameters.Add(new SqlParameter("@domicilio", p.Domicilio));
            comando.Parameters.Add(new SqlParameter("@contacto", p.NumeroContacto));
            comando.Parameters.Add(new SqlParameter("@medioDePago", p.Pago.ToString()));
            comando.Parameters.Add(new SqlParameter("@id", p.Id));

            return EjecutarNonQuery(sql);

        }

        #endregion

        #region Eliminar Producto
        public static bool EliminarPedidos(Pedidos p)
        {

            string sql = "DELETE FROM ComercioHamburguesas WHERE Id = @auxId";

            comando.Parameters.Clear();
            comando.Parameters.Add(new SqlParameter("@auxID", p.Id));

            return EjecutarNonQuery(sql);
        }
        #endregion

        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                PedidosDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                PedidosDAO.conexion.Open();

                // EJECUTO EL COMMAND
                PedidosDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                conexion.Close();
            }
            return todoOk;
        }


        public static EHamburguesas casteoProducto(string aux)
        {
            switch (aux)
            {
                case "Hamburguesa Simple":
                return EHamburguesas.HamburguesaSimple;

                case "Hamburguesa Completa":
                return EHamburguesas.HamburguesaCompleta;

                case "Hamburguesa Con Queso":
                return EHamburguesas.HamburguesaQueso;

                case "Hamburguesa Mega":
                return EHamburguesas.HamburguesaMega;

                default:
                return EHamburguesas.HamburguesaSimple;
            }

        }

        #endregion
    }
}
