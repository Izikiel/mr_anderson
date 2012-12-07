namespace GrouponDesktop.UI
{
    partial class ListadoUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filtro1 = new System.Windows.Forms.Label();
            this.filtro2 = new System.Windows.Forms.Label();
            this.filtro3 = new System.Windows.Forms.Label();
            this.filtro4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Seleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(22, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.fillGridConFiltros);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filtro1
            // 
            this.filtro1.AutoSize = true;
            this.filtro1.Location = new System.Drawing.Point(19, 38);
            this.filtro1.Name = "filtro1";
            this.filtro1.Size = new System.Drawing.Size(32, 13);
            this.filtro1.TabIndex = 4;
            this.filtro1.Text = "filtro1";
            // 
            // filtro2
            // 
            this.filtro2.AutoSize = true;
            this.filtro2.Location = new System.Drawing.Point(19, 73);
            this.filtro2.Name = "filtro2";
            this.filtro2.Size = new System.Drawing.Size(32, 13);
            this.filtro2.TabIndex = 5;
            this.filtro2.Text = "filtro2";
            // 
            // filtro3
            // 
            this.filtro3.AutoSize = true;
            this.filtro3.Location = new System.Drawing.Point(147, 38);
            this.filtro3.Name = "filtro3";
            this.filtro3.Size = new System.Drawing.Size(32, 13);
            this.filtro3.TabIndex = 6;
            this.filtro3.Text = "filtro3";
            // 
            // filtro4
            // 
            this.filtro4.AutoSize = true;
            this.filtro4.Location = new System.Drawing.Point(147, 73);
            this.filtro4.Name = "filtro4";
            this.filtro4.Size = new System.Drawing.Size(32, 13);
            this.filtro4.TabIndex = 7;
            this.filtro4.Text = "filtro4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(187, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.TabIndex = 11;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "nombre";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.DefaultCellStyle = dataGridViewCellStyle1;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Seleccionar";
            // 
            // ListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 406);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.filtro4);
            this.Controls.Add(this.filtro3);
            this.Controls.Add(this.filtro2);
            this.Controls.Add(this.filtro1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadoUsuarios";
            this.Text = "ListadoUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label filtro1;
        private System.Windows.Forms.Label filtro2;
        private System.Windows.Forms.Label filtro3;
        private System.Windows.Forms.Label filtro4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}