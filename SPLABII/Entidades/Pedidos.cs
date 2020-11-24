using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EMedioPago
    {
        efectivo,
        tarjeta,
        cheque,
        medioElectronico
    }

    public enum EHamburguesas
    {
        HamburguesaSimple ,
        HamburguesaQueso,
        HamburguesaCompleta,
        HamburguesaMega
    }

    public class Pedidos
    {
        int id;
        EHamburguesas producto;
        EMedioPago pago;
        string domicilio;
        string numeroContacto;

        public Pedidos()
        {

        }

        public Pedidos(EHamburguesas producto, EMedioPago pago, string domicilio, string numeroContacto):this()
        {
            this.producto = producto;
            this.pago = pago;
            this.domicilio = domicilio;
            this.numeroContacto = numeroContacto;
        }

        public Pedidos(EHamburguesas producto,int id ,  EMedioPago pago, string domicilio, string numeroContacto) : this(producto, pago,domicilio,numeroContacto)
        {
            this.Id = id;
        }



        public int Id { get => id; set => id = value; }
        public EMedioPago Pago { get => pago; set => pago = value; }
        public EHamburguesas Producto { get => producto; set => producto = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string NumeroContacto { get => numeroContacto; set => numeroContacto = value; }


        public bool Guardar()
        {
            return PedidosDAO.InsertarPedidos(this);
        }

        public static bool operator ==(List<Pedidos> Pedidos, Pedidos pedido)
        {
            bool retorno = false;

            foreach (Pedidos item in Pedidos)
            {
                if (item.Id == pedido.Id)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// niega el metodo ==
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>bool</returns>
        public static bool operator !=(List<Pedidos> Pedidos, Pedidos pedido)
        {
            return !(Pedidos == pedido);
        }

        /// <summary>
        /// agrega un nuevo producto a la base de datos
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns>bool</returns>
        public static bool operator +(List<Pedidos> Pedidos, Pedidos pedido)
        {
            bool retorno = false;

            if (Pedidos != pedido)
            {
                pedido.Guardar();
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// elimina un producto de la base de datos
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator -(List<Pedidos> Pedidos, Pedidos pedido)
        {
            bool retorno = false;

            foreach (Pedidos item in Pedidos)
            {
                if (item.id == pedido.id)
                {
                  //  producto.Eliminar();
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public override string ToString()
        {
            Random rd = new Random();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"------------------------------");
            sb.AppendLine("------TICKET DE PEDIDO---------");
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"Hora: {DateTime.Now.ToString("G")}");
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"-----DELIVERY DE COMERCIO-----");
            sb.AppendLine($"------------------------------");


            sb.AppendLine($"Producto: {Producto}");
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"Domicilio: {Domicilio}");
            sb.AppendLine($"Conctacto: {NumeroContacto}");

            sb.AppendLine($"Medio de Pago: {Pago}");
            sb.AppendLine($"Monto Final: ${rd.Next(200, 650)}");
            sb.AppendLine($"------------------------------");
            sb.AppendLine($"----GRACIAS POR TU COMPRA-----");

            return sb.ToString();
        }

    }
}
