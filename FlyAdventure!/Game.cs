using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;

namespace FlyAdventure_
{
    public partial class Game : Form
    {

        Random rnd = new Random();
        PictureBox lastbuilt;
        bool spacebar = false;
        int step = 3;
        int background, change_background; // current background (1-city, 2-forest),
                                           // distance after which the background changes
        int meters = 0;

        public Game(string name, bool spacebar)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;

            player_image(name);
            this.spacebar = spacebar;
        }

        private void player_image(string name)
        {
            if (name == "Skydiver")
                player.Image = Image.FromFile(@"Game Resources/Players/" + name + ".png");
            else player.Image = Image.FromFile(@"Game Resources/Players/" + name + ".gif");
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DarkSlateGray, 0, 500, 900, 100); // road
        }

        private PictureBox createPictureBox(Size size, Point point, Color color)
        {
            PictureBox pb = new PictureBox();
            pb.Size = size;
            pb.Location = point;
            pb.BackColor = color;
            return pb;
        }

        private void BuildForest()
        {
            int treeNr = rnd.Next(1, 1024) % 6 + 1; // tree image index
            int treeH = rnd.Next(150, 350); // random height
            int treeW = 0;

            // calculates the width according to the height and the images size ratio
            if (treeNr == 1)
            {
                treeW = 77 * treeH / 100;
            }
            if (treeNr == 2)
            {
                treeW = 92 * treeH / 100;
            }
            if (treeNr == 3)
            {
                treeW = 91 * treeH / 100;
            }
            if (treeNr == 4)
            {
                treeW = 116 * treeH / 100;
            }
            if (treeNr == 5)
            {
                treeW = 216 * treeH / 100;
            }
            if (treeNr == 6)
            {
                treeW = 146 * treeH / 100;
            }

            PictureBox tree = createPictureBox(
                new Size(treeW, treeH),
                new Point(899 + rnd.Next(0, 50), 530 - treeH),
                Color.Transparent);
            tree.Image = Image.FromFile(@"Game Resources/Forest/tree_" + treeNr + ".bmp");
            tree.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(tree);
            lastbuilt = tree;
        }

        private void BuildBuilding() //PictureBox BuildBuilding()
        {
            Size size = new Size(rnd.Next(96, 768), rnd.Next(120, 350));
            // size adjustments for windows
            if (size.Width%96>60)
            {
                size.Width = (size.Width / 96) * 96 + 60;
            }
            else if (size.Width%96<36)
            {
                size.Width = (size.Width / 96) * 96 + 12;
            }
            if (size.Height%120>75)
            {
                size.Height = (size.Height / 120) * 120 + 75;
            }
            else if (size.Height%120<45)
            {
                size.Height = (size.Height / 120) * 120 + 15;
            }
            //

            PictureBox building = createPictureBox(
                size,
                new Point(899 + rnd.Next(0, 150), 500 - size.Height), // space between buildings of max. 150 px
                Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
            //building.BackgroundImage = Properties.Resources.building_background;
            building.BackgroundImage = Properties.Resources.windows;
            building.BackgroundImageLayout = ImageLayout.Tile;
            this.Controls.Add(building);
            lastbuilt = building;
            //return building;
        }

        /*void PutWindows(PictureBox building)
        {
            int NrW, NrH, LeftSpaceW, LeftSpaceH,
                SpaceBetweenW = 0, SpaceBetweenH = 0;
            NrW = building.Width / 96;
            if (building.Width % 96 != 0)
            {
                LeftSpaceW = building.Width - NrW * 96;
                SpaceBetweenW = LeftSpaceW / (NrW + 1);
            }
            NrH = building.Height / 120;
            if (building.Height % 120 != 0)
            {
                LeftSpaceH = building.Height - NrH * 120;
                SpaceBetweenH = LeftSpaceH / (NrH + 1);
            }
            for (int i = 1; i <= NrH; i++)
            {
                for (int j = 1; j <= NrW; j++)
                {
                    PictureBox window = createPictureBox(
                        new Size(96, 120),
                        new Point(building.Location.X + (j - 1) * 96,
                            building.Location.Y + (i - 1) * 120),
                        building.BackColor);
                    if (building.Width % 96 != 0)
                    {
                        window.Left += j * SpaceBetweenW;
                    }
                    if (building.Height % 120 != 0)
                    {
                        window.Top += i * SpaceBetweenH;
                    }
                    window.Image = Properties.Resources.windows;
                    window.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(window);
                    window.BringToFront();
                }
            }
        }*/

        private void BuildCity()
        {
            //PutWindows(BuildBuilding());
            BuildBuilding();
        }

        private void CreateObstacle()
        {
            if (lastbuilt.Height <= 305) // obstacles are created only over buildings/trees with height <= 305
            {
                int NrObs =
                    (rnd.Next(0, Math.Max(
                    (lastbuilt.Top - 180) / 35, lastbuilt.Width / 35))) / 2;
                PictureBox[] obstacles = new PictureBox[NrObs+1];
                // random number of obstacles
                for (int i = 0; i < NrObs; i++)
                {
                    obstacles[i] = createPictureBox(
                        new Size(35, 35),
                        new Point(rnd.Next(lastbuilt.Left, lastbuilt.Right - 35),
                        rnd.Next(80, lastbuilt.Top - 115)),
                        Color.Transparent);
                    if (i==0)
                    {
                        this.Controls.Add(obstacles[i]);
                        obstacles[i].Image = Image.FromFile(
                            @"Game Resources/Obstacles/obstacle_" + ((rnd.Next(1, 1024) % 8 + 1)) + ".bmp");
                    }
                    else // checks if it doesn't intersect with the other obstacles
                    {
                        bool intersection = false;
                        for (int j = 0; j < i; j++)
                        {
                            if (obstacles[i].Bounds.IntersectsWith(obstacles[j].Bounds))
                            { intersection = true; break; }
                        }
                        if (intersection==false)
                        {
                            this.Controls.Add(obstacles[i]);
                            obstacles[i].Image = Image.FromFile(
                                @"Game Resources/Obstacles/obstacle_" + ((rnd.Next(1, 1024) % 8 + 1)) + ".bmp");
                        }
                    }
                }
            }
        }

        private void StartGame()
        {
            play_button.Visible = false;

            multitask.Enabled = true;
            distance.Enabled = true;

            if (spacebar == false)
            {
                Cursor.Position = PointToScreen(player.Location);
            }
            Cursor.Hide();

            background = rnd.Next(1, 1024) % 2 + 1;
            change_background = rnd.Next(10, 30); // background lasts between 10-30 m / 5 - 15 s
        }

        private void StopGame()
        {
            multitask.Enabled = false;
            distance.Enabled = false;

            Cursor.Show();

            Score form = new Score(meters);
            form.ShowDialog();
            this.Hide();
        }

        private void Move_Collision()
        {
            if (spacebar)
            {
                player.Top += step;
            }
            else
            {
                player.Location = PointToClient(MousePosition);
            }

            if (player.Top < -1 || player.Bottom > 501 || player.Left < -1
                || player.Right > 901) // if the player gets out of the form
                StopGame();

            Rectangle collision = new Rectangle
                (player.Location.X+10, player.Location.Y+10,
                player.Width-20, player.Height-20);

            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {
                if (pb != play_button && pb != player)
                {
                    pb.Left -= 2; // move
                    if (pb.Right <= 0) // remove if it goes out of the form
                        this.Controls.Remove(pb);
                    if (pb.Bounds.IntersectsWith(collision)) // checks for collsion
                        StopGame();
                }
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (spacebar)
            {
                if (e.KeyCode == Keys.Space)
                    step = 3;
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (spacebar)
            {
                if (e.KeyCode == Keys.Space)
                    step = -3;
            }
        }

        private void play_button_MouseEnter(object sender, EventArgs e)
        {
            play_button.Image = Properties.Resources.button_letsfly_hover;
        }

        private void play_button_MouseLeave(object sender, EventArgs e)
        {
            play_button.Image = Properties.Resources.button_letsfly;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void multitask_Tick(object sender, EventArgs e)
        {
            if (lastbuilt == null || lastbuilt.Right < 900)
            {
                if (background == 1)
                    BuildCity();
                else BuildForest();

                CreateObstacle();
            }
            Move_Collision();
        }

        private void distance_Tick(object sender, EventArgs e)
        {
            meters++;
            meters_number.Text = meters.ToString(); // increases distance

            if (meters_number.Right > meters_text.Left)
                meters_text.Left = meters_number.Right;

            if (meters == change_background) // time to change background
            {
                if (background == 1)
                    background = 2;
                else background = 1;

                change_background = change_background + rnd.Next(10, 30);
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
