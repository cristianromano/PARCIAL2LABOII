using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public static class MetodosExtension
    {

        public static string ProductoYID(this Pedidos pedido)
        {
            string producto = pedido.Producto.ToString().Substring(0, 11) + " " + pedido.Producto.ToString().Substring(11);

            return $"El pedido es el numero {pedido.Id} y es una {producto}";
        }



    }
}
