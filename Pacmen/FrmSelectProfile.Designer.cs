namespace Pacmen
{
    partial class FrmSelectProfile
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
            this.CmmdOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbxProfiles = new System.Windows.Forms.ListBox();
            this.CmdPassword = new System.Windows.Forms.Button();
            this.CmdRename = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmmdOk
            // 
            this.CmmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmmdOk.Location = new System.Drawing.Point(35, 340);
            this.CmmdOk.Name = "CmmdOk";
            this.CmmdOk.Size = new System.Drawing.Size(72, 23);
            this.CmmdOk.TabIndex = 0;
            this.CmmdOk.Text = "בחר";
            this.CmmdOk.UseVisualStyleBackColor = true;
            this.CmmdOk.Click += new System.EventHandler(this.CmmdOk_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "בחר פרופיל מתוך הרשימה";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbxProfiles
            // 
            this.LbxProfiles.FormattingEnabled = true;
            this.LbxProfiles.Location = new System.Drawing.Point(35, 108);
            this.LbxProfiles.Name = "LbxProfiles";
            this.LbxProfiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbxProfiles.Size = new System.Drawing.Size(282, 147);
            this.LbxProfiles.TabIndex = 0;
            // 
            // CmdPassword
            // 
            this.CmdPassword.Location = new System.Drawing.Point(35, 262);
            this.CmdPassword.Name = "CmdPassword";
            this.CmdPassword.Size = new System.Drawing.Size(72, 23);
            this.CmdPassword.TabIndex = 5;
            this.CmdPassword.Text = "...סיסמא";
            this.CmdPassword.UseVisualStyleBackColor = true;
            this.CmdPassword.Click += new System.EventHandler(this.CmdPassword_Click);
            // 
            // CmdRename
            // 
            this.CmdRename.Location = new System.Drawing.Point(113, 262);
            this.CmdRename.Name = "CmdRename";
            this.CmdRename.Size = new System.Drawing.Size(62, 23);
            this.CmdRename.TabIndex = 6;
            this.CmdRename.Text = "שנה שם";
            this.CmdRename.UseVisualStyleBackColor = true;
            this.CmdRename.Click += new System.EventHandler(this.CmdRename_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(181, 262);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(70, 23);
            this.CmdDelete.TabIndex = 7;
            this.CmdDelete.Text = "מחיקה";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(257, 262);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(60, 23);
            this.CmdNew.TabIndex = 8;
            this.CmdNew.Text = "הוספה";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "בחירת פרופיל";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSelectProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(362, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdNew);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdRename);
            this.Controls.Add(this.CmdPassword);
            this.Controls.Add(this.LbxProfiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectProfile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "בחירת פרופיל";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmmdOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LbxProfiles;
        private System.Windows.Forms.Button CmdPassword;
        private System.Windows.Forms.Button CmdRename;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdNew;
        private System.Windows.Forms.Label label2;
    }
}