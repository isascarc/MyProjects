namespace Pacmen
{
    partial class FrmPacmen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacmen));
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblLevel = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.PicFooder = new System.Windows.Forms.PictureBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.Waiter = new Pacmen.UserControl1();
            this.tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFooder)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tlp.ColumnCount = 6;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp.Controls.Add(this.label4, 3, 0);
            this.tlp.Controls.Add(this.lblLives, 5, 0);
            this.tlp.Controls.Add(this.label2, 4, 0);
            this.tlp.Controls.Add(this.lblScore, 1, 0);
            this.tlp.Controls.Add(this.label3, 0, 0);
            this.tlp.Controls.Add(this.LblLevel, 2, 0);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp.Location = new System.Drawing.Point(0, 458);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp.Size = new System.Drawing.Size(1170, 44);
            this.tlp.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(586, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 44);
            this.label4.TabIndex = 20;
            this.label4.Text = "שלב";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLives
            // 
            this.lblLives.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLives.Location = new System.Drawing.Point(982, 0);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(71, 44);
            this.lblLives.TabIndex = 18;
            this.lblLives.Text = "1";
            this.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(784, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 44);
            this.label2.TabIndex = 16;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScore
            // 
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblScore.Location = new System.Drawing.Point(190, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(192, 44);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "נקודות";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblLevel.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.LblLevel.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblLevel.Location = new System.Drawing.Point(388, 0);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(192, 44);
            this.LblLevel.TabIndex = 19;
            this.LblLevel.Text = "0";
            this.LblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pbCanvas.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbCanvas.Location = new System.Drawing.Point(12, 120);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(90, 71);
            this.pbCanvas.TabIndex = 10;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Visible = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // PicFooder
            // 
            this.PicFooder.Image = ((System.Drawing.Image)(resources.GetObject("PicFooder.Image")));
            this.PicFooder.Location = new System.Drawing.Point(12, 12);
            this.PicFooder.Name = "PicFooder";
            this.PicFooder.Size = new System.Drawing.Size(78, 75);
            this.PicFooder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFooder.TabIndex = 12;
            this.PicFooder.TabStop = false;
            this.PicFooder.Visible = false;
            // 
            // LblTime
            // 
            this.LblTime.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblTime.Location = new System.Drawing.Point(96, 12);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(88, 75);
            this.LblTime.TabIndex = 13;
            this.LblTime.Text = "00";
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTime.Visible = false;
            // 
            // Waiter
            // 
            this.Waiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Waiter.Location = new System.Drawing.Point(22, 228);
            this.Waiter.Name = "Waiter";
            this.Waiter.Size = new System.Drawing.Size(235, 114);
            this.Waiter.TabIndex = 15;
            // 
            // FrmPacmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 502);
            this.Controls.Add(this.Waiter);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.PicFooder);
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.pbCanvas);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPacmen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPacmen_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFooder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.PictureBox PicFooder;
        private System.Windows.Forms.Label LblTime;
        private UserControl1 Waiter;
    }
}
