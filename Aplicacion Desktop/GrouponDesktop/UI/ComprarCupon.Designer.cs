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
            this.DataGrid_Cupones = new System.Windows.Forms.DataGridView();
            this.Btn_Comprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Cupones)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Cupones
            // 
            this.DataGrid_Cupones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Cupones.Location = new System.Drawing.Point(12, 12);
            this.DataGrid_Cupones.Name = "DataGrid_Cupones";
            this.DataGrid_Cupones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGrid_Cupones.Size = new System.Drawing.Size(566, 191);
            this.DataGrid_Cupones.TabIndex = 0;
            // 
            // Btn_Comprar
            // 
            this.Btn_Comprar.Enabled = false;
            this.Btn_Comprar.Location = new System.Drawing.Point(240, 319);
            this.Btn_Comprar.Name = "Btn_Comprar";
            this.Btn_Comprar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Comprar.TabIndex = 1;
            this.Btn_Comprar.Text = "Comprar";
            this.Btn_Comprar.UseVisualStyleBackColor = true;
            this.Btn_Comprar.Click += new System.EventHandler(this.Btn_Comprar_Click);
            // 
            // ComprarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 428);
            this.Controls.Add(this.Btn_Comprar);
            this.Controls.Add(this.DataGrid_Cupones);
            this.Name = "ComprarCupon";
            this.Text = "ComprarCupon";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Cupones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Cupones;
        private System.Windows.Forms.Button Btn_Comprar;
    }
}