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
    public partial class Characters : Form
    {
        Pen draw = new Pen(Color.RoyalBlue, 2);
        Pen erase = new Pen(Color.LightSkyBlue, 2);
        Pen clicked = new Pen(Color.MidnightBlue, 4);
        Pen unclicked = new Pen(Color.LightSkyBlue, 4);

        Rectangle[] highlight = new Rectangle[10];
        PictureBox[] character = new PictureBox[10];
        Label[] name = new Label[10];

        Rectangle cursor = new Rectangle();

        int to_erase = -1, selected = -1;
        bool check = false; // true if player checked one RadioButton

        
        public Characters()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;

            highlights_names();
            cursor.Size = this.Cursor.Size;
        }

        private void highlights_names()
        {
            int i = 0;
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {
                if (pb != next_button && pb != spacebar_img
                    && pb != mouse_img && pb != instructions_button)
                {
                    highlight[i].Size = new Size(190, 170);
                    highlight[i].Location = new Point(pb.Left - 15, pb.Top - 15);
                    // ^ corresponding rectangle for the picturbox
                    character[i] = pb;
                    // saves the picturebox in a vector

                    name[i] = new Label();
                    name[i].Location = new Point
                        (pb.Location.X + 80 - 39, pb.Location.Y + 140);
                    name[i].Size = new Size(78, 23);
                    name[i].Font = new Font("Segoe Print", 10, FontStyle.Regular);
                    name[i].Text = pb.Name;
                    name[i].TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(name[i]);

                    i++;
                }
            }
        }

        private void enable_next_button()
        {
            if (next_button.Enabled == false)
            {
                if (check == true && selected != -1)
                {
                    next_button.Enabled = true;
                    next_button.Image = Properties.Resources.button_next;
                }
            }
        }

        private void Character_MouseEnter(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            cursor.Location = this.PointToClient(MousePosition);

            for (int i = 0; i < 10; i++) // identifies the picturebox over which the mouse is
            {
                if (cursor.IntersectsWith(highlight[i]))
                {
                    if (i != selected)
                    {
                        g.DrawRectangle(draw, highlight[i]);
                        name[i].Font = new Font("Segoe Print", 10, FontStyle.Bold);
                        to_erase = i;
                        break;
                    }
                }
            }
        }

        private void Character_MouseLeave(object sender, EventArgs e)
        {
            if (selected != to_erase)
            {
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(erase, highlight[to_erase]);
                name[to_erase].Font = new Font("Segoe Print", 10, FontStyle.Regular);
            }
        }

        private void Character_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (selected != -1)
            {
                g.DrawRectangle(unclicked, highlight[selected]);
                character[selected].BorderStyle = BorderStyle.None;
                name[selected].ForeColor = Color.Black;
                // deselects something already selected
            }

            selected = to_erase;
            g.DrawRectangle(clicked, highlight[selected]);
            character[selected].BorderStyle = BorderStyle.Fixed3D;
            name[selected].ForeColor = Color.MidnightBlue;
            // selects the most recent

            enable_next_button();
        }

        private void SpacebarMouse_CheckedChanged(object sender, EventArgs e)
        {
            check = true;
            enable_next_button();
        }

        private void next_button_MouseEnter(object sender, EventArgs e)
        {
            next_button.Image = Properties.Resources.button_next_hover;
        }

        private void next_button_MouseLeave(object sender, EventArgs e)
        {
            next_button.Image = Properties.Resources.button_next;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game form = new Game(character[selected].Name, spacebar.Checked);
            form.Show();
        }

        private void instructions_button_MouseEnter(object sender, EventArgs e)
        {
            instructions_button.Image = Properties.Resources.button_instructions_hover;
        }

        private void instructions_button_MouseLeave(object sender, EventArgs e)
        {
            instructions_button.Image = Properties.Resources.button_instructions;
        }

        private void instructions_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.Instructions, "Instructions",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Characters_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
