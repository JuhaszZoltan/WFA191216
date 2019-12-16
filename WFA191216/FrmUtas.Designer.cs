namespace WFA191216
{
    partial class FrmUtas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTorles = new System.Windows.Forms.ToolStripMenuItem();
            this.üresŰrlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKod = new System.Windows.Forms.TextBox();
            this.rtbCim = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.cbJelentkezes = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresésToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.tsmiTorles,
            this.üresŰrlapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(342, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(156, 294);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Image = global::WFA191216.Properties.Resources.keres;
            this.keresésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(143, 60);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.KeresesTSMI_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Image = global::WFA191216.Properties.Resources.ment;
            this.mentésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(143, 60);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.MentesTSMI_Click);
            // 
            // tsmiTorles
            // 
            this.tsmiTorles.Enabled = false;
            this.tsmiTorles.Image = global::WFA191216.Properties.Resources.delete;
            this.tsmiTorles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTorles.Name = "tsmiTorles";
            this.tsmiTorles.Size = new System.Drawing.Size(143, 60);
            this.tsmiTorles.Text = "Törlés";
            this.tsmiTorles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiTorles.Click += new System.EventHandler(this.tsmiTorles_Click);
            // 
            // üresŰrlapToolStripMenuItem
            // 
            this.üresŰrlapToolStripMenuItem.Image = global::WFA191216.Properties.Resources.ures;
            this.üresŰrlapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.üresŰrlapToolStripMenuItem.Name = "üresŰrlapToolStripMenuItem";
            this.üresŰrlapToolStripMenuItem.Size = new System.Drawing.Size(143, 60);
            this.üresŰrlapToolStripMenuItem.Text = "Üres Űrlap";
            this.üresŰrlapToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.üresŰrlapToolStripMenuItem.Click += new System.EventHandler(this.UresUrlapTSMI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utas kód:";
            // 
            // tbKod
            // 
            this.tbKod.Enabled = false;
            this.tbKod.Location = new System.Drawing.Point(160, 46);
            this.tbKod.Name = "tbKod";
            this.tbKod.Size = new System.Drawing.Size(100, 22);
            this.tbKod.TabIndex = 2;
            this.tbKod.TextChanged += new System.EventHandler(this.tbKod_TextChanged);
            // 
            // rtbCim
            // 
            this.rtbCim.Location = new System.Drawing.Point(160, 144);
            this.rtbCim.Name = "rtbCim";
            this.rtbCim.Size = new System.Drawing.Size(191, 69);
            this.rtbCim.TabIndex = 3;
            this.rtbCim.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cím:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jelentkezés:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(160, 97);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(191, 22);
            this.tbNev.TabIndex = 2;
            // 
            // cbJelentkezes
            // 
            this.cbJelentkezes.FormattingEnabled = true;
            this.cbJelentkezes.Location = new System.Drawing.Point(160, 236);
            this.cbJelentkezes.Name = "cbJelentkezes";
            this.cbJelentkezes.Size = new System.Drawing.Size(100, 24);
            this.cbJelentkezes.TabIndex = 4;
            // 
            // FrmUtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 294);
            this.Controls.Add(this.cbJelentkezes);
            this.Controls.Add(this.rtbCim);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbKod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUtas";
            this.Text = "FrmUtas";
            this.Load += new System.EventHandler(this.FrmUtas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTorles;
        private System.Windows.Forms.ToolStripMenuItem üresŰrlapToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.RichTextBox rtbCim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.ComboBox cbJelentkezes;
    }
}