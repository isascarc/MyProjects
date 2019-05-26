namespace Pacmen
{
    partial class FrmHighScore
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
            this.TlpHS = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblHS = new System.Windows.Forms.Label();
            this.TlpHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpHS
            // 
            this.TlpHS.ColumnCount = 3;
            this.TlpHS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.999989F));
            this.TlpHS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.00001F));
            this.TlpHS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TlpHS.Controls.Add(this.label1, 1, 1);
            this.TlpHS.Controls.Add(this.BtnBack, 2, 0);
            this.TlpHS.Controls.Add(this.pictureBox2, 1, 0);
            this.TlpHS.Controls.Add(this.LblHS, 1, 2);
            this.TlpHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpHS.Location = new System.Drawing.Point(0, 0);
            this.TlpHS.Name = "TlpHS";
            this.TlpHS.RowCount = 3;
            this.TlpHS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpHS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpHS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.TlpHS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpHS.Size = new System.Drawing.Size(1203, 464);
            this.TlpHS.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 84F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1076, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "השיאים שלי";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.BackgroundImage = global::Pacmen.Properties.Resources.right;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.Location = new System.Drawing.Point(1150, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(50, 40);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(564, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // LblHS
            // 
            this.LblHS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LblHS.ForeColor = System.Drawing.Color.DeepPink;
            this.LblHS.Location = new System.Drawing.Point(697, 115);
            this.LblHS.Name = "LblHS";
            this.LblHS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblHS.Size = new System.Drawing.Size(442, 167);
            this.LblHS.TabIndex = 4;
            this.LblHS.Text = "הניקוד הגבוה ביותר :";
            // 
            // FrmHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 464);
            this.Controls.Add(this.TlpHS);
            this.Name = "FrmHighScore";
            this.Text = "Form2";
            this.TlpHS.ResumeLayout(false);
            this.TlpHS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        public System.Windows.Forms.TableLayoutPanel TlpHS;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblHS;
        private System.Windows.Forms.Label label1;
    }
}