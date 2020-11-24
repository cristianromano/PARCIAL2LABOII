using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Pedidos> aux = new List<Pedidos>();

            aux = Comercio.ListaPedidos;

            Console.WriteLine(aux[0].ToString());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Pedidos pedido = new Pedidos(EHamburguesas.HamburguesaCompleta, 785241 , EMedioPago.medioElectronico, "local", "local");

            Console.WriteLine(pedido.ProductoYID());

            Console.ReadKey();
        }
    }
}
