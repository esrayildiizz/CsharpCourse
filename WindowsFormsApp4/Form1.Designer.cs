
namespace WindowsFormsApp4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.satılıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.daireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.villaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dükkanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satılıkToolStripMenuItem,
            this.kiralıkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(659, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // satılıkToolStripMenuItem
            // 
            this.satılıkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daireToolStripMenuItem,
            this.villaToolStripMenuItem,
            this.arsaToolStripMenuItem});
            this.satılıkToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satılıkToolStripMenuItem.Name = "satılıkToolStripMenuItem";
            this.satılıkToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.satılıkToolStripMenuItem.Text = "Satılık";
            // 
            // kiralıkToolStripMenuItem
            // 
            this.kiralıkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daireToolStripMenuItem1,
            this.dükkanToolStripMenuItem});
            this.kiralıkToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiralıkToolStripMenuItem.Name = "kiralıkToolStripMenuItem";
            this.kiralıkToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.kiralıkToolStripMenuItem.Text = "Kiralık";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // daireToolStripMenuItem
            // 
            this.daireToolStripMenuItem.Name = "daireToolStripMenuItem";
            this.daireToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.daireToolStripMenuItem.Text = "SatılıkDaire";
            this.daireToolStripMenuItem.Click += new System.EventHandler(this.daireToolStripMenuItem_Click);
            // 
            // villaToolStripMenuItem
            // 
            this.villaToolStripMenuItem.Name = "villaToolStripMenuItem";
            this.villaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.villaToolStripMenuItem.Text = "Villa";
            this.villaToolStripMenuItem.Click += new System.EventHandler(this.villaToolStripMenuItem_Click);
            // 
            // arsaToolStripMenuItem
            // 
            this.arsaToolStripMenuItem.Name = "arsaToolStripMenuItem";
            this.arsaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.arsaToolStripMenuItem.Text = "Arsa";
            this.arsaToolStripMenuItem.Click += new System.EventHandler(this.arsaToolStripMenuItem_Click);
            // 
            // daireToolStripMenuItem1
            // 
            this.daireToolStripMenuItem1.Name = "daireToolStripMenuItem1";
            this.daireToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.daireToolStripMenuItem1.Text = "Kiralık Daire";
            this.daireToolStripMenuItem1.Click += new System.EventHandler(this.daireToolStripMenuItem1_Click);
            // 
            // dükkanToolStripMenuItem
            // 
            this.dükkanToolStripMenuItem.Name = "dükkanToolStripMenuItem";
            this.dükkanToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.dükkanToolStripMenuItem.Text = "Dükkan";
            this.dükkanToolStripMenuItem.Click += new System.EventHandler(this.dükkanToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 129);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "EMLAK";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satılıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem villaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dükkanToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

