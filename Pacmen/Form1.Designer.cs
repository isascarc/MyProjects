namespace Pacmen
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
        private void InitializeComponent2()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.button55 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.tlp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp2.ColumnCount = 3;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp2.Controls.Add(this.label11, 1, 0);
            this.tlp2.Controls.Add(this.button55, 2, 1);
            this.tlp2.Controls.Add(this.label22, 1, 2);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(0, 0);
            this.tlp2.Name = "tlp1";
            this.tlp2.RowCount = 3;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp2.Size = new System.Drawing.Size(1170, 502);
            this.tlp2.TabIndex = 5;
            // 
            // label1
            // 
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Guttman Kav", 100F);
            this.label11.ForeColor = System.Drawing.Color.Tomato;
            this.label11.Location = new System.Drawing.Point(120, 0);
            this.label11.Name = "label1";
            this.tlp2.SetRowSpan(this.label11, 2);
            this.label11.Size = new System.Drawing.Size(930, 150);
            this.label11.TabIndex = 2;
            this.label11.Text = "עזרה";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button55.BackgroundImage = global::Pacmen.Properties.Resources.right;
            this.button55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button55.Location = new System.Drawing.Point(1056, 53);
            this.button55.Name = "button1";
            this.button55.Size = new System.Drawing.Size(57, 56);
            this.button55.TabIndex = 3;
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label22.ForeColor = System.Drawing.Color.Sienna;
            this.label22.Location = new System.Drawing.Point(120, 150);
            this.label22.Name = "label2";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(930, 352);
            this.label22.TabIndex = 4;
            this.label22.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 502);
            this.Controls.Add(this.tlp2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.Label label22;


    }
}
