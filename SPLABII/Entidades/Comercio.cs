using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public class Comercio
    {
        static List<Pedidos> listaPedidos;

        static Comercio()
        {
            listaPedidos = new List<Pedidos>();
        }

        public static List<Pedidos> ListaPedidos
        {
            get
            {
                return PedidosDAO.ObtenerPedidos();
            }
        }

        public static List<Pedidos> PedidosListado { get => listaPedidos; set => listaPedidos = value; }     

        public static List<Pedidos> LeerXml()
        {
            List<Pedidos> aux = new List<Pedidos>();
            
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "pedidos.xml");
            Xml<List<Pedidos>> xmlProducto = new Xml<List<Pedidos>>();
            xmlProducto.Leer(path, out aux);

            return aux;
        }

        public static bool GuardarXml(List<Pedidos> productos)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "pedidos.xml");
            Xml<List<Pedidos>> dato = new Xml<List<Pedidos>>();

            return dato.Guardar(path, productos);
        }

        public static bool GuardarTextoDelivery(Pedidos pedido)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "TICKET PEDIDO DELIVERY");
            Texto txt = new Texto();
            return txt.Guardar(path, pedido.ToString());
        } 

    }
}
