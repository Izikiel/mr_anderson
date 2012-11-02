namespace GrouponDesktop
{
    partial class ABM
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProverdorRB = new System.Windows.Forms.RadioButton();
            this.ClienteRB = new System.Windows.Forms.RadioButton();
            this.ClientPanel = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ProveedorPanel = new System.Windows.Forms.Panel();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Location = new System.Drawing.Point(0, 3);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(504, 424);
            this.Tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ClientPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProverdorRB);
            this.groupBox1.Controls.Add(this.ClienteRB);
            this.groupBox1.Location = new System.Drawing.Point(86, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 45);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // ProverdorRB
            // 
            this.ProverdorRB.AutoSize = true;
            this.ProverdorRB.Location = new System.Drawing.Point(99, 20);
            this.ProverdorRB.Name = "ProverdorRB";
            this.ProverdorRB.Size = new System.Drawing.Size(74, 17);
            this.ProverdorRB.TabIndex = 1;
            this.ProverdorRB.TabStop = true;
            this.ProverdorRB.Text = "Proveedor";
            this.ProverdorRB.UseVisualStyleBackColor = true;
            this.ProverdorRB.CheckedChanged += new System.EventHandler(this.ProverdorRB_CheckedChanged);
            // 
            // ClienteRB
            // 
            this.ClienteRB.AutoSize = true;
            this.ClienteRB.Location = new System.Drawing.Point(7, 20);
            this.ClienteRB.Name = "ClienteRB";
            this.ClienteRB.Size = new System.Drawing.Size(57, 17);
            this.ClienteRB.TabIndex = 0;
            this.ClienteRB.TabStop = true;
            this.ClienteRB.Text = "Cliente";
            this.ClienteRB.UseVisualStyleBackColor = true;
            this.ClienteRB.CheckedChanged += new System.EventHandler(this.ClienteRB_CheckedChanged);
            // 
            // ClientPanel
            // 
            this.ClientPanel.Controls.Add(this.ProveedorPanel);
            this.ClientPanel.Controls.Add(this.textBox10);
            this.ClientPanel.Controls.Add(this.textBox9);
            this.ClientPanel.Controls.Add(this.textBox8);
            this.ClientPanel.Controls.Add(this.textBox7);
            this.ClientPanel.Controls.Add(this.textBox6);
            this.ClientPanel.Controls.Add(this.textBox5);
            this.ClientPanel.Controls.Add(this.textBox4);
            this.ClientPanel.Controls.Add(this.textBox3);
            this.ClientPanel.Controls.Add(this.textBox2);
            this.ClientPanel.Controls.Add(this.textBox1);
            this.ClientPanel.Location = new System.Drawing.Point(9, 39);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.Size = new System.Drawing.Size(481, 353);
            this.ClientPanel.TabIndex = 14;
            this.ClientPanel.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(77, 307);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 20;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(77, 265);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(374, 229);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(56, 20);
            this.textBox8.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(294, 229);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(56, 20);
            this.textBox7.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(77, 229);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(187, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(77, 193);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(77, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificación";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // ProveedorPanel
            // 
            this.ProveedorPanel.Location = new System.Drawing.Point(0, 0);
            this.ProveedorPanel.Name = "ProveedorPanel";
            this.ProveedorPanel.Size = new System.Drawing.Size(482, 356);
            this.ProveedorPanel.TabIndex = 21;
            this.ProveedorPanel.Visible = false;
            // 
            // ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 439);
            this.Controls.Add(this.Tabs);
            this.Name = "ABM";
            this.Text = "ABM";
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ClientPanel.ResumeLayout(false);
            this.ClientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel ClientPanel;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton ProverdorRB;
        private System.Windows.Forms.RadioButton ClienteRB;
        private System.Windows.Forms.Panel ProveedorPanel;
    }
}