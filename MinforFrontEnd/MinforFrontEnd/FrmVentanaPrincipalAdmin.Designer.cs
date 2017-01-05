namespace MinforFrontEnd
{
    partial class FrmVentanaPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentanaPrincipalAdmin));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarCargo = new System.Windows.Forms.Button();
            this.btnModificarCargo = new System.Windows.Forms.Button();
            this.btnNuevoCargo = new System.Windows.Forms.Button();
            this.btnMostrarVentas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarInventario = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarInventario = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(880, 718);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDireccionCliente);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDireccionCliente);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bienvenido:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(459, 84);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(237, 38);
            this.txtTime.TabIndex = 28;
            this.txtTime.Text = "11:30:53 PM";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(90, 39);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(237, 38);
            this.txtNombreCliente.TabIndex = 23;
            this.txtNombreCliente.Text = "All Mighty Dev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Hora:";
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Location = new System.Drawing.Point(375, 42);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(78, 25);
            this.lblDireccionCliente.TabIndex = 21;
            this.lblDireccionCliente.Text = "Cargo:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(90, 84);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(237, 38);
            this.txtDate.TabIndex = 26;
            this.txtDate.Text = "04/Jan/2017";
            this.txtDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(2, 42);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(93, 25);
            this.lblNombreCliente.TabIndex = 22;
            this.lblNombreCliente.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fecha:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(459, 39);
            this.txtDireccionCliente.Multiline = true;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(237, 38);
            this.txtDireccionCliente.TabIndex = 24;
            this.txtDireccionCliente.Text = "Developer";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnEliminarCargo);
            this.groupBox2.Controls.Add(this.btnModificarCargo);
            this.groupBox2.Controls.Add(this.btnNuevoCargo);
            this.groupBox2.Controls.Add(this.btnMostrarVentas);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnEliminarProducto);
            this.groupBox2.Controls.Add(this.btnModificarInventario);
            this.groupBox2.Controls.Add(this.btnModificarCliente);
            this.groupBox2.Controls.Add(this.btnModificarEmpleado);
            this.groupBox2.Controls.Add(this.btnEliminarEmpleado);
            this.groupBox2.Controls.Add(this.btnRegistrarEmpleado);
            this.groupBox2.Controls.Add(this.btnAgregarInventario);
            this.groupBox2.Controls.Add(this.btnInventario);
            this.groupBox2.Controls.Add(this.btnEliminarCliente);
            this.groupBox2.Controls.Add(this.btnRegistrarCliente);
            this.groupBox2.Controls.Add(this.btnFactura);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 530);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione una opcion:";
            // 
            // btnEliminarCargo
            // 
            this.btnEliminarCargo.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarCargo.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnEliminarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCargo.Location = new System.Drawing.Point(512, 395);
            this.btnEliminarCargo.Name = "btnEliminarCargo";
            this.btnEliminarCargo.Size = new System.Drawing.Size(166, 53);
            this.btnEliminarCargo.TabIndex = 16;
            this.btnEliminarCargo.Text = "Eliminar Cargo";
            this.btnEliminarCargo.UseVisualStyleBackColor = false;
            this.btnEliminarCargo.Click += new System.EventHandler(this.btnEliminarCargo_Click);
            // 
            // btnModificarCargo
            // 
            this.btnModificarCargo.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificarCargo.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnModificarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCargo.Location = new System.Drawing.Point(300, 395);
            this.btnModificarCargo.Name = "btnModificarCargo";
            this.btnModificarCargo.Size = new System.Drawing.Size(166, 53);
            this.btnModificarCargo.TabIndex = 15;
            this.btnModificarCargo.Text = "Modificar Cargo";
            this.btnModificarCargo.UseVisualStyleBackColor = false;
            this.btnModificarCargo.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnNuevoCargo
            // 
            this.btnNuevoCargo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevoCargo.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnNuevoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCargo.Location = new System.Drawing.Point(70, 397);
            this.btnNuevoCargo.Name = "btnNuevoCargo";
            this.btnNuevoCargo.Size = new System.Drawing.Size(166, 53);
            this.btnNuevoCargo.TabIndex = 14;
            this.btnNuevoCargo.Text = "Crear Nuevo Cargo";
            this.btnNuevoCargo.UseVisualStyleBackColor = false;
            this.btnNuevoCargo.Click += new System.EventHandler(this.button16_Click);
            // 
            // btnMostrarVentas
            // 
            this.btnMostrarVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMostrarVentas.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnMostrarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarVentas.Location = new System.Drawing.Point(512, 313);
            this.btnMostrarVentas.Name = "btnMostrarVentas";
            this.btnMostrarVentas.Size = new System.Drawing.Size(166, 53);
            this.btnMostrarVentas.TabIndex = 13;
            this.btnMostrarVentas.Text = "Mostrar Ventas del Mes";
            this.btnMostrarVentas.UseVisualStyleBackColor = false;
            this.btnMostrarVentas.Click += new System.EventHandler(this.btnMostrarVentas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(300, 471);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 53);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(512, 141);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(166, 53);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarInventario
            // 
            this.btnModificarInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificarInventario.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnModificarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarInventario.Location = new System.Drawing.Point(300, 313);
            this.btnModificarInventario.Name = "btnModificarInventario";
            this.btnModificarInventario.Size = new System.Drawing.Size(166, 53);
            this.btnModificarInventario.TabIndex = 10;
            this.btnModificarInventario.Text = "Modificar Producto del Inventario";
            this.btnModificarInventario.UseVisualStyleBackColor = false;
            this.btnModificarInventario.Click += new System.EventHandler(this.btnModificarInventario_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.Location = new System.Drawing.Point(300, 45);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(166, 53);
            this.btnModificarCliente.TabIndex = 8;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnModificarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEmpleado.Location = new System.Drawing.Point(300, 231);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(166, 53);
            this.btnModificarEmpleado.TabIndex = 7;
            this.btnModificarEmpleado.Text = "Modificar Empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = false;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(512, 231);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(166, 53);
            this.btnEliminarEmpleado.TabIndex = 6;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnRegistrarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(70, 231);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(166, 53);
            this.btnRegistrarEmpleado.TabIndex = 5;
            this.btnRegistrarEmpleado.Text = "Registrar Empleado";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = false;
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.btnRegistrarEmpleado_Click);
            // 
            // btnAgregarInventario
            // 
            this.btnAgregarInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarInventario.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAgregarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInventario.Location = new System.Drawing.Point(300, 140);
            this.btnAgregarInventario.Name = "btnAgregarInventario";
            this.btnAgregarInventario.Size = new System.Drawing.Size(166, 53);
            this.btnAgregarInventario.TabIndex = 4;
            this.btnAgregarInventario.Text = "Añadir Nuevo Producto a Inventario";
            this.btnAgregarInventario.UseVisualStyleBackColor = false;
            this.btnAgregarInventario.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInventario.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(70, 140);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(166, 53);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Mostrar Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(512, 45);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(166, 53);
            this.btnEliminarCliente.TabIndex = 2;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.Location = new System.Drawing.Point(70, 45);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(166, 53);
            this.btnRegistrarCliente.TabIndex = 1;
            this.btnRegistrarCliente.Text = "Registrar Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFactura.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Location = new System.Drawing.Point(70, 315);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(166, 53);
            this.btnFactura.TabIndex = 0;
            this.btnFactura.Text = "Generar Factura";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // FrmVentanaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 718);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentanaPrincipalAdmin";
            this.Text = "Ventana Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVentanaPrincipalAdmin_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarVentas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarInventario;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.Button btnAgregarInventario;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnEliminarCargo;
        private System.Windows.Forms.Button btnModificarCargo;
        private System.Windows.Forms.Button btnNuevoCargo;
    }
}