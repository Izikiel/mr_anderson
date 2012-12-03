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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Panel_PayPal = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_nombreUsuario = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Panel_PagoTarjeta.SuspendLayout();
            this.Panel_PayPal.SuspendLayout();
            this.Panel_nombreUsuario.SuspendLayout();
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
            this.Panel_PagoTarjeta.Controls.Add(this.label9);
            this.Panel_PagoTarjeta.Controls.Add(this.label10);
            this.Panel_PagoTarjeta.Controls.Add(this.textBox7);
            this.Panel_PagoTarjeta.Controls.Add(this.label11);
            this.Panel_PagoTarjeta.Controls.Add(this.textBox8);
            this.Panel_PagoTarjeta.Controls.Add(this.label12);
            this.Panel_PagoTarjeta.Controls.Add(this.textBox9);
            this.Panel_PagoTarjeta.Controls.Add(this.label13);
            this.Panel_PagoTarjeta.Controls.Add(this.textBox10);
            this.Panel_PagoTarjeta.Controls.Add(this.label14);
            this.Panel_PagoTarjeta.Controls.Add(this.textBox11);
            this.Panel_PagoTarjeta.Controls.Add(this.label15);
            this.Panel_PagoTarjeta.Location = new System.Drawing.Point(28, 92);
            this.Panel_PagoTarjeta.Name = "Panel_PagoTarjeta";
            this.Panel_PagoTarjeta.Size = new System.Drawing.Size(260, 199);
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
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(64, 156);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(109, 20);
            this.textBox7.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 47);
            this.label11.TabIndex = 22;
            this.label11.Text = "Monto a cargar";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(64, 118);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(46, 20);
            this.textBox8.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 47);
            this.label12.TabIndex = 20;
            this.label12.Text = "Fecha vencimiento";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(64, 79);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(46, 20);
            this.textBox9.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 47);
            this.label13.TabIndex = 18;
            this.label13.Text = "Código seguridad";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(64, 39);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(166, 20);
            this.textBox10.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 47);
            this.label14.TabIndex = 16;
            this.label14.Text = "Numero de la tarjeta";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(64, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(166, 20);
            this.textBox11.TabIndex = 15;
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
            this.Panel_PayPal.Controls.Add(this.textBox5);
            this.Panel_PayPal.Controls.Add(this.label5);
            this.Panel_PayPal.Controls.Add(this.textBox2);
            this.Panel_PayPal.Controls.Add(this.label2);
            this.Panel_PayPal.Controls.Add(this.textBox1);
            this.Panel_PayPal.Controls.Add(this.label1);
            this.Panel_PayPal.Location = new System.Drawing.Point(28, 92);
            this.Panel_PayPal.Name = "Panel_PayPal";
            this.Panel_PayPal.Size = new System.Drawing.Size(255, 199);
            this.Panel_PayPal.TabIndex = 2;
            this.Panel_PayPal.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(91, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(67, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto a cargar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo de Pago";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 3;
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
            this.Panel_nombreUsuario.Controls.Add(this.textBox6);
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(64, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(166, 20);
            this.textBox6.TabIndex = 5;
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(105, 299);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirmar.TabIndex = 15;
            this.Btn_Confirmar.Text = "Confirmar Pago";
            this.Btn_Confirmar.UseVisualStyleBackColor = false;
            // 
            // CargarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 481);
            this.Controls.Add(this.Panel_PagoTarjeta);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel_nombreUsuario);
            this.Controls.Add(this.Panel_PayPal);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_payPal;
        private System.Windows.Forms.RadioButton RB_tarjetaCredito;
        private System.Windows.Forms.Panel Panel_PagoTarjeta;
        private System.Windows.Forms.Panel Panel_PayPal;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_nombreUsuario;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label15;
    }
}