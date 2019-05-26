using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pacmen
{
    public partial class FrmSelectProfile : Form
    {
        public FrmSelectProfile()
        {
            InitializeComponent();

            for (int i = 0; i < Settings.profiles.Count(); i++)
                LbxProfiles.Items.Add(Settings.profiles[i].Name);
            LbxProfiles.SelectedIndex = Settings.AP;
            LbxProfiles.Focus();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.GetCultureInfo(1037));
        }

        private void CmmdOk_Click(object sender, EventArgs e)
        {
            Settings.AP = LbxProfiles.SelectedIndex;                     // write to file the 'profil actuali' new.
            string[] lines = System.IO.File.ReadAllLines("Profiles.txt");
            lines[lines.Length - 1] = Settings.AP.ToString();
            System.IO.File.WriteAllLines("Profiles.txt", lines);
            this.Close();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            if (Settings.profiles.Count > 1)
            {
                if (LbxProfiles.SelectedIndex != Settings.AP)
                {
                    if (MessageBox.Show("האם אתה בטוח שברצונך למחוק את הפרופיל " + LbxProfiles.Text, "סנייק", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string[] lines = System.IO.File.ReadAllLines(@"Profiles.txt");

                        System.IO.StreamWriter file = new System.IO.StreamWriter(@"Profiles.txt");

                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (i != LbxProfiles.SelectedIndex)
                                file.WriteLine(lines[i]);
                        }
                        file.Close();

                        Settings.profiles.Remove(Settings.profiles[LbxProfiles.SelectedIndex]);
                        LbxProfiles.Items.Remove(LbxProfiles.Text);
                        LbxProfiles.SetSelected(0, true);
                    }
                }
                else
                    MessageBox.Show("אין באפשרותך למחוק את הפרופיל " + LbxProfiles.SelectedItem.ToString() + " כל זמן שהוא פתוח");
            }
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            string res = Interaction.InputBox("הכנס בבקשה את שמך", "יצירת פרופיל");
            if (res.Trim() != "")
            {
                Settings. CreateProfile(res);
                LbxProfiles.Items.Add(Settings.profiles[Settings.profiles.Count - 1].Name);

            }
            else
                MessageBox.Show("לא הוזן שם ליצירת הפרופיל");
        }

        private void CmdRename_Click(object sender, EventArgs e)
        {
        InputNewName:
            string NewName = Interaction.InputBox("הכנס שם חדש", "שינוי שם פרופיל", LbxProfiles.Text);
            if (string.IsNullOrWhiteSpace(NewName))
            {
                MessageBox.Show("נא הכנס שם חדש");
                goto InputNewName;
            }
            else
            {
                Settings.profiles[LbxProfiles.SelectedIndex].Name = NewName;
                LbxProfiles.Items[LbxProfiles.SelectedIndex] = NewName;
                string[] lines = System.IO.File.ReadAllLines("Profiles.txt");
                lines[LbxProfiles.SelectedIndex] = Settings.ReturnLine(LbxProfiles.SelectedIndex);
                System.IO.File.WriteAllLines("Profiles.txt", lines);
            }
        }

        private void CmdPassword_Click(object sender, EventArgs e)
        {
            if (Settings.profiles[LbxProfiles.SelectedIndex].Password != null)
            {
                string res = Interaction.InputBox("הפרופיל מוגן באמצות סיסמא, נא הכנס כאן את הסיסמא שלך");
                if (res == Settings.profiles[LbxProfiles.SelectedIndex].Password)
                {
                    string pas = Interaction.InputBox("הסיסמא נכונה. נא הכנס את הסיסמא החדשה שברצונך לבחור");
                    Settings.profiles[LbxProfiles.SelectedIndex].Password = pas;

                    string[] lines = System.IO.File.ReadAllLines("Profiles.txt");
                    lines[LbxProfiles.SelectedIndex] = Settings.profiles[LbxProfiles.SelectedIndex].Name + "|" +
                        Settings.profiles[LbxProfiles.SelectedIndex].Language.ToString() + "|" +
                        Settings.profiles[LbxProfiles.SelectedIndex].HighScore + "|" +
                        Settings.profiles[LbxProfiles.SelectedIndex].men +
                        (pas == "" ? "" : "|" + Settings.profiles[LbxProfiles.SelectedIndex].Password);
                    System.IO.File.WriteAllLines("Profiles.txt", lines);

                    MessageBox.Show("הסיסמא שונתה בהצלחה");
                }
                else
                    MessageBox.Show("הסיסמא שהזנת אינה נכונה");
            }
            else
            {
                if (MessageBox.Show("?לפרופיל זה לא קיימת סיסמא. האם ברצונך ליצור סיסמא חדשה", "Pacmen", MessageBoxButtons.YesNo) 
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    string res = Interaction.InputBox("הכנס כאן את הסיסמא שלך");
                    if (!string.IsNullOrEmpty(res))
                    {
                        Settings.profiles[LbxProfiles.SelectedIndex].Password = res;

                        string[] lines = System.IO.File.ReadAllLines("Profiles.txt");
                        lines[LbxProfiles.SelectedIndex] = Settings.profiles[LbxProfiles.SelectedIndex].Name + "|" +
                            Settings.profiles[LbxProfiles.SelectedIndex].Language.ToString() + "|" +
                            Settings.profiles[LbxProfiles.SelectedIndex].HighScore + "|" +
                            Settings.profiles[LbxProfiles.SelectedIndex].men + "|"+
                            Settings.profiles[LbxProfiles.SelectedIndex].Password;
                        System.IO.File.WriteAllLines("Profiles.txt", lines);
                        MessageBox.Show("הסיסמא נוצרה בהצלחה");
                    }
                }
            }
        }
    }
}