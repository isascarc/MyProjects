using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media;

namespace Pacmen
{
    enum Direction { Left, Up, Down, Right };
    enum ImageToDraw { free, empty, food, block, blockTemp, reverser, key, pacmen, enemy, fooded, dollar, boom };

    static class Settings
    {
        /// <summary>
        /// This the Actual Profile.
        /// </summary>
        public static int AP { get; set; }
        public static List<Profile> profiles = new List<Profile>();
        public static MediaPlayer player = new MediaPlayer();
        public static string ReturnLine(int NumberProfile)
        {
            return
                Settings.profiles[NumberProfile].Name + "|" +
                Settings.profiles[NumberProfile].Language + "|" +
                Settings.profiles[NumberProfile].HighScore[0] + "|" +
                Settings.profiles[NumberProfile].HighScore[1] + "|" +
                Settings.profiles[NumberProfile].HighScore[2] + "|" +
                Settings.profiles[NumberProfile].HighLevel + "|" +
                Settings.profiles[NumberProfile].men + "|" +
                Settings.profiles[NumberProfile].Password + "|" +
                Settings.profiles[NumberProfile].PlayMusic + "|" +
                Settings.profiles[NumberProfile].PlaySound;
        }

        public static void CreateProfile(string name)
        {
            Settings.profiles.Add(new Profile
            {
                Name = name,
                HighScore = new string[] { "0", "0", "0" },
                Language = 0,
                men = "0",
                Password = "###",
                PlayMusic = true,
                PlaySound = true
            });
            string[] lines = System.IO.File.ReadAllLines("Profiles.txt");
            lines[lines.Length - 1] = Settings.ReturnLine(Settings.profiles.Count - 1);
            Array.Resize(ref lines, lines.Length + 1);
            lines[lines.Length - 1] = Settings.AP.ToString();
            System.IO.File.WriteAllLines("Profiles.txt", lines);
        }
    }

    class Profile
    {
        public string Name { get; set; }
        public string men { get; set; }
        public int Language { get; set; }
        public string Password { get; set; }
        public bool PlayMusic { get; set; }
        public bool PlaySound { get; set; }
        public  string[] HighScore = new string[3];
        public string HighLevel { get; set; }
    }

    struct Locaton
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Pocimon
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int OrginalX { get; set; }
        public int OrginalY { get; set; }
        public Direction direction { get; set; }
        public Direction? DirectionWant { get; set; }
        public int Speed { get; set; }
        public Direction IconDirection { get; set; }

        public Pocimon()
        {
            Speed = 50;
            DirectionWant = Direction.Left;
        }
    }

    class Enemy
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int OrginalX { get; set; }
        public int OrginalY { get; set; }
        public bool Dead { get; set; }
        public Direction direction { get; set; }
        public int ChelkeyX;
        public int ChelkeyY;
        public List<Direction> OptionalDirections = new List<Direction>();

        public Enemy()
        {
            direction = Direction.Right;
            ChelkeyX = 4;
            ChelkeyY = 4;
        }
    }
}