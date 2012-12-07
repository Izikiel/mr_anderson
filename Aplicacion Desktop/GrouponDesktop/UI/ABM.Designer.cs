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
            this.ProveedorPanel = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ClientPanel.SuspendLayout();
            this.ProveedorPanel.SuspendLayout();
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
            this.ClientPanel.Controls.Add(this.label10);
            this.ClientPanel.Controls.Add(this.textBox8);
            this.ClientPanel.Controls.Add(this.label8);
            this.ClientPanel.Controls.Add(this.label9);
            this.ClientPanel.Controls.Add(this.label7);
            this.ClientPanel.Controls.Add(this.label6);
            this.ClientPanel.Controls.Add(this.label5);
            this.ClientPanel.Controls.Add(this.label4);
            this.ClientPanel.Controls.Add(this.label3);
            this.ClientPanel.Controls.Add(this.label2);
            this.ClientPanel.Controls.Add(this.label1);
            this.ClientPanel.Controls.Add(this.textBox10);
            this.ClientPanel.Controls.Add(this.textBox9);
            this.ClientPanel.Controls.Add(this.textBox7);
            this.ClientPanel.Controls.Add(this.textBox6);
            this.ClientPanel.Controls.Add(this.textBox5);
            this.ClientPanel.Controls.Add(this.textBox4);
            this.ClientPanel.Controls.Add(this.textBox3);
            this.ClientPanel.Controls.Add(this.textBox2);
            this.ClientPanel.Controls.Add(this.textBox1);
            this.ClientPanel.Location = new System.Drawing.Point(12, 42);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.Size = new System.Drawing.Size(481, 353);
            this.ClientPanel.TabIndex = 14;
            this.ClientPanel.Visible = false;
            // 
            // ProveedorPanel
            // 
            this.ProveedorPanel.Controls.Add(this.label11);
            this.ProveedorPanel.Controls.Add(this.textBox12);
            this.ProveedorPanel.Controls.Add(this.textBox11);
            this.ProveedorPanel.Controls.Add(this.label12);
            this.ProveedorPanel.Controls.Add(this.label13);
            this.ProveedorPanel.Controls.Add(this.label14);
            this.ProveedorPanel.Controls.Add(this.label15);
            this.ProveedorPanel.Controls.Add(this.label16);
            this.ProveedorPanel.Controls.Add(this.label17);
            this.ProveedorPanel.Controls.Add(this.label18);
            this.ProveedorPanel.Controls.Add(this.label20);
            this.ProveedorPanel.Controls.Add(this.textBox13);
            this.ProveedorPanel.Controls.Add(this.textBox14);
            this.ProveedorPanel.Controls.Add(this.textBox15);
            this.ProveedorPanel.Controls.Add(this.textBox16);
            this.ProveedorPanel.Controls.Add(this.textBox17);
            this.ProveedorPanel.Controls.Add(this.textBox18);
            this.ProveedorPanel.Controls.Add(this.textBox19);
            this.ProveedorPanel.Location = new System.Drawing.Point(0, 0);
            this.ProveedorPanel.Name = "ProveedorPanel";
            this.ProveedorPanel.Size = new System.Drawing.Size(482, 356);
            this.ProveedorPanel.TabIndex = 21;
            this.ProveedorPanel.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(412, 235);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(56, 20);
            this.textBox11.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "C.P.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Localidad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(276, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Piso";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Dirección";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Rubro";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(45, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Mail";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "CUIT";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Razón Social";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(115, 275);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(187, 20);
            this.textBox13.TabIndex = 40;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(309, 235);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(56, 20);
            this.textBox14.TabIndex = 39;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(83, 235);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(187, 20);
            this.textBox15.TabIndex = 38;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(115, 163);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 37;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(115, 124);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 36;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(115, 85);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 35;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(115, 40);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(284, 20);
            this.textBox19.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Fecha Nacimiento";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(406, 195);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(56, 20);
            this.textBox8.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "C.P.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Localidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Piso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "D N I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(349, 63);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 20;
            this.textBox10.Text = "DD/MM/YYYY";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(77, 235);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(187, 20);
            this.textBox9.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(303, 195);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(56, 20);
            this.textBox7.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(77, 195);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(187, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(77, 150);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(77, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Nombre Contacto";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(115, 198);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 53;
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
            this.ProveedorPanel.ResumeLayout(false);
            this.ProveedorPanel.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox12;
    }
}