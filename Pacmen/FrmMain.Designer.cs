namespace Pacmen
{
    partial class FrmMain
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
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnProfiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.button55 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.tlp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 3;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tlp1.Controls.Add(this.BtnHelp, 1, 6);
            this.tlp1.Controls.Add(this.BtnSettings, 1, 5);
            this.tlp1.Controls.Add(this.BtnExit, 1, 7);
            this.tlp1.Controls.Add(this.BtnProfiles, 1, 4);
            this.tlp1.Controls.Add(this.label1, 0, 0);
            this.tlp1.Controls.Add(this.LblName, 1, 1);
            this.tlp1.Controls.Add(this.BtnNewGame, 1, 3);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 9;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp1.Size = new System.Drawing.Size(1170, 502);
            this.tlp1.TabIndex = 5;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.BtnHelp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnHelp.Location = new System.Drawing.Point(428, 373);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(313, 29);
            this.BtnHelp.TabIndex = 3;
            this.BtnHelp.Text = "עזרה";
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.BtnSettings.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnSettings.Location = new System.Drawing.Point(428, 338);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(313, 29);
            this.BtnSettings.TabIndex = 2;
            this.BtnSettings.Text = "הגדרות";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.BtnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnExit.Location = new System.Drawing.Point(428, 408);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(313, 29);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "יציאה";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnProfiles
            // 
            this.BtnProfiles.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnProfiles.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BtnProfiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.BtnProfiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.BtnProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.BtnProfiles.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnProfiles.Location = new System.Drawing.Point(428, 303);
            this.BtnProfiles.Name = "BtnProfiles";
            this.BtnProfiles.Size = new System.Drawing.Size(313, 29);
            this.BtnProfiles.TabIndex = 1;
            this.BtnProfiles.Text = "השיאים שלי";
            this.BtnProfiles.UseVisualStyleBackColor = true;
            this.BtnProfiles.Click += new System.EventHandler(this.BtnProfiles_Click);
            // 
            // label1
            // 
            this.tlp1.SetColumnSpan(this.label1, 3);
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Guttman Kav", 144F);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1164, 195);
            this.label1.TabIndex = 2;
            this.label1.Text = "פקמן";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblName.Font = new System.Drawing.Font("Guttman Kav", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LblName.ForeColor = System.Drawing.Color.Fuchsia;
            this.LblName.Location = new System.Drawing.Point(428, 195);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(313, 35);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "שם";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblName.Click += new System.EventHandler(this.LblName_Click);
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.BtnNewGame.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnNewGame.Location = new System.Drawing.Point(428, 268);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(313, 29);
            this.BtnNewGame.TabIndex = 0;
            this.BtnNewGame.Text = "משחק חדש";
            this.BtnNewGame.UseVisualStyleBackColor = true;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // tlp2
            // 
            this.tlp2.Location = new System.Drawing.Point(0, 0);
            this.tlp2.Name = "tlp2";
            this.tlp2.Size = new System.Drawing.Size(200, 100);
            this.tlp2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            // 
            // button55
            // 
            this.button55.Location = new System.Drawing.Point(0, 0);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(75, 23);
            this.button55.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label22.ForeColor = System.Drawing.Color.Sienna;
            this.label22.Location = new System.Drawing.Point(13, 30);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(74, 70);
            this.label22.TabIndex = 4;
            this.label22.Text = "כאן יוצג הטקסט";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 502);
            this.Controls.Add(this.tlp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.tlp1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnProfiles;
        private System.Windows.Forms.Button BtnHelp;


        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.Label label22;
    }
}