namespace GrouponDesktop
{
    partial class ComprarCupon
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
            this.Btn_Comprar = new System.Windows.Forms.Button();
            this.DataGrid_Cupones = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Cupones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Comprar
            // 
            this.Btn_Comprar.Location = new System.Drawing.Point(370, 335);
            this.Btn_Comprar.Name = "Btn_Comprar";
            this.Btn_Comprar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Comprar.TabIndex = 1;
            this.Btn_Comprar.Text = "Comprar";
            this.Btn_Comprar.UseVisualStyleBackColor = true;
            this.Btn_Comprar.Click += new System.EventHandler(this.Btn_Comprar_Click);
            // 
            // DataGrid_Cupones
            // 
            this.DataGrid_Cupones.AllowUserToAddRows = false;
            this.DataGrid_Cupones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGrid_Cupones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid_Cupones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Cupones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_Cupones.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_Cupones.MultiSelect = false;
            this.DataGrid_Cupones.Name = "DataGrid_Cupones";
            this.DataGrid_Cupones.ReadOnly = true;
            this.DataGrid_Cupones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Cupones.Size = new System.Drawing.Size(882, 235);
            this.DataGrid_Cupones.TabIndex = 2;
            this.DataGrid_Cupones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Cupones_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGrid_Cupones);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 235);
            this.panel1.TabIndex = 3;
            // 
            // ComprarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Comprar);
            this.Name = "ComprarCupon";
            this.Text = "ComprarCupon";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Cupones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Comprar;
        private System.Windows.Forms.DataGridView DataGrid_Cupones;
        private System.Windows.Forms.Panel panel1;
    }
}