﻿namespace MinforFrontEnd
{
    partial class AgregarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarArticulo));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblIntrucciones = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(665, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 68);
            this.button3.TabIndex = 41;
            this.button3.Text = "Limpiar Campos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(524, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 36);
            this.button2.TabIndex = 40;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(286, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.Location = new System.Drawing.Point(286, 355);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(338, 22);
            this.txtDireccion.TabIndex = 38;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(174, 358);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(105, 17);
            this.lblDireccion.TabIndex = 37;
            this.lblDireccion.Text = "Precio Unitario:";
            this.lblDireccion.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(286, 307);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(338, 22);
            this.txtEmail.TabIndex = 36;
            // 
            // txtCedula
            // 
            this.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCedula.Location = new System.Drawing.Point(286, 255);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(338, 22);
            this.txtCedula.TabIndex = 35;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellidos.Location = new System.Drawing.Point(286, 205);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(338, 22);
            this.txtApellidos.TabIndex = 34;
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombres.Location = new System.Drawing.Point(285, 162);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(338, 22);
            this.txtNombres.TabIndex = 33;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(205, 312);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 17);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Modelo:";
            // 
            // lblCedula
            // 
            this.lblCedula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(205, 260);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(51, 17);
            this.lblCedula.TabIndex = 31;
            this.lblCedula.Text = "Marca:";
            this.lblCedula.Click += new System.EventHandler(this.lblCedula_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(193, 210);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(86, 17);
            this.lblApellidos.TabIndex = 30;
            this.lblApellidos.Text = "Descripción:";
            // 
            // lblNombres
            // 
            this.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(182, 167);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(97, 17);
            this.lblNombres.TabIndex = 29;
            this.lblNombres.Text = "Id del Articulo:";
            // 
            // lblIntrucciones
            // 
            this.lblIntrucciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIntrucciones.AutoSize = true;
            this.lblIntrucciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblIntrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntrucciones.Location = new System.Drawing.Point(326, 70);
            this.lblIntrucciones.Name = "lblIntrucciones";
            this.lblIntrucciones.Size = new System.Drawing.Size(274, 25);
            this.lblIntrucciones.TabIndex = 28;
            this.lblIntrucciones.Text = "Ingreso de Nuevo Producto";
            this.lblIntrucciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(286, 447);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 22);
            this.textBox1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tipo:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(285, 397);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 22);
            this.textBox2.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Stock:";
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 684);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblIntrucciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarArticulo";
            this.Text = "AgregarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblIntrucciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}