using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class PedidosException:Exception
    {
        public PedidosException() : base("error con el pedido")
        {

        }

        public PedidosException(string mensaje):base(mensaje)
        {

        }

        public PedidosException(string mensaje , Exception e):base(mensaje , e)
        {

        }

    }
}
