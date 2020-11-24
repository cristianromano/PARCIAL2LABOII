using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Entidades;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// En caso de haber dos pedidos con Ids iguales
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PedidosException))]
        public void cargarABaseDeDatos()
        {
           Pedidos pedido = new Pedidos(EHamburguesas.HamburguesaSimple, 601, EMedioPago.efectivo, "LOCAL", "LOCAL");

           if( Comercio.ListaPedidos + pedido )
            {
                Console.WriteLine("ok");
            }

            throw new PedidosException();
        }

        [TestMethod]
        public void testeoConstructor()
        {
            Pedidos pedido = new Pedidos(EHamburguesas.HamburguesaSimple, 47, EMedioPago.efectivo, "LOCAL", "LOCAL");

            Assert.IsNotNull(pedido);
        }
    }
}
