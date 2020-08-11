using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyAdventure_
{
    public partial class Cover : Form
    {
        public Cover()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        private void start_button_MouseEnter(object sender, EventArgs e)
        {
            start_button.Image = Properties.Resources.button_startgame_hover;
        }

        private void start_button_MouseLeave(object sender, EventArgs e)
        {
            start_button.Image = Properties.Resources.button_startgame;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Characters form = new Characters();
            form.Show();
        }

        private void Cover_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
