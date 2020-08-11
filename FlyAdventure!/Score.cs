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

namespace FlyAdventure_
{
    public partial class Score : Form
    {
        public Score(int distance)
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            show_score(distance);
        }

        private void show_score(int distance)
        {
            if (distance > Convert.ToInt32(File.ReadAllText(@"Game Resources/highscore.txt")))
            {
                game_over.Text =
                    "Congratulations! \n New highscore: " + distance + " meters.";
                File.WriteAllText(@"Game Resources/highscore.txt", distance.ToString());
            }
            else
            {
                game_over.Text = "You've flied for a total of " + distance + " meters. \n Good job!";
            }
        }

        private void play_again_MouseEnter(object sender, EventArgs e)
        {
            play_again.Image = Properties.Resources.button_playagain_hover;
        }

        private void play_again_MouseLeave(object sender, EventArgs e)
        {
            play_again.Image = Properties.Resources.button_playagain;
        }

        private void play_again_Click(object sender, EventArgs e)
        {
            Characters form = new Characters();
            form.Show();
            this.Hide();
        }

        private void exit_game_MouseEnter(object sender, EventArgs e)
        {
            exit_game.Image = Properties.Resources.button_exit_hover;
        }

        private void exit_game_MouseLeave(object sender, EventArgs e)
        {
            exit_game.Image = Properties.Resources.button_exit;
        }

        private void exit_game_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Score_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
