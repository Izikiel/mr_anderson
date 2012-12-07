namespace GrouponDesktop
{
    partial class CargarCredito
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_payPal = new System.Windows.Forms.RadioButton();
            this.RB_tarjetaCredito = new System.Windows.Forms.RadioButton();
            this.Panel_PagoTarjeta = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBox_MontoCargar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtBox_FechaVencimiento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBox_CodSeguridad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBox_NroTarjeta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtBox_NombreTitular = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Panel_PayPal = new System.Windows.Forms.Panel();
            this.TxtBox_MontoPagarPayPal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBox_CodigoPagoPayPal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBox_UsuarioPayPal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_nombreUsuario = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBox_Username = new System.Windows.Forms.TextBox();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_TipoTarjetaCredito = new System.Windows.Forms.RadioButton();
            this.RB_TipoTarjetaDebito = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.Panel_PagoTarjeta.SuspendLayout();
            this.Panel_PayPal.SuspendLayout();
            this.Panel_nombreUsuario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_payPal);
            this.groupBox1.Controls.Add(this.RB_tarjetaCredito);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 35);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RB_payPal
            // 
            this.RB_payPal.AutoSize = true;
            this.RB_payPal.Location = new System.Drawing.Point(169, 12);
            this.RB_payPal.Name = "RB_payPal";
            this.RB_payPal.Size = new System.Drawing.Size(58, 17);
            this.RB_payPal.TabIndex = 1;
            this.RB_payPal.TabStop = true;
            this.RB_payPal.Text = "PayPal";
            this.RB_payPal.UseVisualStyleBackColor = true;
            this.RB_payPal.CheckedChanged += new System.EventHandler(this.RB_payPal_CheckedChanged);
            // 
            // RB_tarjetaCredito
            // 
            this.RB_tarjetaCredito.AutoSize = true;
            this.RB_tarjetaCredito.Location = new System.Drawing.Point(7, 13);
            this.RB_tarjetaCredito.Name = "RB_tarjetaCredito";
            this.RB_tarjetaCredito.Size = new System.Drawing.Size(109, 17);
            this.RB_tarjetaCredito.TabIndex = 0;
            this.RB_tarjetaCredito.TabStop = true;
            this.RB_tarjetaCredito.Text = "Tarjeta de Credito";
            this.RB_tarjetaCredito.UseVisualStyleBackColor = true;
            this.RB_tarjetaCredito.CheckedChanged += new System.EventHandler(this.RB_tarjetaCredito_CheckedChanged);
            // 
            // Panel_PagoTarjeta
            // 
            this.Panel_PagoTarjeta.Controls.Add(this.groupBox2);
            this.Panel_PagoTarjeta.Controls.Add(this.label9);
            this.Panel_PagoTarjeta.Controls.Add(this.label10);
            this.Panel_PagoTarjeta.Controls.Add(this.TxtBox_MontoCargar);
            this.Panel_PagoTarjeta.Controls.Add(this.label11);
            this.Panel_PagoTarjeta.Controls.Add(this.TxtBox_FechaVencimiento);
            this.Panel_PagoTarjeta.Controls.Add(this.label12);
            this.Panel_PagoTarjeta.Controls.Add(this.TxtBox_CodSeguridad);
            this.Panel_PagoTarjeta.Controls.Add(this.label13);
            this.Panel_PagoTarjeta.Controls.Add(this.TxtBox_NroTarjeta);
            this.Panel_PagoTarjeta.Controls.Add(this.label14);
            this.Panel_PagoTarjeta.Controls.Add(this.TxtBox_NombreTitular);
            this.Panel_PagoTarjeta.Controls.Add(this.label15);
            this.Panel_PagoTarjeta.Location = new System.Drawing.Point(28, 91);
            this.Panel_PagoTarjeta.Name = "Panel_PagoTarjeta";
            this.Panel_PagoTarjeta.Size = new System.Drawing.Size(260, 189);
            this.Panel_PagoTarjeta.TabIndex = 1;
            this.Panel_PagoTarjeta.Visible = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(118, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 47);
            this.label9.TabIndex = 25;
            this.label9.Text = "MM/AA";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(115, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 47);
            this.label10.TabIndex = 24;
            this.label10.Text = "(3 dígitos al dorso)";
            // 
            // TxtBox_MontoCargar
            // 
            this.TxtBox_MontoCargar.Location = new System.Drawing.Point(64, 156);
            this.TxtBox_MontoCargar.Name = "TxtBox_MontoCargar";
            this.TxtBox_MontoCargar.Size = new System.Drawing.Size(109, 20);
            this.TxtBox_MontoCargar.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 47);
            this.label11.TabIndex = 22;
            this.label11.Text = "Monto a cargar";
            // 
            // TxtBox_FechaVencimiento
            // 
            this.TxtBox_FechaVencimiento.Location = new System.Drawing.Point(64, 118);
            this.TxtBox_FechaVencimiento.Name = "TxtBox_FechaVencimiento";
            this.TxtBox_FechaVencimiento.Size = new System.Drawing.Size(46, 20);
            this.TxtBox_FechaVencimiento.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 47);
            this.label12.TabIndex = 20;
            this.label12.Text = "Fecha vencimiento";
            // 
            // TxtBox_CodSeguridad
            // 
            this.TxtBox_CodSeguridad.Location = new System.Drawing.Point(64, 79);
            this.TxtBox_CodSeguridad.Name = "TxtBox_CodSeguridad";
            this.TxtBox_CodSeguridad.Size = new System.Drawing.Size(46, 20);
            this.TxtBox_CodSeguridad.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 47);
            this.label13.TabIndex = 18;
            this.label13.Text = "Código seguridad";
            // 
            // TxtBox_NroTarjeta
            // 
            this.TxtBox_NroTarjeta.Location = new System.Drawing.Point(64, 39);
            this.TxtBox_NroTarjeta.Name = "TxtBox_NroTarjeta";
            this.TxtBox_NroTarjeta.Size = new System.Drawing.Size(166, 20);
            this.TxtBox_NroTarjeta.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 47);
            this.label14.TabIndex = 16;
            this.label14.Text = "Numero de la tarjeta";
            // 
            // TxtBox_NombreTitular
            // 
            this.TxtBox_NombreTitular.Location = new System.Drawing.Point(64, 3);
            this.TxtBox_NombreTitular.Name = "TxtBox_NombreTitular";
            this.TxtBox_NombreTitular.Size = new System.Drawing.Size(166, 20);
            this.TxtBox_NombreTitular.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(3, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 47);
            this.label15.TabIndex = 14;
            this.label15.Text = "Nombre del titular";
            // 
            // Panel_PayPal
            // 
            this.Panel_PayPal.Controls.Add(this.TxtBox_MontoPagarPayPal);
            this.Panel_PayPal.Controls.Add(this.label5);
            this.Panel_PayPal.Controls.Add(this.TxtBox_CodigoPagoPayPal);
            this.Panel_PayPal.Controls.Add(this.label2);
            this.Panel_PayPal.Controls.Add(this.TxtBox_UsuarioPayPal);
            this.Panel_PayPal.Controls.Add(this.label1);
            this.Panel_PayPal.Location = new System.Drawing.Point(28, 94);
            this.Panel_PayPal.Name = "Panel_PayPal";
            this.Panel_PayPal.Size = new System.Drawing.Size(255, 199);
            this.Panel_PayPal.TabIndex = 2;
            this.Panel_PayPal.Visible = false;
            // 
            // TxtBox_MontoPagarPayPal
            // 
            this.TxtBox_MontoPagarPayPal.Location = new System.Drawing.Point(128, 112);
            this.TxtBox_MontoPagarPayPal.Name = "TxtBox_MontoPagarPayPal";
            this.TxtBox_MontoPagarPayPal.Size = new System.Drawing.Size(91, 20);
            this.TxtBox_MontoPagarPayPal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(67, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto a cargar";
            // 
            // TxtBox_CodigoPagoPayPal
            // 
            this.TxtBox_CodigoPagoPayPal.Location = new System.Drawing.Point(70, 56);
            this.TxtBox_CodigoPagoPayPal.Name = "TxtBox_CodigoPagoPayPal";
            this.TxtBox_CodigoPagoPayPal.Size = new System.Drawing.Size(166, 20);
            this.TxtBox_CodigoPagoPayPal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo de Pago";
            // 
            // TxtBox_UsuarioPayPal
            // 
            this.TxtBox_UsuarioPayPal.Location = new System.Drawing.Point(70, 14);
            this.TxtBox_UsuarioPayPal.Name = "TxtBox_UsuarioPayPal";
            this.TxtBox_UsuarioPayPal.Size = new System.Drawing.Size(166, 20);
            this.TxtBox_UsuarioPayPal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Usuario";
            // 
            // Panel_nombreUsuario
            // 
            this.Panel_nombreUsuario.Controls.Add(this.label8);
            this.Panel_nombreUsuario.Controls.Add(this.TxtBox_Username);
            this.Panel_nombreUsuario.Location = new System.Drawing.Point(28, 54);
            this.Panel_nombreUsuario.Name = "Panel_nombreUsuario";
            this.Panel_nombreUsuario.Size = new System.Drawing.Size(239, 32);
            this.Panel_nombreUsuario.TabIndex = 14;
            this.Panel_nombreUsuario.Visible = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Username";
            // 
            // TxtBox_Username
            // 
            this.TxtBox_Username.Location = new System.Drawing.Point(64, 4);
            this.TxtBox_Username.Name = "TxtBox_Username";
            this.TxtBox_Username.Size = new System.Drawing.Size(166, 20);
            this.TxtBox_Username.TabIndex = 5;
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(105, 299);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirmar.TabIndex = 15;
            this.Btn_Confirmar.Text = "Confirmar Pago";
            this.Btn_Confirmar.UseVisualStyleBackColor = false;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_TipoTarjetaDebito);
            this.groupBox2.Controls.Add(this.RB_TipoTarjetaCredito);
            this.groupBox2.Location = new System.Drawing.Point(167, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(85, 58);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // RB_TipoTarjetaCredito
            // 
            this.RB_TipoTarjetaCredito.AutoSize = true;
            this.RB_TipoTarjetaCredito.Checked = true;
            this.RB_TipoTarjetaCredito.Location = new System.Drawing.Point(7, 14);
            this.RB_TipoTarjetaCredito.Name = "RB_TipoTarjetaCredito";
            this.RB_TipoTarjetaCredito.Size = new System.Drawing.Size(58, 17);
            this.RB_TipoTarjetaCredito.TabIndex = 0;
            this.RB_TipoTarjetaCredito.TabStop = true;
            this.RB_TipoTarjetaCredito.Text = "Credito";
            this.RB_TipoTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // RB_TipoTarjetaDebito
            // 
            this.RB_TipoTarjetaDebito.AutoSize = true;
            this.RB_TipoTarjetaDebito.Location = new System.Drawing.Point(7, 35);
            this.RB_TipoTarjetaDebito.Name = "RB_TipoTarjetaDebito";
            this.RB_TipoTarjetaDebito.Size = new System.Drawing.Size(56, 17);
            this.RB_TipoTarjetaDebito.TabIndex = 1;
            this.RB_TipoTarjetaDebito.Text = "Debito";
            this.RB_TipoTarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // CargarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 439);
            this.Controls.Add(this.Panel_PagoTarjeta);
            this.Controls.Add(this.Panel_PayPal);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel_nombreUsuario);
            this.Name = "CargarCredito";
            this.Text = "CargarCredito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Panel_PagoTarjeta.ResumeLayout(false);
            this.Panel_PagoTarjeta.PerformLayout();
            this.Panel_PayPal.ResumeLayout(false);
            this.Panel_PayPal.PerformLayout();
            this.Panel_nombreUsuario.ResumeLayout(false);
            this.Panel_nombreUsuario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_payPal;
        private System.Windows.Forms.RadioButton RB_tarjetaCredito;
        private System.Windows.Forms.Panel Panel_PagoTarjeta;
        private System.Windows.Forms.Panel Panel_PayPal;
        private System.Windows.Forms.TextBox TxtBox_MontoPagarPayPal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBox_CodigoPagoPayPal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBox_UsuarioPayPal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_nombreUsuario;
        private System.Windows.Forms.TextBox TxtBox_Username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtBox_MontoCargar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtBox_FechaVencimiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtBox_CodSeguridad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBox_NroTarjeta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtBox_NombreTitular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_TipoTarjetaDebito;
        private System.Windows.Forms.RadioButton RB_TipoTarjetaCredito;
    }
}