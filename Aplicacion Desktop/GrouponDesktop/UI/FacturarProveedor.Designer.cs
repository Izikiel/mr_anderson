namespace GrouponDesktop.UI
{
    partial class FacturarProveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBox_Proveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimePicker_Desde = new System.Windows.Forms.DateTimePicker();
            this.TimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBox_NumeroFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBox_Total = new System.Windows.Forms.TextBox();
            this.DataGrid_Clientes = new System.Windows.Forms.DataGridView();
            this.Btn_Facturar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGrid_Clientes);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 237);
            this.panel1.TabIndex = 0;
            // 
            // TxtBox_Proveedor
            // 
            this.TxtBox_Proveedor.Location = new System.Drawing.Point(613, 13);
            this.TxtBox_Proveedor.Name = "TxtBox_Proveedor";
            this.TxtBox_Proveedor.Size = new System.Drawing.Size(139, 20);
            this.TxtBox_Proveedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proveedor";
            // 
            // TimePicker_Desde
            // 
            this.TimePicker_Desde.Location = new System.Drawing.Point(231, 13);
            this.TimePicker_Desde.Name = "TimePicker_Desde";
            this.TimePicker_Desde.Size = new System.Drawing.Size(200, 20);
            this.TimePicker_Desde.TabIndex = 3;
            // 
            // TimePicker_Hasta
            // 
            this.TimePicker_Hasta.Location = new System.Drawing.Point(231, 39);
            this.TimePicker_Hasta.Name = "TimePicker_Hasta";
            this.TimePicker_Hasta.Size = new System.Drawing.Size(200, 20);
            this.TimePicker_Hasta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta";
            // 
            // TxtBox_NumeroFactura
            // 
            this.TxtBox_NumeroFactura.BackColor = System.Drawing.Color.White;
            this.TxtBox_NumeroFactura.Location = new System.Drawing.Point(348, 349);
            this.TxtBox_NumeroFactura.Name = "TxtBox_NumeroFactura";
            this.TxtBox_NumeroFactura.ReadOnly = true;
            this.TxtBox_NumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_NumeroFactura.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total";
            // 
            // TxtBox_Total
            // 
            this.TxtBox_Total.BackColor = System.Drawing.Color.White;
            this.TxtBox_Total.Location = new System.Drawing.Point(626, 349);
            this.TxtBox_Total.Name = "TxtBox_Total";
            this.TxtBox_Total.ReadOnly = true;
            this.TxtBox_Total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBox_Total.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Total.TabIndex = 9;
            // 
            // DataGrid_Clientes
            // 
            this.DataGrid_Clientes.AllowUserToAddRows = false;
            this.DataGrid_Clientes.AllowUserToDeleteRows = false;
            this.DataGrid_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Clientes.Location = new System.Drawing.Point(1, 0);
            this.DataGrid_Clientes.Name = "DataGrid_Clientes";
            this.DataGrid_Clientes.ReadOnly = true;
            this.DataGrid_Clientes.Size = new System.Drawing.Size(771, 234);
            this.DataGrid_Clientes.TabIndex = 0;
            // 
            // Btn_Facturar
            // 
            this.Btn_Facturar.Location = new System.Drawing.Point(642, 39);
            this.Btn_Facturar.Name = "Btn_Facturar";
            this.Btn_Facturar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Facturar.TabIndex = 11;
            this.Btn_Facturar.Text = "Facturar";
            this.Btn_Facturar.UseVisualStyleBackColor = true;
            this.Btn_Facturar.Click += new System.EventHandler(this.Btn_Facturar_Click);
            // 
            // FacturarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 421);
            this.Controls.Add(this.Btn_Facturar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBox_Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBox_NumeroFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimePicker_Hasta);
            this.Controls.Add(this.TimePicker_Desde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox_Proveedor);
            this.Controls.Add(this.panel1);
            this.Name = "FacturarCupon";
            this.Text = "FacturarCupon";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBox_Proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TimePicker_Desde;
        private System.Windows.Forms.DateTimePicker TimePicker_Hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGrid_Clientes;
        private System.Windows.Forms.TextBox TxtBox_NumeroFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBox_Total;
        private System.Windows.Forms.Button Btn_Facturar;
    }
}