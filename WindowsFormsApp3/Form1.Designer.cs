
namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manavReyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kıyafetlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayakkabılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manavReyToolStripMenuItem,
            this.kıyafetlerToolStripMenuItem,
            this.ayakkabılarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manavReyToolStripMenuItem
            // 
            this.manavReyToolStripMenuItem.Name = "manavReyToolStripMenuItem";
            this.manavReyToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.manavReyToolStripMenuItem.Text = "Manav reyonu";
            this.manavReyToolStripMenuItem.Click += new System.EventHandler(this.manavReyToolStripMenuItem_Click);
            // 
            // kıyafetlerToolStripMenuItem
            // 
            this.kıyafetlerToolStripMenuItem.Name = "kıyafetlerToolStripMenuItem";
            this.kıyafetlerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.kıyafetlerToolStripMenuItem.Text = "Kıyafetler";
            // 
            // ayakkabılarToolStripMenuItem
            // 
            this.ayakkabılarToolStripMenuItem.Name = "ayakkabılarToolStripMenuItem";
            this.ayakkabılarToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ayakkabılarToolStripMenuItem.Text = "Ayakkabılar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 168);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manavReyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kıyafetlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayakkabılarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

