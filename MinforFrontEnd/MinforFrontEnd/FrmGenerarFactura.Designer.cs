namespace MinforFrontEnd
{
    partial class FrmGenerarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarFactura));
            this.lblCedula = new System.Windows.Forms.Label();
            this.dgvItemsVendidos = new System.Windows.Forms.DataGridView();
            this.id_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId_Cliente = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsVendidos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(263, 23);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(196, 17);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Numero de cedula del cliente:";
            // 
            // dgvItemsVendidos
            // 
            this.dgvItemsVendidos.AllowUserToAddRows = false;
            this.dgvItemsVendidos.AllowUserToDeleteRows = false;
            this.dgvItemsVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Articulo,
            this.Cantidad,
            this.Descripcion,
            this.Precio,
            this.Importe});
            this.dgvItemsVendidos.Location = new System.Drawing.Point(3, 3);
            this.dgvItemsVendidos.Name = "dgvItemsVendidos";
            this.dgvItemsVendidos.ReadOnly = true;
            this.dgvItemsVendidos.RowTemplate.Height = 24;
            this.dgvItemsVendidos.Size = new System.Drawing.Size(545, 367);
            this.dgvItemsVendidos.TabIndex = 3;
            // 
            // id_Articulo
            // 
            this.id_Articulo.HeaderText = "Id Articulo";
            this.id_Articulo.Name = "id_Articulo";
            this.id_Articulo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.Location = new System.Drawing.Point(461, 18);
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.Size = new System.Drawing.Size(200, 22);
            this.txtId_Cliente.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(153, 376);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(87, 22);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 373);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total de la factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Location = new System.Drawing.Point(487, 72);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(71, 17);
            this.lblDireccionCliente.TabIndex = 11;
            this.lblDireccionCliente.Text = "Dirección:";
            this.lblDireccionCliente.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(205, 60);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(237, 38);
            this.txtNombreCliente.TabIndex = 14;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(125, 72);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(55, 17);
            this.lblNombreCliente.TabIndex = 13;
            this.lblNombreCliente.Text = "Cliente:";
            this.lblNombreCliente.Click += new System.EventHandler(this.label5_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvItemsVendidos);
            this.flowLayoutPanel1.Controls.Add(this.lblTotal);
            this.flowLayoutPanel1.Controls.Add(this.txtTotal);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(205, 146);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(548, 431);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(574, 60);
            this.txtDireccionCliente.Multiline = true;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(237, 38);
            this.txtDireccionCliente.TabIndex = 16;
            // 
            // GenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 646);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblDireccionCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId_Cliente);
            this.Controls.Add(this.lblCedula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerarFactura";
            this.Text = "GenerarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsVendidos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.DataGridView dgvItemsVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.TextBox txtId_Cliente;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtDireccionCliente;
    }
}