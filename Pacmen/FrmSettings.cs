using System;
using System.Windows.Forms;

namespace Pacmen
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            CmbLanguages.SelectedIndex = Settings.profiles[Settings.AP].Language;
            //ChbSounds.Checked = Settings.profiles[Settings.AP].PlaySound;
            //ChbMusic.Checked = Settings.profiles[Settings.AP].PlayMusic;
            if (!Settings.profiles[Settings.AP].PlayMusic)
            {
                button1.BackgroundImage = Pacmen.Properties.Resources.NoSound;
                button1.Tag = "0";
            }
            if (!Settings.profiles[Settings.AP].PlaySound )
            {
                button2.BackgroundImage = Pacmen.Properties.Resources.NoSound;
                button2.Tag = "0";
            }
        }

        private void CmdOk_Click(object sender, EventArgs e)
        {
            this.Close();
            //update file & profile
            Settings.profiles[Settings.AP].Language = CmbLanguages.SelectedIndex;
            Settings.profiles[Settings.AP].PlayMusic = ((string)button1.Tag) == "1";
            Settings.profiles[Settings.AP].PlaySound = ((string)button2.Tag) == "1";
            string[] lines = System.IO.File.ReadAllLines("Profiles.txt");
            lines[Settings.AP] = Settings.ReturnLine(Settings.AP);
            System.IO.File.WriteAllLines("Profiles.txt", lines);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((string)button1.Tag) == "1")
            {
                button1.BackgroundImage  = Pacmen.Properties.Resources.NoSound;
                button1.Tag = "0";
            }
            else
            {
                button1.BackgroundImage  = Pacmen.Properties.Resources.sound ;
                button1.Tag = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (((string)button2.Tag) == "1")
            {
                button2.BackgroundImage = Pacmen.Properties.Resources.NoSound;
                button2.Tag = "0";
            }
            else
            {
                button2.BackgroundImage = Pacmen.Properties.Resources.sound;
                button2.Tag = "1";
            }
        }
    }
}