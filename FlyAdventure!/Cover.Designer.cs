namespace FlyAdventure_
{
    partial class Cover
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
            this.info = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.start_button)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.info.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(847, 0);
            this.info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(325, 128);
            this.info.TabIndex = 4;
            this.info.Text = "LUCRARE DE ATESTAT\r\nProiect realizat de: Fitero Isabela Alexandra\r\nClasa XII F\r\nP" +
    "rofesor coordonator: Bolea Cristina\r\nC.N. \"Mihai Eminescu\" Oradea\r\nSesiunea Mai " +
    "2017";
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Transparent;
            this.start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_button.Image = global::FlyAdventure_.Properties.Resources.button_startgame;
            this.start_button.Location = new System.Drawing.Point(917, 577);
            this.start_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(245, 98);
            this.start_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start_button.TabIndex = 5;
            this.start_button.TabStop = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            this.start_button.MouseEnter += new System.EventHandler(this.start_button_MouseEnter);
            this.start_button.MouseLeave += new System.EventHandler(this.start_button_MouseLeave);
            // 
            // Cover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlyAdventure_.Properties.Resources.cover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyAdventure!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cover_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.start_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox start_button;
    }
}