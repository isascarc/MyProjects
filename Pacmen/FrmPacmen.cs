using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pacmen
{
    public partial class FrmPacmen : Form
    {
        #region load game
        //Declare variables of board
        private Pocimon MyPacmen;
        private List<Enemy> enemy = new List<Enemy>();
        private int foods;
        private ImageToDraw[,] ListOfData1 = new ImageToDraw[100, 100];
        //Declare & load icons and sounds
        private Icon IconBlock = new Icon("block.ico");
        private Icon Iconfooder = new Icon("fooder.ico");
        private Icon IconStar = new Icon("star.ico");
        private Icon IconPacmenR = new Icon("right.ico");
        private Icon IconPacmenD = new Icon("down.ico");
        private Icon IconPacmenL = new Icon("left.ico");
        private Icon IconPacmenU = new Icon("up.ico");
        private Icon IconKey =  new Icon("key.ico");
        private Icon IconDollar = new Icon("dollar.ico");
        private Icon IconBlockTemp = new Icon("block temp.ico");
        private Icon IconBoom = new Icon("boom.ico");
        private Icon IconBoom2 = new Icon("boom2.ico");
        private System.Media.SoundPlayer SowndFoofing = new System.Media.SoundPlayer("a.wav");
        //declare timers
        private Timer PaintTimer = new Timer();
        private Timer GameStarter = new Timer() { Interval = 2000 };
        private Timer FooderTimer = new Timer() { Interval = 1000 };
        private Timer BoomerTimer = new Timer() { Interval = 3000 };
        private Timer t = new Timer() { Interval = 1000 };
        FrmPause Pauser = new FrmPause();
        int[] ChelkeyDirections = new int[2];
        Size SizeScreen;
        Brush BrushEnemy = Brushes.Black;
        Point boomb = new Point(0, 0);
        List<Point> p = new List<Point>();
        #endregion

        public FrmPacmen()
        {
            InitializeComponent();
            // Init timers
            PaintTimer.Tick += MovePlayer;
            GameStarter.Tick += GameStarter_Tick;
            FooderTimer.Tick += FooderTimer_Tick;
            BoomerTimer.Tick += Boom;
            t.Tick += t_Tick;
            // Init board
            Microsoft.VisualBasic.Devices.Computer com = new Microsoft.VisualBasic.Devices.Computer();
            SizeScreen = com.Screen.Bounds.Size;
            StartGame();
            Waiter.Location = new Point((SizeScreen.Width / 2) - (Waiter.Width / 2), (SizeScreen.Height / 2) - (Waiter.Height / 2));
        }

        void Boom(object sender, EventArgs e)
        {
            for (int i = boomb.X - 1; i < boomb.X + 2; i++)
                for (int y = boomb.Y - 1; y < boomb.Y + 2; y++)
                {
                    if (ListOfData1[i, y] == ImageToDraw.food)
                        foods--;
                    if (ListOfData1[i, y] == ImageToDraw.blockTemp || ListOfData1[i, y] == ImageToDraw.empty ||
                        ListOfData1[i, y] == ImageToDraw.dollar || ListOfData1[i, y] == ImageToDraw.enemy ||
                        ListOfData1[i, y] == ImageToDraw.food || ListOfData1[i, y] == ImageToDraw.fooded || ListOfData1[i, y] == ImageToDraw.key)
                    {
                        ListOfData1[i, y] = ImageToDraw.boom;
                        p.Add(new Point(i, y));
                    }
                }
            t.Start();
            BoomerTimer.Stop();
            boomb = new Point(0, 0);
        }

        void t_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < p.Count; i++)
                ListOfData1[p[i].X, p[i].Y] = ImageToDraw.empty;
            t.Stop();
        }

        private void FooderTimer_Tick(object sender, EventArgs e)
        {
            LblTime.Text = (int.Parse(LblTime.Text) - 1).ToString();
            LblTime.Visible = true;
            if (LblTime.Text == "0")
            {
                PicFooder.Visible = false;
                LblTime.Visible = false;
                FooderTimer.Stop();
                BrushEnemy = Brushes.Black;
            }
        }

        private void GameStarter_Tick(object sender, EventArgs e)
        {
            if (Waiter.Visible == true)
            {
                Waiter.Visible = false;
                pbCanvas.Visible = true;
            }
            else
            {
                GameStarter.Stop();
                PaintTimer.Start();
                this.Focus();
            }
        }

        private void StartGame()
        {
            ChelkeyDirections[0] = 4;
            ChelkeyDirections[1] = 4;
            BuildBoard();
            PaintTimer.Interval = 75;
            GameStarter.Start();
        }

        private void NextLevel()
        {
            PaintTimer.Stop();
            this.Focus();
            pbCanvas.Hide();
            PaintTimer.Interval -= 5;
            LblLevel.Text = (int.Parse(LblLevel.Text) + 1).ToString();
            enemy.Clear();
            ListOfData1 = new ImageToDraw[100, 100];
            BuildBoard();                                                               //reset all data
            GameStarter.Start();
            PicFooder.Visible = false;
            LblTime.Visible = false;
            FooderTimer.Stop();
            BrushEnemy = Brushes.Black;
            ChelkeyDirections[0] = 4;
            ChelkeyDirections[1] = 4;
            PicFooder.Visible = false;
            LblTime.Visible = false;
            MyPacmen.direction = Direction.Left;
            MyPacmen.DirectionWant = Direction.Left;
            MyPacmen.IconDirection = Direction.Left;
            Waiter.Visible = true;
        }

        private void DownLive()
        {
            if (lblLives.Text == "0")                                                   // GameOver
            {
                if (Settings.profiles[Settings.AP].PlaySound)
                    System.Media.SystemSounds.Exclamation.Play();
                EndGame();
            }
            else //The game continue
            {
                if (Settings.profiles[Settings.AP].PlaySound)
                    System.Media.SystemSounds.Beep.Play();
                PaintTimer.Stop();
                MessageBox.Show("לא נורא, נותרו לך עוד " + lblLives.Text + " פסילות");
                lblLives.Text = (int.Parse(lblLives.Text) - 1).ToString();
                MyPacmen.X = MyPacmen.OrginalX;
                MyPacmen.Y = MyPacmen.OrginalY;
                //Reset all enemys to settings orginals
                for (int i = 0; i < enemy.Count; i++)
                {
                    enemy[i].X = enemy[i].OrginalX;
                    enemy[i].Y = enemy[i].OrginalY;
                    enemy[i].ChelkeyX = 4;
                    enemy[i].ChelkeyY = 4;
                    enemy[i].Dead = false;
                }
                ChelkeyDirections[0] = 4;
                ChelkeyDirections[1] = 4;
                PaintTimer.Start();
            }
        }

        private void EndGame()
        {
            PaintTimer.Stop();                                                   //break timers
            GameStarter.Stop();
            FooderTimer.Stop();
            if (int.Parse(Settings.profiles[Settings.AP].HighLevel) < int.Parse(LblLevel.Text))
            {
                Settings.profiles[Settings.AP].HighLevel = LblLevel.Text;
                string[] lines = System.IO.File.ReadAllLines("Profiles.txt");
                lines[Settings.AP] = Settings.ReturnLine(Settings.AP);
                System.IO.File.WriteAllLines("Profiles.txt", lines);
            }
            for (int i = 0; i < 3; i++)
            {
                if (int.Parse(lblScore.Text) > int.Parse(Settings.profiles[Settings.AP].HighScore[i]))
                {
                    MessageBox.Show("!מזל טוב \nשברת שיא \nהשיא החדש שלך הוא: " + int.Parse(lblScore.Text));
                    {                                                                   //update file & profile
                        string[] lines = System.IO.File.ReadAllLines("Profiles.txt");
                        int y = 2;
                        while (y > i)
                        {
                            Settings.profiles[Settings.AP].HighScore[y] = Settings.profiles[Settings.AP].HighScore[y - 1];
                            y--;
                        }
                        Settings.profiles[Settings.AP].HighScore[i] = lblScore.Text;
                        lines[Settings.AP] = Settings.ReturnLine(Settings.AP);
                        System.IO.File.WriteAllLines("Profiles.txt", lines);
                    }
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("!המשחק נגמר \nהניקוד שלך הוא " + int.Parse(lblScore.Text) + "\nהשיא שלך הוא " +
            (Settings.profiles[Settings.AP].HighScore[2]));
            this.Close();
        }

        private void BuildBoard()
        {
            ListOfData1 = new ImageToDraw[100, 100];
            char[] chars = Properties.Resources.ResourceManager.GetString("level" + LblLevel.Text).ToCharArray();
            int r = 0, c = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case '1':                                           //load blocks
                        ListOfData1[c, r] = ImageToDraw.block;
                        c++;
                        break;
                    case '0':                                           // load foods
                        ListOfData1[c, r] = ImageToDraw.food;
                        foods++;
                        c++;
                        break;
                    case 'p':                                           // load pacmen
                        ListOfData1[c, r] = ImageToDraw.pacmen;
                        MyPacmen = new Pocimon { X = c, Y = r, OrginalX = c, OrginalY = r };
                        c++;
                        break;
                    case 'e':                                           // load enemys
                        enemy.Add(new Enemy { X = c, Y = r, OrginalX = c, OrginalY = r });
                        ListOfData1[c, r] = ImageToDraw.food;
                        foods++;
                        c++;
                        break;
                    case 't':
                        ListOfData1[c, r] = ImageToDraw.blockTemp;
                        c++;
                        break;
                    case '*':                                           // load fooders
                        ListOfData1[c, r] = ImageToDraw.reverser;
                        c++;
                        break;
                    case 'd':
                        ListOfData1[c, r] = ImageToDraw.dollar;
                        c++;
                        break;
                    case '\r':                                          // start new line
                        c = 0;
                        r++;
                        break;
                }
            }
            pbCanvas.Size = new Size { Height = (r+1 ) * 40, Width = (c ) * 40 };
            pbCanvas.Top = (SizeScreen.Height / 2) - (pbCanvas.Height / 2);
            pbCanvas.Left = (SizeScreen.Width / 2) - (pbCanvas.Width / 2);
            ImageToDraw[,] Temporary = new ImageToDraw [c + 1, r + 1];
            for (int x = 0; x < c; x++)
                for (int y = 0; y < r+1; y++)
                    Temporary[x, y] = ListOfData1[x,y];
            ListOfData1 = null;
            ListOfData1 = Temporary;
            for (int x = 0; x < c; x++)
                for (int y = 0; y < r+1; y++)
                    ListOfData1[x, y] = Temporary[x,y];
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (MyPacmen.direction != Direction.Right)
                        MyPacmen.DirectionWant = Direction.Right;
                    break;
                case Keys.Left:
                    if (MyPacmen.direction != Direction.Left)
                        MyPacmen.DirectionWant = Direction.Left;
                    break;
                case Keys.Up:
                    if (MyPacmen.direction != Direction.Up)
                        MyPacmen.DirectionWant = Direction.Up;
                    break;
                case Keys.Down:
                    if (MyPacmen.direction != Direction.Down)
                        MyPacmen.DirectionWant = Direction.Down;
                    break;
                case Keys.Space:
                    if (boomb.IsEmpty)
                    {
                        BoomerTimer.Start();
                        boomb = new Point(MyPacmen.X, MyPacmen.Y);
                    }
                    break;
                case Keys.Escape:                                          // pause mode
                    PaintTimer.Stop();
                    DialogResult res = Pauser.ShowDialog();
                    if (res == System.Windows.Forms.DialogResult.Cancel)
                        PaintTimer.Start();
                    else if (res == DialogResult.OK)
                        this.Close();
                    break;
            }
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            for (int X = 0; X < ListOfData1.GetUpperBound(0); X++)
            {
                for (int Y = 0; Y <= ListOfData1.GetUpperBound(1); Y++)
                {
                    switch (ListOfData1[X, Y])
                    {
                        case ImageToDraw.block:
                            canvas.DrawIcon(IconBlock, new Rectangle(X * 40, Y * 40, 40, 40));
                            break;
                        case ImageToDraw.food:
                            canvas.DrawIcon(IconStar, new Rectangle(X * 40 + 10, Y * 40 + 10, 20, 20));
                            break;
                        case ImageToDraw.reverser:
                            canvas.DrawIcon(Iconfooder, new Rectangle(X * 40 + 5, Y * 40 + 5, 30, 30));
                            break;
                        case ImageToDraw.key:
                            canvas.DrawIcon(IconKey, new Rectangle(X * 40 + 5, Y * 40 + 5, 30, 30));
                            break;
                        case ImageToDraw.dollar:
                            canvas.DrawIcon(IconDollar, new Rectangle(X * 40 + 5, Y * 40 + 5, 30, 30));
                            break;
                        case ImageToDraw.blockTemp:
                            canvas.DrawIcon(IconBlockTemp, new Rectangle(X * 40, Y * 40, 40, 40));
                            break;
                        case ImageToDraw.boom:
                            canvas.DrawIcon(IconBoom2, new Rectangle(X * 40 + 10, Y * 40 + 10, 20, 20));
                            break;
                    }
                }
            }
            switch (MyPacmen.IconDirection)
            {
                case Direction.Down:
                    canvas.DrawIcon(IconPacmenD, new Rectangle((MyPacmen.X * 40) + ((ChelkeyDirections[0] - 4) * 10), (MyPacmen.Y * 40) + ((ChelkeyDirections[1] - 4) * 10), 40, 40));
                    break;
                case Direction.Left:
                    canvas.DrawIcon(IconPacmenL, new Rectangle((MyPacmen.X * 40) + ((ChelkeyDirections[0] - 4) * 10), (MyPacmen.Y * 40) + ((ChelkeyDirections[1] - 4) * 10), 40, 40));
                    break;
                case Direction.Right:
                    canvas.DrawIcon(IconPacmenR, new Rectangle((MyPacmen.X * 40) + ((ChelkeyDirections[0] - 4) * 10), (MyPacmen.Y * 40) + ((ChelkeyDirections[1] - 4) * 10), 40, 40));
                    break;
                case Direction.Up:
                    canvas.DrawIcon(IconPacmenU, new Rectangle((MyPacmen.X * 40) + ((ChelkeyDirections[0] - 4) * 10), (MyPacmen.Y * 40) + ((ChelkeyDirections[1] - 4) * 10), 40, 40));
                    break;
            }
            for (int i = 0; i < enemy.Count; i++)
            {
                if (enemy[i] != null)
                    canvas.FillEllipse(BrushEnemy, new Rectangle
                        ((enemy[i].X * 40) + ((enemy[i].ChelkeyX - 4) * 10) + 5, (enemy[i].Y * 40) + ((enemy[i].ChelkeyY - 4) * 10) + 5, 30, 30));
            }
            if (!boomb.IsEmpty)                                                     //draw boomer
            {
                canvas.DrawIcon(IconBoom , new Rectangle((boomb.X  * 40)+5, (boomb.Y * 40)+5 , 30, 30));
            }

        }

        private void MovePlayer(object sender, EventArgs e)
        {
            pbCanvas.Top = (this.Size.Height / 2) - (pbCanvas.Height / 2);  //build board
            pbCanvas.Left = (this.Size.Width / 2) - (pbCanvas.Width / 2);
            if (MyPacmen.DirectionWant != null)                             //move pacmen
            {
                switch (MyPacmen.DirectionWant)
                {
                    case Direction.Right:
                        if (ListOfData1[MyPacmen.X + 1, MyPacmen.Y] != ImageToDraw.block && ChelkeyDirections[1] == 4
                            && ListOfData1[MyPacmen.X + 1, MyPacmen.Y] != ImageToDraw.blockTemp )
                        {
                            ChelkeyDirections[0]++;
                            MyPacmen.DirectionWant = null;
                            MyPacmen.direction = Direction.Right;
                            MyPacmen.IconDirection = Direction.Right;
                        }
                        else
                            GoToDirection();
                        break;
                    case Direction.Left:
                        if (ListOfData1[MyPacmen.X - 1, MyPacmen.Y] != ImageToDraw.block && ChelkeyDirections[1] == 4
                            && ListOfData1[MyPacmen.X - 1, MyPacmen.Y] != ImageToDraw.blockTemp )
                        {
                            MyPacmen.DirectionWant = null;
                            MyPacmen.direction = Direction.Left;
                            ChelkeyDirections[0]--;
                            MyPacmen.IconDirection = Direction.Left;
                        }
                        else
                            GoToDirection();
                        break;
                    case Direction.Up:
                        if (ListOfData1[MyPacmen.X, MyPacmen.Y - 1] != ImageToDraw.block && ChelkeyDirections[0] == 4
                            && ListOfData1[MyPacmen.X, MyPacmen.Y - 1] != ImageToDraw.blockTemp )
                        {
                            MyPacmen.DirectionWant = null;
                            MyPacmen.direction = Direction.Up;
                            ChelkeyDirections[1]--;
                            MyPacmen.IconDirection = Direction.Up;
                        }
                        else
                            GoToDirection();
                        break;
                    case Direction.Down:
                        if (ListOfData1[MyPacmen.X, MyPacmen.Y + 1] != ImageToDraw.block && ChelkeyDirections[0] == 4
                            && ListOfData1[MyPacmen.X, MyPacmen.Y + 1] != ImageToDraw.blockTemp )
                        {
                            MyPacmen.DirectionWant = null;
                            MyPacmen.direction = Direction.Down;
                            ChelkeyDirections[1]++;
                            MyPacmen.IconDirection = Direction.Down;
                        }
                        else
                            GoToDirection();
                        break;
                }
            }
            else
                GoToDirection();

            for (int i = 0; i < enemy.Count; i++)                                        //die A
            {
                if (enemy[i] != null && !enemy[i].Dead && MyPacmen.X == enemy[i].X && MyPacmen.Y == enemy[i].Y)
                {
                    if (PicFooder.Visible == false)
                    {
                        DownLive();
                        break;
                    }
                    else
                    {
                        if (Settings.profiles[Settings.AP].PlaySound)
                            SowndFoofing.Play();
                        enemy.RemoveAt(i);
                        lblScore.Text = (int.Parse(lblScore.Text) + 500).ToString();
                    }
                }
            }

            Random rand = new Random();                                                 //move enemys
            int ts;
            for (int i = 0; i < enemy.Count; i++)
            {
                if (enemy[i] != null && !enemy[i].Dead)
                {
                    switch (enemy[i].direction)
                    {
                        case Direction.Right:
                            if (ListOfData1[enemy[i].X + 1, enemy[i].Y] != ImageToDraw.block)
                                enemy[i].OptionalDirections.Add(Direction.Right);
                            if (ListOfData1[enemy[i].X, enemy[i].Y - 1] != ImageToDraw.block && enemy[i].ChelkeyX == 4)
                                enemy[i].OptionalDirections.Add(Direction.Up);
                            if (ListOfData1[enemy[i].X, enemy[i].Y + 1] != ImageToDraw.block && enemy[i].ChelkeyX == 4)
                                enemy[i].OptionalDirections.Add(Direction.Down);
                            ts = rand.Next(1, enemy[i].OptionalDirections.Count + 1);
                            enemy[i].direction = enemy[i].OptionalDirections[ts - 1];
                            break;
                        case Direction.Left:
                            if (ListOfData1[enemy[i].X - 1, enemy[i].Y] != ImageToDraw.block)
                                enemy[i].OptionalDirections.Add(Direction.Left);
                            if (ListOfData1[enemy[i].X, enemy[i].Y - 1] != ImageToDraw.block && enemy[i].ChelkeyX == 4)
                                enemy[i].OptionalDirections.Add(Direction.Up);
                            if (ListOfData1[enemy[i].X, enemy[i].Y + 1] != ImageToDraw.block && enemy[i].ChelkeyX == 4)
                                enemy[i].OptionalDirections.Add(Direction.Down);
                            ts = rand.Next(1, enemy[i].OptionalDirections.Count + 1);
                            enemy[i].direction = enemy[i].OptionalDirections[ts - 1];
                            break;
                        case Direction.Up:
                            if (ListOfData1[enemy[i].X - 1, enemy[i].Y] != ImageToDraw.block && enemy[i].ChelkeyY == 4)
                                enemy[i].OptionalDirections.Add(Direction.Left);
                            if (ListOfData1[enemy[i].X, enemy[i].Y - 1] != ImageToDraw.block && enemy[i].ChelkeyX == 4)
                                enemy[i].OptionalDirections.Add(Direction.Up);
                            if (ListOfData1[enemy[i].X + 1, enemy[i].Y] != ImageToDraw.block && enemy[i].ChelkeyY == 4)
                                enemy[i].OptionalDirections.Add(Direction.Right);
                            ts = rand.Next(1, enemy[i].OptionalDirections.Count + 1);
                            enemy[i].direction = enemy[i].OptionalDirections[ts - 1];
                            break;
                        case Direction.Down:
                            if (ListOfData1[enemy[i].X - 1, enemy[i].Y] != ImageToDraw.block && enemy[i].ChelkeyY == 4)
                                enemy[i].OptionalDirections.Add(Direction.Left);
                            if (ListOfData1[enemy[i].X + 1, enemy[i].Y] != ImageToDraw.block && enemy[i].ChelkeyY == 4)
                                enemy[i].OptionalDirections.Add(Direction.Right);
                            if (ListOfData1[enemy[i].X, enemy[i].Y + 1] != ImageToDraw.block && enemy[i].ChelkeyX == 4)
                                enemy[i].OptionalDirections.Add(Direction.Down);
                            ts = rand.Next(1, enemy[i].OptionalDirections.Count + 1);
                            enemy[i].direction = enemy[i].OptionalDirections[ts - 1];
                            break;
                    }

                    switch (enemy[i].direction)
                    {
                        case Direction.Right:
                            {
                                enemy[i].ChelkeyX++;
                                if (enemy[i].ChelkeyX == 8)
                                {
                                    enemy[i].X++;
                                    enemy[i].ChelkeyX = 4;
                                }
                            }
                            break;
                        case Direction.Left:
                            {
                                enemy[i].ChelkeyX--;
                                if (enemy[i].ChelkeyX == 0)
                                {
                                    enemy[i].X--;
                                    enemy[i].ChelkeyX = 4;
                                }
                            }
                            break;
                        case Direction.Up:
                            {
                                enemy[i].ChelkeyY--;
                                if (enemy[i].ChelkeyY == 0)
                                {
                                    enemy[i].Y--;
                                    enemy[i].ChelkeyY = 4;
                                }
                            }
                            break;
                        case Direction.Down:
                            {
                                enemy[i].ChelkeyY++;
                                if (enemy[i].ChelkeyY == 8)
                                {
                                    enemy[i].Y++;
                                    enemy[i].ChelkeyY = 4;
                                }
                            }
                            break;
                    }
                    ts = 0;
                    enemy[i].OptionalDirections.Clear();
                }
            }

            for (int i = 0; i < enemy.Count; i++)                                        //die B
            {
                if (enemy[i] != null && !enemy[i].Dead && MyPacmen.X == enemy[i].X && MyPacmen.Y == enemy[i].Y)
                {
                    if (PicFooder.Visible == false)
                    {
                        DownLive();
                        break;
                    }
                    else
                    {
                        if (Settings.profiles[Settings.AP].PlaySound)
                            SowndFoofing.Play();
                        enemy.RemoveAt(i);
                        lblScore.Text = (int.Parse(lblScore.Text) + 500).ToString();
                    }
                }
            }

            if (ListOfData1[MyPacmen.X, MyPacmen.Y] == ImageToDraw.food)                        //fooding food
            {
                ListOfData1[MyPacmen.X, MyPacmen.Y] = ImageToDraw.empty;
                lblScore.Text = (int.Parse(lblScore.Text) + 100).ToString();
                foods--;
                if (Int32.Parse(lblScore.Text) % 10000 == 0)
                    lblLives.Text = (Int32.Parse(lblLives.Text) + 1).ToString();
                if (foods == 0)
                {
                    Point r = GenerateRandomLocation();
                    ListOfData1[r.X,r.Y] = ImageToDraw.key;
                }
            }
            else if (ListOfData1[MyPacmen.X, MyPacmen.Y] == ImageToDraw.dollar)
            {
                ListOfData1[MyPacmen.X, MyPacmen.Y] = ImageToDraw.empty;
                lblScore.Text = (int.Parse(lblScore.Text) + 500).ToString();
                if ((Int32.Parse(lblScore.Text) % 10000) == 0)                       //To Repair: if score =9900 before foodinf, and after = 10400...
                    lblLives.Text = (Int32.Parse(lblLives.Text) + 1).ToString();
            }
            else if (ListOfData1[MyPacmen.X, MyPacmen.Y] == ImageToDraw.reverser)     // Fooding 'Killed'
            {
                ListOfData1[MyPacmen.X, MyPacmen.Y] = ImageToDraw.empty;
                if (Settings.profiles[Settings.AP].PlaySound)
                    SowndFoofing.Play();
                PicFooder.Visible = true;
                LblTime.Visible = true;
                LblTime.Text = "15";
                BrushEnemy = Brushes.SpringGreen;
                FooderTimer.Start();
            }
            else if (ListOfData1[MyPacmen.X, MyPacmen.Y] == ImageToDraw.key)           // Fooding keys -> end level
            {
                if (Settings.profiles[Settings.AP].PlaySound)
                    SowndFoofing.Play();
                if (LblLevel.Text == "3")
                    EndGame();
                else
                    NextLevel();
            }
            pbCanvas.Invalidate();
        }

        private Point GenerateRandomLocation()
        {
            List<Locaton>  LocationLegals = new List<Locaton>();
            for (int y = 0; y < ListOfData1.GetUpperBound(0); y++)
            {
                for (int z = 0; z < ListOfData1.GetUpperBound(1); z++)
                {
                    if (ListOfData1[y, z] == ImageToDraw.empty)
                        LocationLegals.Add(new Locaton { X = y, Y = z });
                }
            }
            Random rand2 = new Random();
            int i = rand2.Next(0, LocationLegals.Count);
            return new Point { X = LocationLegals[i].X, Y = LocationLegals[i].Y };
        }

        private void GoToDirection()
        {
            switch (MyPacmen.direction)
            {
                case Direction.Right:
                    if (ListOfData1[MyPacmen.X + 1, MyPacmen.Y] != ImageToDraw.block && ChelkeyDirections[1] == 4
                        && ListOfData1[MyPacmen.X + 1, MyPacmen.Y] != ImageToDraw.blockTemp)
                    {
                        ChelkeyDirections[0]++;
                        if (ChelkeyDirections[0] == 8)
                        {
                            MyPacmen.X++;
                            ChelkeyDirections[0] = 4;
                        }
                    }
                    break;

                case Direction.Left:
                    if (ListOfData1[MyPacmen.X - 1, MyPacmen.Y] != ImageToDraw.block && ChelkeyDirections[1] == 4 &&
                        ListOfData1[MyPacmen.X - 1, MyPacmen.Y] != ImageToDraw.blockTemp )
                    {
                        ChelkeyDirections[0]--;
                        if (ChelkeyDirections[0] == 0)
                        {
                            MyPacmen.X--;
                            ChelkeyDirections[0] = 4;
                        }
                    }
                    break;
                case Direction.Up:
                    if (ListOfData1[MyPacmen.X, MyPacmen.Y - 1] != ImageToDraw.block && ChelkeyDirections[0] == 4
                        && ListOfData1[MyPacmen.X, MyPacmen.Y - 1] != ImageToDraw.blockTemp )
                    {
                        ChelkeyDirections[1]--;
                        if (ChelkeyDirections[1] == 0)
                        {
                            MyPacmen.Y--;
                            ChelkeyDirections[1] = 4;
                        }
                    }
                    break;
                case Direction.Down:
                    {
                        if (ListOfData1[MyPacmen.X, MyPacmen.Y + 1] != ImageToDraw.block && ChelkeyDirections[0] == 4
                            && ListOfData1[MyPacmen.X, MyPacmen.Y + 1] != ImageToDraw.blockTemp )
                        {
                            ChelkeyDirections[1]++;
                            if (ChelkeyDirections[1] == 8)
                            {
                                MyPacmen.Y++;
                                ChelkeyDirections[1] = 4;
                            }
                        }
                        break;
                    }
            }
        }

        private void FrmPacmen_FormClosing(object sender, FormClosingEventArgs e)
        {
            PaintTimer.Tick -= MovePlayer;
            GameStarter.Tick -= GameStarter_Tick;
            FooderTimer.Tick -= FooderTimer_Tick;   
        }
    }
}
