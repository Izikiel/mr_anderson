namespace GrouponDesktop.UI
{
    partial class SimularOtroUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Username = new System.Windows.Forms.TextBox();
            this.Btn_Simular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario a Simular";
            // 
            // TxtBox_Username
            // 
            this.TxtBox_Username.Location = new System.Drawing.Point(145, 23);
            this.TxtBox_Username.Name = "TxtBox_Username";
            this.TxtBox_Username.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Username.TabIndex = 1;
            // 
            // Btn_Simular
            // 
            this.Btn_Simular.Location = new System.Drawing.Point(285, 20);
            this.Btn_Simular.Name = "Btn_Simular";
            this.Btn_Simular.Size = new System.Drawing.Size(75, 23);
            this.Btn_Simular.TabIndex = 2;
            this.Btn_Simular.Text = "Simular";
            this.Btn_Simular.UseVisualStyleBackColor = true;
            this.Btn_Simular.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver Modo Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SimularOtroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 123);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Simular);
            this.Controls.Add(this.TxtBox_Username);
            this.Controls.Add(this.label1);
            this.Name = "SimularOtroUsuario";
            this.Text = "SimularOtroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_Username;
        private System.Windows.Forms.Button Btn_Simular;
        private System.Windows.Forms.Button button1;
    }
}