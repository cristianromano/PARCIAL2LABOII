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

namespace PaginaPrincipal
{
    public delegate void PedidoListo();
    public partial class PaginaPrincipal : Form
    {
        AgregarPedido formAgregar = new AgregarPedido();
        static List<Pedidos> aux = new List<Pedidos>();
        static Queue<Pedidos> listosPedidos = new Queue<Pedidos>();
        static List<Pedidos> listos = new List<Pedidos>();
        Thread hilo;
        Thread hiloPedidosListos;
        Random rd = new Random();
        public event PedidoListo eventoPedidos;
        int flag = 0;

        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formAgregar.Agregar += muestroPedidos;
            eventoPedidos += dispararEvento;
            //eventoPedidos += removerLista;
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            AgregarPedido pedido = new AgregarPedido();

            if (pedido.ShowDialog() == DialogResult.OK)
            {
                // RefrescarDataGrid();
            }
        }

        private void RefrescarDataGrid()
        {
            dtgPedidoPreparacion.DataSource = Comercio.ListaPedidos;
            dtgPedidoPreparacion.DataSource = null;
            dtgPedidoPreparacion.DataSource = Comercio.ListaPedidos;
        }
        private void btnComenzarPedidos_Click(object sender, EventArgs e)
        {
            aux.Clear();
            hilo = new Thread(formAgregar.pasarPedidos);
            hilo.Start();
        }

        public void muestroPedidos(Pedidos p)
        {
            if (this.InvokeRequired)
            {
                AgregarPedidos del = new AgregarPedidos(this.muestroPedidos);
                this.Invoke(del, new object[] { p });
            }
            else
            {
                aux.Add(p);

                dtgPedidoPreparacion.DataSource = aux;
                dtgPedidoPreparacion.DataSource = null;
                dtgPedidoPreparacion.DataSource = aux;
                dtgPedidoPreparacion.Columns.Remove("Id");

                if (aux.Count > 0)
                {
                    eventoPedidos.BeginInvoke(null, null);
                }               
            }
        }

        public void dispararEvento()
        {
            Thread.Sleep(8000);
            hiloPedidosListos = new Thread(this.removerLista);
            hiloPedidosListos.Start();
        }

        public void removerLista()
        {
            if (this.InvokeRequired)
            {
                PedidoListo del = new PedidoListo(this.removerLista);
                this.BeginInvoke(del, null);
            }

            else
            {
                Random randonIndice = new Random();
                int indiceLista = randonIndice.Next(0, aux.Count);
                listosPedidos.Enqueue(aux[indiceLista]);
                aux.RemoveAt(indiceLista);
                this.dtgPedidoPreparacion.DataSource = aux;
                this.dtgPedidoPreparacion.DataSource = null;
                this.dtgPedidoPreparacion.DataSource = aux;
                dtgPedidoPreparacion.Columns.Remove("Id");
                listos.Add(listosPedidos.Dequeue());
                dtgPedidoListo.DataSource = listos;
                dtgPedidoListo.DataSource = null;
                dtgPedidoListo.DataSource = listos;
                dtgPedidoListo.Columns.Remove("Id");
            }
        }

        public void pedidosListos(Queue<Pedidos> aux)
        {
            listos.Add(aux.Dequeue());
            dtgPedidoListo.DataSource = listos;
            dtgPedidoListo.DataSource = null;
            dtgPedidoListo.DataSource = listos;
            dtgPedidoListo.Columns.Remove("Id");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(hilo is null) && hilo.IsAlive)
            {
                hilo.Abort();
            }
            Comercio.GuardarXml(Comercio.ListaPedidos);
        }
    }
}
