namespace GrouponDesktop
{
    partial class ComprarGiftCard
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
            this.TxtBoxUsuarioDestino = new System.Windows.Forms.TextBox();
            this.TxtBoxMontoGift = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelMonto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBoxUsuarioDestino
            // 
            this.TxtBoxUsuarioDestino.Location = new System.Drawing.Point(128, 42);
            this.TxtBoxUsuarioDestino.Name = "TxtBoxUsuarioDestino";
            this.TxtBoxUsuarioDestino.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxUsuarioDestino.TabIndex = 1;
            // 
            // TxtBoxMontoGift
            // 
            this.TxtBoxMontoGift.Location = new System.Drawing.Point(128, 92);
            this.TxtBoxMontoGift.Name = "TxtBoxMontoGift";
            this.TxtBoxMontoGift.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxMontoGift.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto de GiftCard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Su saldo es de:";
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Location = new System.Drawing.Point(216, 9);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(13, 13);
            this.LblSaldo.TabIndex = 6;
            this.LblSaldo.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(245, 95);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(88, 13);
            this.labelMonto.TabIndex = 9;
            this.labelMonto.Text = "Rango del monto";
            // 
            // ComprarGiftCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 176);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxMontoGift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxUsuarioDestino);
            this.Name = "ComprarGiftCard";
            this.Text = "ComprarGiftCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtBoxUsuarioDestino;
        private System.Windows.Forms.TextBox TxtBoxMontoGift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelMonto;

    }
}