namespace WFA191216
{
    partial class FrmUtasLista
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
            this.tbNev = new System.Windows.Forms.TextBox();
            this.dgvUtasok = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtasok)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNev);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szűrés utas neve alapján:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(6, 21);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(304, 22);
            this.tbNev.TabIndex = 4;
            // 
            // dgvUtasok
            // 
            this.dgvUtasok.AllowUserToAddRows = false;
            this.dgvUtasok.AllowUserToDeleteRows = false;
            this.dgvUtasok.AllowUserToResizeColumns = false;
            this.dgvUtasok.AllowUserToResizeRows = false;
            this.dgvUtasok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtasok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvUtasok.Location = new System.Drawing.Point(12, 92);
            this.dgvUtasok.Name = "dgvUtasok";
            this.dgvUtasok.RowHeadersVisible = false;
            this.dgvUtasok.RowHeadersWidth = 51;
            this.dgvUtasok.RowTemplate.Height = 24;
            this.dgvUtasok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtasok.Size = new System.Drawing.Size(745, 275);
            this.dgvUtasok.TabIndex = 3;
            this.dgvUtasok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtasok_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 3F;
            this.Column1.HeaderText = "kód";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 8F;
            this.Column2.HeaderText = "név";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 8F;
            this.Column3.HeaderText = "cím";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 3F;
            this.Column4.HeaderText = "út_kód";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 8F;
            this.Column5.HeaderText = "kezdés";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 8F;
            this.Column6.HeaderText = "úticél";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCel);
            this.groupBox2.Location = new System.Drawing.Point(440, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 56);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szűrés túra útvonal célja alapján:";
            // 
            // tbCel
            // 
            this.tbCel.Location = new System.Drawing.Point(6, 21);
            this.tbCel.Name = "tbCel";
            this.tbCel.Size = new System.Drawing.Size(304, 22);
            this.tbCel.TabIndex = 4;
            // 
            // FrmUtasLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 379);
            this.Controls.Add(this.dgvUtasok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUtasLista";
            this.Text = "FrmUtasLista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtasok)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.DataGridView dgvUtasok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCel;
    }
}