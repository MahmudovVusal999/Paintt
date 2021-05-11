
namespace Paint
{
    partial class Paint
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.panel_top = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_piccolor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_line = new System.Windows.Forms.Button();
            this.button_rect = new System.Windows.Forms.Button();
            this.button_ellipse = new System.Windows.Forms.Button();
            this.button_pencil = new System.Windows.Forms.Button();
            this.button_eraser = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.pictureBox_big = new System.Windows.Forms.PictureBox();
            this.panel_top.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_big)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.SlateGray;
            this.panel_top.Controls.Add(this.button_clear);
            this.panel_top.Controls.Add(this.button_save);
            this.panel_top.Controls.Add(this.button_piccolor);
            this.panel_top.Controls.Add(this.panel1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(862, 100);
            this.panel_top.TabIndex = 0;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.White;
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.FlatAppearance.BorderSize = 2;
            this.button_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.ForeColor = System.Drawing.Color.Black;
            this.button_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_clear.Location = new System.Drawing.Point(461, 12);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(96, 31);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.White;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatAppearance.BorderSize = 2;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.ForeColor = System.Drawing.Color.Black;
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_save.Location = new System.Drawing.Point(461, 56);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(96, 31);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_piccolor
            // 
            this.button_piccolor.BackColor = System.Drawing.Color.Black;
            this.button_piccolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_piccolor.Location = new System.Drawing.Point(407, 27);
            this.button_piccolor.Name = "button_piccolor";
            this.button_piccolor.Size = new System.Drawing.Size(48, 46);
            this.button_piccolor.TabIndex = 0;
            this.button_piccolor.UseVisualStyleBackColor = false;
            this.button_piccolor.Click += new System.EventHandler(this.button_piccolor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button_line);
            this.panel1.Controls.Add(this.button_rect);
            this.panel1.Controls.Add(this.button_ellipse);
            this.panel1.Controls.Add(this.button_pencil);
            this.panel1.Controls.Add(this.button_eraser);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 94);
            this.panel1.TabIndex = 3;
            // 
            // button_line
            // 
            this.button_line.BackColor = System.Drawing.Color.White;
            this.button_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_line.FlatAppearance.BorderSize = 2;
            this.button_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_line.ForeColor = System.Drawing.Color.Black;
            this.button_line.Image = ((System.Drawing.Image)(resources.GetObject("button_line.Image")));
            this.button_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_line.Location = new System.Drawing.Point(317, 15);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(71, 66);
            this.button_line.TabIndex = 7;
            this.button_line.Text = "Line";
            this.button_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_line.UseVisualStyleBackColor = false;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // button_rect
            // 
            this.button_rect.BackColor = System.Drawing.Color.White;
            this.button_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rect.FlatAppearance.BorderSize = 2;
            this.button_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rect.ForeColor = System.Drawing.Color.Black;
            this.button_rect.Image = ((System.Drawing.Image)(resources.GetObject("button_rect.Image")));
            this.button_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_rect.Location = new System.Drawing.Point(240, 15);
            this.button_rect.Name = "button_rect";
            this.button_rect.Size = new System.Drawing.Size(71, 66);
            this.button_rect.TabIndex = 6;
            this.button_rect.Text = "Rect";
            this.button_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_rect.UseVisualStyleBackColor = false;
            this.button_rect.Click += new System.EventHandler(this.button_rect_Click);
            // 
            // button_ellipse
            // 
            this.button_ellipse.BackColor = System.Drawing.Color.White;
            this.button_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ellipse.FlatAppearance.BorderSize = 2;
            this.button_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ellipse.ForeColor = System.Drawing.Color.Black;
            this.button_ellipse.Image = ((System.Drawing.Image)(resources.GetObject("button_ellipse.Image")));
            this.button_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ellipse.Location = new System.Drawing.Point(163, 15);
            this.button_ellipse.Name = "button_ellipse";
            this.button_ellipse.Size = new System.Drawing.Size(71, 66);
            this.button_ellipse.TabIndex = 5;
            this.button_ellipse.Text = "Ellipse";
            this.button_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ellipse.UseVisualStyleBackColor = false;
            this.button_ellipse.Click += new System.EventHandler(this.button_ellipse_Click);
            // 
            // button_pencil
            // 
            this.button_pencil.BackColor = System.Drawing.Color.White;
            this.button_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pencil.FlatAppearance.BorderSize = 2;
            this.button_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pencil.ForeColor = System.Drawing.Color.Black;
            this.button_pencil.Image = ((System.Drawing.Image)(resources.GetObject("button_pencil.Image")));
            this.button_pencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_pencil.Location = new System.Drawing.Point(9, 15);
            this.button_pencil.Name = "button_pencil";
            this.button_pencil.Size = new System.Drawing.Size(71, 66);
            this.button_pencil.TabIndex = 3;
            this.button_pencil.Text = "Pencil";
            this.button_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_pencil.UseVisualStyleBackColor = false;
            this.button_pencil.Click += new System.EventHandler(this.button_pencil_Click);
            // 
            // button_eraser
            // 
            this.button_eraser.BackColor = System.Drawing.Color.White;
            this.button_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_eraser.FlatAppearance.BorderSize = 2;
            this.button_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eraser.ForeColor = System.Drawing.Color.Black;
            this.button_eraser.Image = ((System.Drawing.Image)(resources.GetObject("button_eraser.Image")));
            this.button_eraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_eraser.Location = new System.Drawing.Point(86, 15);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.Size = new System.Drawing.Size(71, 66);
            this.button_eraser.TabIndex = 4;
            this.button_eraser.Text = "Eraser";
            this.button_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_eraser.UseVisualStyleBackColor = false;
            this.button_eraser.Click += new System.EventHandler(this.button_eraser_Click);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.SlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 464);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(862, 39);
            this.panel_bottom.TabIndex = 1;
            // 
            // pictureBox_big
            // 
            this.pictureBox_big.BackColor = System.Drawing.Color.White;
            this.pictureBox_big.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_big.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_big.Name = "pictureBox_big";
            this.pictureBox_big.Size = new System.Drawing.Size(862, 503);
            this.pictureBox_big.TabIndex = 2;
            this.pictureBox_big.TabStop = false;
            this.pictureBox_big.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_big_Paint);
            this.pictureBox_big.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_big_MouseDown);
            this.pictureBox_big.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_big_MouseMove);
            this.pictureBox_big.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_big_MouseUp);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 503);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.pictureBox_big);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel_top.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_big)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.PictureBox pictureBox_big;
        private System.Windows.Forms.Button button_piccolor;
        private System.Windows.Forms.Button button_pencil;
        private System.Windows.Forms.Button button_rect;
        private System.Windows.Forms.Button button_ellipse;
        private System.Windows.Forms.Button button_eraser;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_save;
    }
}

