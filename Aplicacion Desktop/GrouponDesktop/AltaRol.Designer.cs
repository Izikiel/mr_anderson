namespace GrouponDesktop
{
    partial class AltaRol
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
            this.checkBoxArmarCupon = new System.Windows.Forms.CheckBox();
            this.checkBoxComprarGC = new System.Windows.Forms.CheckBox();
            this.checkBoxABMUsr = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBoxTipoUsr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.checkBoxCargarCredito = new System.Windows.Forms.CheckBox();
            this.checkBoxVerCupones = new System.Windows.Forms.CheckBox();
            this.checkBoxPedirDevolucion = new System.Windows.Forms.CheckBox();
            this.checkBoxHistorial = new System.Windows.Forms.CheckBox();
            this.checkBoxABMRol = new System.Windows.Forms.CheckBox();
            this.checkBoxPublicarCupones = new System.Windows.Forms.CheckBox();
            this.checkBoxFacturarProv = new System.Windows.Forms.CheckBox();
            this.checkBoxListadoEstadistico = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxArmarCupon
            // 
            this.checkBoxArmarCupon.AutoSize = true;
            this.checkBoxArmarCupon.Enabled = false;
            this.checkBoxArmarCupon.Location = new System.Drawing.Point(39, 175);
            this.checkBoxArmarCupon.Name = "checkBoxArmarCupon";
            this.checkBoxArmarCupon.Size = new System.Drawing.Size(87, 17);
            this.checkBoxArmarCupon.TabIndex = 0;
            this.checkBoxArmarCupon.Text = "Armar Cupon";
            this.checkBoxArmarCupon.UseVisualStyleBackColor = true;
            this.checkBoxArmarCupon.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // checkBoxComprarGC
            // 
            this.checkBoxComprarGC.AutoSize = true;
            this.checkBoxComprarGC.Enabled = false;
            this.checkBoxComprarGC.Location = new System.Drawing.Point(39, 221);
            this.checkBoxComprarGC.Name = "checkBoxComprarGC";
            this.checkBoxComprarGC.Size = new System.Drawing.Size(105, 17);
            this.checkBoxComprarGC.TabIndex = 1;
            this.checkBoxComprarGC.Text = "Comprar Giftcard";
            this.checkBoxComprarGC.UseVisualStyleBackColor = true;
            this.checkBoxComprarGC.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // checkBoxABMUsr
            // 
            this.checkBoxABMUsr.AutoSize = true;
            this.checkBoxABMUsr.Enabled = false;
            this.checkBoxABMUsr.Location = new System.Drawing.Point(39, 152);
            this.checkBoxABMUsr.Name = "checkBoxABMUsr";
            this.checkBoxABMUsr.Size = new System.Drawing.Size(88, 17);
            this.checkBoxABMUsr.TabIndex = 2;
            this.checkBoxABMUsr.Text = "ABM Usuario";
            this.checkBoxABMUsr.UseVisualStyleBackColor = true;
            this.checkBoxABMUsr.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo usuario";
            // 
            // cboBoxTipoUsr
            // 
            this.cboBoxTipoUsr.FormattingEnabled = true;
            this.cboBoxTipoUsr.Items.AddRange(new object[] {
            "Cliente",
            "Proveedor",
            "Administrador"});
            this.cboBoxTipoUsr.Location = new System.Drawing.Point(128, 22);
            this.cboBoxTipoUsr.Name = "cboBoxTipoUsr";
            this.cboBoxTipoUsr.Size = new System.Drawing.Size(121, 21);
            this.cboBoxTipoUsr.TabIndex = 4;
            this.cboBoxTipoUsr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funcionalidades";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(144, 288);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 6;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(243, 288);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // checkBoxCargarCredito
            // 
            this.checkBoxCargarCredito.AutoSize = true;
            this.checkBoxCargarCredito.Enabled = false;
            this.checkBoxCargarCredito.Location = new System.Drawing.Point(39, 198);
            this.checkBoxCargarCredito.Name = "checkBoxCargarCredito";
            this.checkBoxCargarCredito.Size = new System.Drawing.Size(93, 17);
            this.checkBoxCargarCredito.TabIndex = 8;
            this.checkBoxCargarCredito.Text = "Cargar Credito";
            this.checkBoxCargarCredito.UseVisualStyleBackColor = true;
            this.checkBoxCargarCredito.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // checkBoxVerCupones
            // 
            this.checkBoxVerCupones.AutoSize = true;
            this.checkBoxVerCupones.Enabled = false;
            this.checkBoxVerCupones.Location = new System.Drawing.Point(211, 196);
            this.checkBoxVerCupones.Name = "checkBoxVerCupones";
            this.checkBoxVerCupones.Size = new System.Drawing.Size(87, 17);
            this.checkBoxVerCupones.TabIndex = 9;
            this.checkBoxVerCupones.Text = "Ver Cupones";
            this.checkBoxVerCupones.UseVisualStyleBackColor = true;
            this.checkBoxVerCupones.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // checkBoxPedirDevolucion
            // 
            this.checkBoxPedirDevolucion.AutoSize = true;
            this.checkBoxPedirDevolucion.Enabled = false;
            this.checkBoxPedirDevolucion.Location = new System.Drawing.Point(211, 152);
            this.checkBoxPedirDevolucion.Name = "checkBoxPedirDevolucion";
            this.checkBoxPedirDevolucion.Size = new System.Drawing.Size(107, 17);
            this.checkBoxPedirDevolucion.TabIndex = 10;
            this.checkBoxPedirDevolucion.Text = "Pedir Devolucion";
            this.checkBoxPedirDevolucion.UseVisualStyleBackColor = true;
            this.checkBoxPedirDevolucion.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // checkBoxHistorial
            // 
            this.checkBoxHistorial.AutoSize = true;
            this.checkBoxHistorial.Enabled = false;
            this.checkBoxHistorial.Location = new System.Drawing.Point(211, 219);
            this.checkBoxHistorial.Name = "checkBoxHistorial";
            this.checkBoxHistorial.Size = new System.Drawing.Size(82, 17);
            this.checkBoxHistorial.TabIndex = 11;
            this.checkBoxHistorial.Text = "Ver Historial";
            this.checkBoxHistorial.UseVisualStyleBackColor = true;
            this.checkBoxHistorial.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // checkBoxABMRol
            // 
            this.checkBoxABMRol.AutoSize = true;
            this.checkBoxABMRol.Enabled = false;
            this.checkBoxABMRol.Location = new System.Drawing.Point(39, 129);
            this.checkBoxABMRol.Name = "checkBoxABMRol";
            this.checkBoxABMRol.Size = new System.Drawing.Size(68, 17);
            this.checkBoxABMRol.TabIndex = 12;
            this.checkBoxABMRol.Text = "ABM Rol";
            this.checkBoxABMRol.UseVisualStyleBackColor = true;
            this.checkBoxABMRol.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // checkBoxPublicarCupones
            // 
            this.checkBoxPublicarCupones.AutoSize = true;
            this.checkBoxPublicarCupones.Enabled = false;
            this.checkBoxPublicarCupones.Location = new System.Drawing.Point(211, 173);
            this.checkBoxPublicarCupones.Name = "checkBoxPublicarCupones";
            this.checkBoxPublicarCupones.Size = new System.Drawing.Size(109, 17);
            this.checkBoxPublicarCupones.TabIndex = 13;
            this.checkBoxPublicarCupones.Text = "Publicar Cupones";
            this.checkBoxPublicarCupones.UseVisualStyleBackColor = true;
            this.checkBoxPublicarCupones.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // checkBoxFacturarProv
            // 
            this.checkBoxFacturarProv.AutoSize = true;
            this.checkBoxFacturarProv.Enabled = false;
            this.checkBoxFacturarProv.Location = new System.Drawing.Point(39, 244);
            this.checkBoxFacturarProv.Name = "checkBoxFacturarProv";
            this.checkBoxFacturarProv.Size = new System.Drawing.Size(117, 17);
            this.checkBoxFacturarProv.TabIndex = 14;
            this.checkBoxFacturarProv.Text = "Facturar Proveedor";
            this.checkBoxFacturarProv.UseVisualStyleBackColor = true;
            this.checkBoxFacturarProv.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // checkBoxListadoEstadistico
            // 
            this.checkBoxListadoEstadistico.AutoSize = true;
            this.checkBoxListadoEstadistico.Enabled = false;
            this.checkBoxListadoEstadistico.Location = new System.Drawing.Point(211, 129);
            this.checkBoxListadoEstadistico.Name = "checkBoxListadoEstadistico";
            this.checkBoxListadoEstadistico.Size = new System.Drawing.Size(116, 17);
            this.checkBoxListadoEstadistico.TabIndex = 15;
            this.checkBoxListadoEstadistico.Text = "Listado Estadístico";
            this.checkBoxListadoEstadistico.UseVisualStyleBackColor = true;
            this.checkBoxListadoEstadistico.CheckedChanged += new System.EventHandler(this.allCheckBoxes_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre Rol:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxListadoEstadistico);
            this.Controls.Add(this.checkBoxFacturarProv);
            this.Controls.Add(this.checkBoxPublicarCupones);
            this.Controls.Add(this.checkBoxABMRol);
            this.Controls.Add(this.checkBoxHistorial);
            this.Controls.Add(this.checkBoxPedirDevolucion);
            this.Controls.Add(this.checkBoxVerCupones);
            this.Controls.Add(this.checkBoxCargarCredito);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBoxTipoUsr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxABMUsr);
            this.Controls.Add(this.checkBoxComprarGC);
            this.Controls.Add(this.checkBoxArmarCupon);
            this.Name = "AltaRol";
            this.Text = "AltaRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxComprarGC;
        private System.Windows.Forms.CheckBox checkBoxABMUsr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBoxTipoUsr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxArmarCupon;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.CheckBox checkBoxCargarCredito;
        private System.Windows.Forms.CheckBox checkBoxVerCupones;
        private System.Windows.Forms.CheckBox checkBoxPedirDevolucion;
        private System.Windows.Forms.CheckBox checkBoxHistorial;
        private System.Windows.Forms.CheckBox checkBoxABMRol;
        private System.Windows.Forms.CheckBox checkBoxPublicarCupones;
        private System.Windows.Forms.CheckBox checkBoxFacturarProv;
        private System.Windows.Forms.CheckBox checkBoxListadoEstadistico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}