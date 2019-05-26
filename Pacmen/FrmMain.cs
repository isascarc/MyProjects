using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Windows.Media;
using Microsoft.VisualBasic;
using System.Windows.Media.Animation;

namespace Pacmen
{
    public partial class FrmMain : Form
    {
        Pacmen.FrmHelp p = new FrmHelp ();
        Pacmen.FrmHighScore q = new FrmHighScore ();
        public FrmMain()
        {
            InitializeComponent();
            //if (Registry.CurrentUser.OpenSubKey("Pacmen", true).GetValue("Mode").ToString() == System.IO.File.ReadAllText("Profiles.txt").GetHashCode().ToString())
            if (System.IO.File.Exists("Profiles.txt"))
            {
                string[] Lines = System.IO.File.ReadAllLines("Profiles.txt");
                foreach (string line in Lines)
                {
                    if (line.Contains("|"))
                    {
                        string[] spli = line.Split(new char[] { '|' });
                        Settings.profiles.Add(new Profile
                        {
                            Name = spli[0],
                            Language = int.Parse(spli[1]),
                            HighScore = new string[] { spli[2], spli[3], spli[4] },
                            HighLevel = spli[5],
                            men = spli[6],
                            Password = spli[7],
                            PlayMusic = bool.Parse(spli[8]),
                            PlaySound = bool.Parse(spli[9])
                        });
                    }
                    else
                        Settings.AP = int.Parse(line);
                }
                LblName.Text = "!" + Settings.profiles[Settings.AP].Name + ", " +
                    (Settings.profiles[Settings.AP].men == "0" ? "ברוך הבא" : "ברוכה הבאה");
            }
            else
            {
            EnterYourName:
                string res = Interaction.InputBox("הכנס בבקשה את שמך", "יצירת פרופיל");
                if (res.Trim() != "")
                {
                    Settings.profiles.Add(new Profile
                    {
                        Name = res,
                        HighScore = new string[] { "0", "0", "0" },
                        HighLevel = "",
                        Language = 0,
                        men = "0",
                        Password = "###",
                        PlayMusic = true,
                        PlaySound = true
                    });
                    System.IO.File.WriteAllLines("Profiles.txt", new string[] { Settings.ReturnLine(0), "0" });
                    Settings.AP = 0;
                    LblName.Text = "!" + Settings.profiles[Settings.AP].Name + ", " +
                        (Settings.profiles[Settings.AP].men == "0" ? "ברוך הבא" : "ברוכה הבאה");
                    }
                else
                    goto EnterYourName;
            }
        }
        

        private void LblName_Click(object sender, EventArgs e)
        {
            FrmSelectProfile Selector = new FrmSelectProfile();
            if (Selector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                LblName.Text = "!" + Settings.profiles[Settings.AP].Name + ", " +
                    (Settings.profiles[Settings.AP].men == "0" ? "ברוך הבא" : "ברוכה הבאה");
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            if (Settings.profiles[Settings.AP].PlayMusic)
            {
                Settings.player.Open(new Uri(System.Windows.Forms.Application.StartupPath + "//Song.mp3"));
                Settings.player.Play();
            }
            FrmPacmen pac = new FrmPacmen();
            pac.ShowDialog();
            Settings.player.Stop();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings set = new FrmSettings();
            set.ShowDialog();
        }

        private void BtnProfiles_Click(object sender, EventArgs e)
        {
            tlp1.Hide();
            this.Controls.Add(q.TlpHS);
            this.q.TlpHS.Controls["BtnBack"].Click += TlpHS_Click;
            System.Text.StringBuilder MyText = new System.Text.StringBuilder("הניקוד הגבוה ביותר:");
            MyText.Append("\n" + "1. " + Settings.profiles[Settings.AP].HighScore[0]);//load all data...
            if (Settings.profiles[Settings.AP].HighScore[1] != "0")
                MyText.Append("\n" + "2. " + Settings.profiles[Settings.AP].HighScore[1]);
            if (Settings.profiles[Settings.AP].HighScore[2] != "0")
                MyText.Append("\n" + "3. " + Settings.profiles[Settings.AP].HighScore[2]);
            MyText.Append("\n" + "\n" + "השלב הגבוה ביותר:" + "\n" + Settings.profiles[Settings.AP].HighLevel);
            this.q.TlpHS.Controls["LblHS"].Text = MyText.ToString();
            this.q.TlpHS.Controls["BtnBack"].Focus();
        }

        void TlpHS_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(q.TlpHS );
            tlp1.Show();
            BtnNewGame.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("?האם אתה בטוח שברצונך לצאת", "Pacmen", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            tlp1.Hide();
            this.Controls.Add(p .TlpMy);
            this.p.TlpMy.Controls["BtnBack"].Click += TlpMy_Click;
            this.p.TlpMy.Controls["BtnBack"].Focus();
            //System.Diagnostics.Process.Start("Main Help.html");
        }

        void TlpMy_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(p.TlpMy);
            tlp1.Show();
            BtnNewGame.Focus();
        }
        
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Registry.CurrentUser.OpenSubKey("Pacmen", true).SetValue("Mode", System.IO.File.ReadAllText("Profiles.txt").GetHashCode().ToString());
        }
    }
}