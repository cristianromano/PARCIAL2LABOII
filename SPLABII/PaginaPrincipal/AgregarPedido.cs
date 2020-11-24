using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace PaginaPrincipal
{
    public delegate void AgregarPedidos(Pedidos p);
    public partial class AgregarPedido : Form
    {
        public event AgregarPedidos Agregar;
        static Queue<Pedidos> ListaPedidos = new Queue<Pedidos>();
        List<Pedidos> pedidosXML = Comercio.LeerXml();
        Pedidos MiPedido;
        public AgregarPedido()
        {
            InitializeComponent();
        }

        private void AgregarPedido_Load(object sender, EventArgs e)
        {
            this.checkDelivery.Enabled = false;
            this.txtContacto.Enabled = false;
            this.txtDomicilio.Enabled = false;
            this.cmbProducto.DataSource = Enum.GetValues(typeof(EHamburguesas));
            this.cmbMedioPago.DataSource = Enum.GetValues(typeof(EMedioPago));
        }

        private void checkDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDelivery.Checked == true)
            {
                this.txtContacto.Enabled = true;
                this.txtDomicilio.Enabled = true;
            }

            else
            {
                this.txtContacto.Enabled = false;
                this.txtDomicilio.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                MiPedido = new Pedidos((EHamburguesas)this.cmbProducto.SelectedItem, (EMedioPago)this.cmbMedioPago.SelectedItem, this.txtDomicilio.Text, this.txtContacto.Text);               

                if (Comercio.ListaPedidos + MiPedido)
                {
                    MessageBox.Show("pedido cargado en la base de datos");
                    if (this.cmbMedioPago.SelectedItem.ToString() == "tarjeta")
                    {
                        MessageBox.Show("ticket generado con exito", "RECIBO X VENTA CON TARJETA");
                        Comercio.GuardarTextoDelivery(MiPedido);
                        ListaPedidos.Enqueue(MiPedido);
                        this.DialogResult = DialogResult.OK;
                    }
                }

                else
                {
                    throw new PedidosException("error al querer ingresar pedido a la base de datos");
                }
            }
            catch (PedidosException ex)
            {
                MessageBox.Show(ex.Message);
            }                               
        }

        public void pasarPedidos()
        {
            Random random = new Random();
            foreach (Pedidos item in pedidosXML)
            {
                ListaPedidos.Enqueue(item);

                Thread.Sleep(random.Next(1000,2000));
                Agregar.Invoke(ListaPedidos.Dequeue());
            }
        }

        private void cmbMedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMedioPago.SelectedItem.ToString() == "tarjeta")
            {
                this.checkDelivery.Checked = true;
            }
            else
            {
                this.txtContacto.Text = "";
                this.txtDomicilio.Text = "";
                this.checkDelivery.Checked = false;
            }
        }
    }
}
