namespace PaginaPrincipal
{
    partial class AgregarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.lbMedioPago = new System.Windows.Forms.Label();
            this.lbProducto = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbDomicilio = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.checkDelivery = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(96, 29);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 2;
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(96, 67);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(121, 21);
            this.cmbMedioPago.TabIndex = 3;
            this.cmbMedioPago.SelectedIndexChanged += new System.EventHandler(this.cmbMedioPago_SelectedIndexChanged);
            // 
            // lbMedioPago
            // 
            this.lbMedioPago.AutoSize = true;
            this.lbMedioPago.Location = new System.Drawing.Point(11, 70);
            this.lbMedioPago.Name = "lbMedioPago";
            this.lbMedioPago.Size = new System.Drawing.Size(79, 13);
            this.lbMedioPago.TabIndex = 5;
            this.lbMedioPago.Text = "Medio de Pago";
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Location = new System.Drawing.Point(35, 32);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(55, 13);
            this.lbProducto.TabIndex = 6;
            this.lbProducto.Text = "Productos";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(71, 184);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbDomicilio
            // 
            this.lbDomicilio.AutoSize = true;
            this.lbDomicilio.Location = new System.Drawing.Point(41, 113);
            this.lbDomicilio.Name = "lbDomicilio";
            this.lbDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lbDomicilio.TabIndex = 12;
            this.lbDomicilio.Text = "Domicilio";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(0, 149);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(90, 13);
            this.lbTelefono.TabIndex = 13;
            this.lbTelefono.Text = "Numero Contacto";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(96, 110);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(121, 20);
            this.txtDomicilio.TabIndex = 14;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(96, 146);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(121, 20);
            this.txtContacto.TabIndex = 15;
            // 
            // checkDelivery
            // 
            this.checkDelivery.AutoSize = true;
            this.checkDelivery.Location = new System.Drawing.Point(167, 188);
            this.checkDelivery.Name = "checkDelivery";
            this.checkDelivery.Size = new System.Drawing.Size(64, 17);
            this.checkDelivery.TabIndex = 16;
            this.checkDelivery.Text = "Delivery";
            this.checkDelivery.UseVisualStyleBackColor = true;
            this.checkDelivery.CheckedChanged += new System.EventHandler(this.checkDelivery_CheckedChanged);
            // 
            // AgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 240);
            this.Controls.Add(this.checkDelivery);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbDomicilio);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.lbMedioPago);
            this.Controls.Add(this.cmbMedioPago);
            this.Controls.Add(this.cmbProducto);
            this.Name = "AgregarPedido";
            this.Text = "AgregarPedido";
            this.Load += new System.EventHandler(this.AgregarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Label lbMedioPago;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbDomicilio;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.CheckBox checkDelivery;
    }
}