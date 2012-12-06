namespace GrouponDesktop
{
    partial class DevolverCupon
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
            this.txtBox_Fecha = new System.Windows.Forms.TextBox();
            this.TxtBox_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBox_NroCupon = new System.Windows.Forms.TextBox();
            this.TxtBox_Motivo = new System.Windows.Forms.TextBox();
            this.groupBox_OnlyAdmin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_OnlyAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_Fecha
            // 
            this.txtBox_Fecha.Location = new System.Drawing.Point(94, 73);
            this.txtBox_Fecha.Name = "txtBox_Fecha";
            this.txtBox_Fecha.ReadOnly = true;
            this.txtBox_Fecha.Size = new System.Drawing.Size(128, 20);
            this.txtBox_Fecha.TabIndex = 0;
            // 
            // TxtBox_Username
            // 
            this.TxtBox_Username.Location = new System.Drawing.Point(74, 19);
            this.TxtBox_Username.Name = "TxtBox_Username";
            this.TxtBox_Username.Size = new System.Drawing.Size(128, 20);
            this.TxtBox_Username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cupon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Motivo";
            // 
            // TxtBox_NroCupon
            // 
            this.TxtBox_NroCupon.Location = new System.Drawing.Point(93, 114);
            this.TxtBox_NroCupon.Name = "TxtBox_NroCupon";
            this.TxtBox_NroCupon.Size = new System.Drawing.Size(128, 20);
            this.TxtBox_NroCupon.TabIndex = 7;
            // 
            // TxtBox_Motivo
            // 
            this.TxtBox_Motivo.AcceptsReturn = true;
            this.TxtBox_Motivo.Location = new System.Drawing.Point(93, 152);
            this.TxtBox_Motivo.Multiline = true;
            this.TxtBox_Motivo.Name = "TxtBox_Motivo";
            this.TxtBox_Motivo.Size = new System.Drawing.Size(128, 137);
            this.TxtBox_Motivo.TabIndex = 8;
            // 
            // groupBox_OnlyAdmin
            // 
            this.groupBox_OnlyAdmin.Controls.Add(this.label2);
            this.groupBox_OnlyAdmin.Controls.Add(this.TxtBox_Username);
            this.groupBox_OnlyAdmin.Location = new System.Drawing.Point(39, 12);
            this.groupBox_OnlyAdmin.Name = "groupBox_OnlyAdmin";
            this.groupBox_OnlyAdmin.Size = new System.Drawing.Size(218, 48);
            this.groupBox_OnlyAdmin.TabIndex = 9;
            this.groupBox_OnlyAdmin.TabStop = false;
            this.groupBox_OnlyAdmin.Text = "Administrador";
            this.groupBox_OnlyAdmin.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generar Devolucion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DevolverCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtBox_Motivo);
            this.Controls.Add(this.TxtBox_NroCupon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Fecha);
            this.Controls.Add(this.groupBox_OnlyAdmin);
            this.Name = "DevolverCupon";
            this.Text = "DevolverCupon";
            this.groupBox_OnlyAdmin.ResumeLayout(false);
            this.groupBox_OnlyAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Fecha;
        private System.Windows.Forms.TextBox TxtBox_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBox_NroCupon;
        private System.Windows.Forms.TextBox TxtBox_Motivo;
        private System.Windows.Forms.GroupBox groupBox_OnlyAdmin;
        private System.Windows.Forms.Button button1;
    }
}