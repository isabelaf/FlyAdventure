namespace FlyAdventure_
{
    partial class Score
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
            this.play_again = new System.Windows.Forms.PictureBox();
            this.exit_game = new System.Windows.Forms.PictureBox();
            this.game_over = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.play_again)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_game)).BeginInit();
            this.SuspendLayout();
            // 
            // play_again
            // 
            this.play_again.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_again.Image = global::FlyAdventure_.Properties.Resources.button_playagain;
            this.play_again.Location = new System.Drawing.Point(12, 87);
            this.play_again.Name = "play_again";
            this.play_again.Size = new System.Drawing.Size(184, 80);
            this.play_again.TabIndex = 0;
            this.play_again.TabStop = false;
            this.play_again.Click += new System.EventHandler(this.play_again_Click);
            this.play_again.MouseEnter += new System.EventHandler(this.play_again_MouseEnter);
            this.play_again.MouseLeave += new System.EventHandler(this.play_again_MouseLeave);
            // 
            // exit_game
            // 
            this.exit_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_game.Image = global::FlyAdventure_.Properties.Resources.button_exit;
            this.exit_game.Location = new System.Drawing.Point(202, 87);
            this.exit_game.Name = "exit_game";
            this.exit_game.Size = new System.Drawing.Size(184, 80);
            this.exit_game.TabIndex = 1;
            this.exit_game.TabStop = false;
            this.exit_game.Click += new System.EventHandler(this.exit_game_Click);
            this.exit_game.MouseEnter += new System.EventHandler(this.exit_game_MouseEnter);
            this.exit_game.MouseLeave += new System.EventHandler(this.exit_game_MouseLeave);
            // 
            // game_over
            // 
            this.game_over.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_over.Location = new System.Drawing.Point(12, 9);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(374, 61);
            this.game_over.TabIndex = 2;
            this.game_over.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(398, 179);
            this.Controls.Add(this.game_over);
            this.Controls.Add(this.exit_game);
            this.Controls.Add(this.play_again);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Score_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.play_again)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_game)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox play_again;
        private System.Windows.Forms.PictureBox exit_game;
        private System.Windows.Forms.Label game_over;
    }
}