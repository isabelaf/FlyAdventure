namespace FlyAdventure_
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.multitask = new System.Windows.Forms.Timer(this.components);
            this.play_button = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.distance = new System.Windows.Forms.Timer(this.components);
            this.meters_number = new System.Windows.Forms.Label();
            this.meters_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.play_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // multitask
            // 
            this.multitask.Interval = 1;
            this.multitask.Tick += new System.EventHandler(this.multitask_Tick);
            // 
            // play_button
            // 
            this.play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_button.Image = global::FlyAdventure_.Properties.Resources.button_letsfly;
            this.play_button.Location = new System.Drawing.Point(358, 260);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(184, 80);
            this.play_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play_button.TabIndex = 0;
            this.play_button.TabStop = false;
            this.play_button.Click += new System.EventHandler(this.start_button_Click);
            this.play_button.MouseEnter += new System.EventHandler(this.play_button_MouseEnter);
            this.play_button.MouseLeave += new System.EventHandler(this.play_button_MouseLeave);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Location = new System.Drawing.Point(98, 111);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(60, 60);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // distance
            // 
            this.distance.Interval = 500;
            this.distance.Tick += new System.EventHandler(this.distance_Tick);
            // 
            // meters_number
            // 
            this.meters_number.AutoSize = true;
            this.meters_number.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meters_number.Location = new System.Drawing.Point(425, 0);
            this.meters_number.Name = "meters_number";
            this.meters_number.Size = new System.Drawing.Size(20, 23);
            this.meters_number.TabIndex = 2;
            this.meters_number.Text = "0";
            // 
            // meters_text
            // 
            this.meters_text.AutoSize = true;
            this.meters_text.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meters_text.Location = new System.Drawing.Point(448, 0);
            this.meters_text.Name = "meters_text";
            this.meters_text.Size = new System.Drawing.Size(56, 23);
            this.meters_text.TabIndex = 3;
            this.meters_text.Text = "meters";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.meters_text);
            this.Controls.Add(this.meters_number);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyAdventure!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.play_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer multitask;
        private System.Windows.Forms.PictureBox play_button;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer distance;
        private System.Windows.Forms.Label meters_number;
        private System.Windows.Forms.Label meters_text;
    }
}