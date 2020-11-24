namespace PaginaPrincipal
{
    partial class PaginaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgPedidoListo = new System.Windows.Forms.DataGridView();
            this.dtgPedidoPreparacion = new System.Windows.Forms.DataGridView();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnComenzarPedidos = new System.Windows.Forms.Button();
            this.lbTerminado = new System.Windows.Forms.Label();
            this.lbPreparacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidoListo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidoPreparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPedidoListo
            // 
            this.dtgPedidoListo.AllowUserToAddRows = false;
            this.dtgPedidoListo.AllowUserToDeleteRows = false;
            this.dtgPedidoListo.AllowUserToResizeColumns = false;
            this.dtgPedidoListo.AllowUserToResizeRows = false;
            this.dtgPedidoListo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPedidoListo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPedidoListo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidoListo.ColumnHeadersVisible = false;
            this.dtgPedidoListo.Location = new System.Drawing.Point(12, 34);
            this.dtgPedidoListo.Name = "dtgPedidoListo";
            this.dtgPedidoListo.RowHeadersVisible = false;
            this.dtgPedidoListo.Size = new System.Drawing.Size(537, 253);
            this.dtgPedidoListo.TabIndex = 0;
            // 
            // dtgPedidoPreparacion
            // 
            this.dtgPedidoPreparacion.AllowUserToAddRows = false;
            this.dtgPedidoPreparacion.AllowUserToDeleteRows = false;
            this.dtgPedidoPreparacion.AllowUserToResizeColumns = false;
            this.dtgPedidoPreparacion.AllowUserToResizeRows = false;
            this.dtgPedidoPreparacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPedidoPreparacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPedidoPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidoPreparacion.ColumnHeadersVisible = false;
            this.dtgPedidoPreparacion.Location = new System.Drawing.Point(561, 34);
            this.dtgPedidoPreparacion.Name = "dtgPedidoPreparacion";
            this.dtgPedidoPreparacion.ReadOnly = true;
            this.dtgPedidoPreparacion.RowHeadersVisible = false;
            this.dtgPedidoPreparacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgPedidoPreparacion.Size = new System.Drawing.Size(537, 253);
            this.dtgPedidoPreparacion.TabIndex = 1;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(204, 304);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarPedido.TabIndex = 2;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnComenzarPedidos
            // 
            this.btnComenzarPedidos.Location = new System.Drawing.Point(975, 293);
            this.btnComenzarPedidos.Name = "btnComenzarPedidos";
            this.btnComenzarPedidos.Size = new System.Drawing.Size(123, 23);
            this.btnComenzarPedidos.TabIndex = 3;
            this.btnComenzarPedidos.Text = "Comenzar";
            this.btnComenzarPedidos.UseVisualStyleBackColor = true;
            this.btnComenzarPedidos.Click += new System.EventHandler(this.btnComenzarPedidos_Click);
            // 
            // lbTerminado
            // 
            this.lbTerminado.AutoSize = true;
            this.lbTerminado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTerminado.Location = new System.Drawing.Point(160, 8);
            this.lbTerminado.Name = "lbTerminado";
            this.lbTerminado.Size = new System.Drawing.Size(195, 23);
            this.lbTerminado.TabIndex = 4;
            this.lbTerminado.Text = "PRODUCTO TERMINADO";
            // 
            // lbPreparacion
            // 
            this.lbPreparacion.AutoSize = true;
            this.lbPreparacion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreparacion.Location = new System.Drawing.Point(756, 8);
            this.lbPreparacion.Name = "lbPreparacion";
            this.lbPreparacion.Size = new System.Drawing.Size(147, 23);
            this.lbPreparacion.TabIndex = 5;
            this.lbPreparacion.Text = "EN PREPARACION";
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 351);
            this.Controls.Add(this.lbPreparacion);
            this.Controls.Add(this.lbTerminado);
            this.Controls.Add(this.btnComenzarPedidos);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.dtgPedidoPreparacion);
            this.Controls.Add(this.dtgPedidoListo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaginaPrincipal";
            this.Text = "SISTEMA DE PEDIDOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidoListo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidoPreparacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPedidoListo;
        private System.Windows.Forms.DataGridView dtgPedidoPreparacion;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnComenzarPedidos;
        private System.Windows.Forms.Label lbTerminado;
        private System.Windows.Forms.Label lbPreparacion;
    }
}

