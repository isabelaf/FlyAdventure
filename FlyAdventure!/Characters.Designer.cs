namespace FlyAdventure_
{
    partial class Characters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Characters));
            this.instruction_1 = new System.Windows.Forms.Label();
            this.instruction_2 = new System.Windows.Forms.Label();
            this.spacebar = new System.Windows.Forms.RadioButton();
            this.mouse = new System.Windows.Forms.RadioButton();
            this.instructions_button = new System.Windows.Forms.PictureBox();
            this.mouse_img = new System.Windows.Forms.PictureBox();
            this.spacebar_img = new System.Windows.Forms.PictureBox();
            this.next_button = new System.Windows.Forms.PictureBox();
            this.Witch = new System.Windows.Forms.PictureBox();
            this.Unicorn = new System.Windows.Forms.PictureBox();
            this.Toothless = new System.Windows.Forms.PictureBox();
            this.Tinkerbell = new System.Windows.Forms.PictureBox();
            this.Skydiver = new System.Windows.Forms.PictureBox();
            this.Pegasus = new System.Windows.Forms.PictureBox();
            this.Hawk = new System.Windows.Forms.PictureBox();
            this.Dragon = new System.Windows.Forms.PictureBox();
            this.Bat = new System.Windows.Forms.PictureBox();
            this.Aang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.instructions_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacebar_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Witch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unicorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toothless)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tinkerbell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skydiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pegasus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hawk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aang)).BeginInit();
            this.SuspendLayout();
            // 
            // instruction_1
            // 
            this.instruction_1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_1.Location = new System.Drawing.Point(12, 9);
            this.instruction_1.Name = "instruction_1";
            this.instruction_1.Size = new System.Drawing.Size(226, 28);
            this.instruction_1.TabIndex = 16;
            this.instruction_1.Text = "Select the character you want:";
            // 
            // instruction_2
            // 
            this.instruction_2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_2.Location = new System.Drawing.Point(12, 37);
            this.instruction_2.Name = "instruction_2";
            this.instruction_2.Size = new System.Drawing.Size(226, 47);
            this.instruction_2.TabIndex = 11;
            this.instruction_2.Text = "Choose wisely - fly using the spacebar / fly using the mouse:\r\n";
            // 
            // spacebar
            // 
            this.spacebar.AutoSize = true;
            this.spacebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spacebar.Location = new System.Drawing.Point(16, 97);
            this.spacebar.Name = "spacebar";
            this.spacebar.Size = new System.Drawing.Size(14, 13);
            this.spacebar.TabIndex = 12;
            this.spacebar.UseVisualStyleBackColor = true;
            this.spacebar.CheckedChanged += new System.EventHandler(this.SpacebarMouse_CheckedChanged);
            // 
            // mouse
            // 
            this.mouse.AutoSize = true;
            this.mouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mouse.Location = new System.Drawing.Point(16, 138);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(14, 13);
            this.mouse.TabIndex = 13;
            this.mouse.UseVisualStyleBackColor = true;
            this.mouse.CheckedChanged += new System.EventHandler(this.SpacebarMouse_CheckedChanged);
            // 
            // instructions_button
            // 
            this.instructions_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instructions_button.Image = global::FlyAdventure_.Properties.Resources.button_instructions;
            this.instructions_button.Location = new System.Drawing.Point(688, 383);
            this.instructions_button.Name = "instructions_button";
            this.instructions_button.Size = new System.Drawing.Size(184, 80);
            this.instructions_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.instructions_button.TabIndex = 17;
            this.instructions_button.TabStop = false;
            this.instructions_button.Click += new System.EventHandler(this.instructions_button_Click);
            this.instructions_button.MouseEnter += new System.EventHandler(this.instructions_button_MouseEnter);
            this.instructions_button.MouseLeave += new System.EventHandler(this.instructions_button_MouseLeave);
            // 
            // mouse_img
            // 
            this.mouse_img.Image = ((System.Drawing.Image)(resources.GetObject("mouse_img.Image")));
            this.mouse_img.Location = new System.Drawing.Point(52, 138);
            this.mouse_img.Name = "mouse_img";
            this.mouse_img.Size = new System.Drawing.Size(34, 54);
            this.mouse_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mouse_img.TabIndex = 15;
            this.mouse_img.TabStop = false;
            // 
            // spacebar_img
            // 
            this.spacebar_img.Image = ((System.Drawing.Image)(resources.GetObject("spacebar_img.Image")));
            this.spacebar_img.Location = new System.Drawing.Point(52, 97);
            this.spacebar_img.Name = "spacebar_img";
            this.spacebar_img.Size = new System.Drawing.Size(94, 35);
            this.spacebar_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spacebar_img.TabIndex = 14;
            this.spacebar_img.TabStop = false;
            // 
            // next_button
            // 
            this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button.Enabled = false;
            this.next_button.Image = global::FlyAdventure_.Properties.Resources.button_next_disabled;
            this.next_button.Location = new System.Drawing.Point(688, 469);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(184, 80);
            this.next_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.next_button.TabIndex = 10;
            this.next_button.TabStop = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            this.next_button.MouseEnter += new System.EventHandler(this.next_button_MouseEnter);
            this.next_button.MouseLeave += new System.EventHandler(this.next_button_MouseLeave);
            // 
            // Witch
            // 
            this.Witch.BackColor = System.Drawing.Color.Transparent;
            this.Witch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Witch.Image = ((System.Drawing.Image)(resources.GetObject("Witch.Image")));
            this.Witch.Location = new System.Drawing.Point(264, 395);
            this.Witch.Name = "Witch";
            this.Witch.Size = new System.Drawing.Size(160, 140);
            this.Witch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Witch.TabIndex = 9;
            this.Witch.TabStop = false;
            this.Witch.Click += new System.EventHandler(this.Character_Click);
            this.Witch.MouseEnter += new System.EventHandler(this.Character_MouseEnter);
            this.Witch.MouseLeave += new System.EventHandler(this.Character_MouseLeave);
            // 
            // Unicorn
            // 
            this.Unicorn.BackColor = System.Drawing.Color.Transparent;
            this.Unicorn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Unicorn.Image = ((System.Drawing.Image)(resources.GetObject("Unicorn.Image")));
            this.Unicorn.Location = new System.Drawing.Point(476, 30);
            this.Unicorn.Name = "Unicorn";
            this.Unicorn.Size = new System.Drawing.Size(160, 140);
            this.Unicorn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Unicorn.TabIndex = 8;
            this.Unicorn.TabStop = false;
            this.Unicorn.Click += new System.EventHandler(this.Character_Click);
            this.Unicorn.MouseEnter += new System.EventHandler(this.Character_MouseEnter);
            this.Unicorn.MouseLeave += new System.EventHandler(this.Character_MouseLeave);
            // 
            // Toothless
            // 
            this.Toothless.BackColor = System.Drawing.Color.Transparent;
            this.Toothless.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Toothless.Image = ((System.Drawing.Image)(resources.GetObject("Toothless.Image")));
            this.Toothless.Location = new System.Drawing.Point(476, 395);
            this.Toothless.Name = "Toothless";
            this.Toothless.Size = new System.Drawing.Size(160, 140);
            this.Toothless.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Toothless.TabIndex = 7;
            this.Toothless.TabStop = false;
            this.Toothless.Click += new System.EventHandler(this.Character_Click);
            this.Toothless.MouseEnter += new System.EventHandler(this.Character_MouseEnter);
            this.Toothless.MouseLeave += new System.EventHandler(this.Character_MouseLeave);
            // 
            // Tinkerbell
            // 
            this.Tinkerbell.BackColor = System.Drawing.Color.Transparent;
            this.Tinkerbell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tinkerbell.Image = ((System.Drawing.Image)(resources.GetObject("Tinkerbell.Image")));
            this.Tinkerbell.Location = new System.Drawing.Point(476, 210);
            this.Tinkerbell.Name = "Tinkerbell";
            this.Tinkerbell.Size = new System.Drawing.Size(160, 140);
            this.Tinkerbell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tinkerbell.TabIndex = 6;
            this.Tinkerbell.TabStop = false;
            this.Tinkerbell.Click += new System.EventHandler(this.Character_Click);
            this.Tinkerbell.MouseEnter += new System.EventHandler(this.Character_MouseEnter);
            this.Tinkerbell.MouseLeave += new System.EventHandler(this.Character_MouseLeave);
            // 
            // Skydiver
            // 
            this.Skydiver.BackColor = System.Drawing.Color.Transparent;
            this.Skydiver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Skydiver.Image = global::FlyAdventure_.Properties.Resources.Skydiver;
            this.Skydiver.Location = new System.Drawing.Point(52, 395);
            this.Skydiver.Name = "Skydiver";
            this.Skydiver.Size = new System.Drawing.Size(160, 140);
            this.Skydiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Skydiver.TabIndex = 5;
            this.Skydiver.TabStop = false;
            this.Skydiver.Click += new System.EventHandler(this.Character_Click);
            this.Skydiver.MouseEnter += new System.EventHandler(this.Character_MouseEnter);
            this.Skydiver.MouseLeave += new System.EventHandler(this.Character_MouseLeave);
            // 
            // Pegasus
            // 
            this.Pegasus.BackColor = System.Drawing.Color.Transparent;
            this.Pegasus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pegasus.Image = ((System.Drawing.Image)(resources.GetObject("Pegasus.Image")));
            this.Pegasus.Location = new System.Drawing.Point(688, 210);
            this.Pegasus.Name = "Pegasus";
            this.Pegasus.Size = new System.Drawing.Size(160, 140);
            this.Pegasus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pegasus.TabIndex = 4;
            this.Pegasus.TabStop = false;
            this.Pegasus.Click += new System.EventHandler(this.Character_Click);
            this.Pegasus.MouseEnter += new System.EventHandler(this.Character_MouseEnter);
            this.Pegasus.MouseLeave += new System.EventHandler(this.Character_MouseLeave);
            // 
            // Hawk
            // 
            this.Hawk.BackColor = System.Drawing.Color.Transparent;
            this.Hawk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hawk.Image = ((System.Drawing.Image)(resources.GetObject("Hawk.Image")));
            this.Hawk.Location = new System.Drawing.Point(688, 30);
            this.Hawk.Name = "Hawk";
            this.Hawk.Size = new System.Drawing.Size(160, 140);
            this.Hawk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hawk.TabIndex = 3;
            this.Hawk.TabStop = false;
            this.Hawk.Click += new System.EventHandler(this.Character_Click);
            this.Hawk.MouseEnter += new System.EventHandler(this.Character_MouseEnter);
            this.Hawk.MouseLeave += new System.EventHandler(this.Character_MouseLeave);
            // 
            // Dragon
            // 
            this.Dragon.BackColor = System.Drawing.Color.Transparent;
            this.Dragon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dragon.Image = ((System.Drawing.Image)(resources.GetObject("Dragon.Image")));
            this.Dragon.Location = new System.Drawing.Point(264, 30);
            this.Dragon.Name = "Dragon";
            this.Dragon.Size = new System.Drawing.Size(160, 140);
            this.Dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dragon.TabIndex = 2;
            this.Dragon.TabStop = false;
            this.Dragon.Click += new System.EventHandler(this.Character_Click);
            this.Dragon.MouseEnter += new System.EventHandler(this.Character_MouseEnter);
            this.Dragon.MouseLeave += new System.EventHandler(this.Character_MouseLeave);
            // 
            // Bat
            // 
            this.Bat.BackColor = System.Drawing.Color.Transparent;
            this.Bat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bat.Image = ((System.Drawing.Image)(resources.GetObject("Bat.Image")));
            this.Bat.Location = new System.Drawing.Point(52, 210);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(160, 140);
            this.Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bat.TabIndex = 1;
            this.Bat.TabStop = false;
            this.Bat.Click += new System.EventHandler(this.Character_Click);
            this.Bat.MouseEnter += new System.EventHandler(this.Character_MouseEnter);
            this.Bat.MouseLeave += new System.EventHandler(this.Character_MouseLeave);
            // 
            // Aang
            // 
            this.Aang.BackColor = System.Drawing.Color.Transparent;
            this.Aang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aang.Image = ((System.Drawing.Image)(resources.GetObject("Aang.Image")));
            this.Aang.Location = new System.Drawing.Point(264, 210);
            this.Aang.Name = "Aang";
            this.Aang.Size = new System.Drawing.Size(160, 140);
            this.Aang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Aang.TabIndex = 0;
            this.Aang.TabStop = false;
            this.Aang.Click += new System.EventHandler(this.Character_Click);
            this.Aang.MouseEnter += new System.EventHandler(this.Character_MouseEnter);
            this.Aang.MouseLeave += new System.EventHandler(this.Character_MouseLeave);
            // 
            // Characters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.instructions_button);
            this.Controls.Add(this.instruction_1);
            this.Controls.Add(this.mouse_img);
            this.Controls.Add(this.spacebar_img);
            this.Controls.Add(this.mouse);
            this.Controls.Add(this.spacebar);
            this.Controls.Add(this.instruction_2);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.Witch);
            this.Controls.Add(this.Unicorn);
            this.Controls.Add(this.Toothless);
            this.Controls.Add(this.Tinkerbell);
            this.Controls.Add(this.Skydiver);
            this.Controls.Add(this.Pegasus);
            this.Controls.Add(this.Hawk);
            this.Controls.Add(this.Dragon);
            this.Controls.Add(this.Bat);
            this.Controls.Add(this.Aang);
            this.DoubleBuffered = true;
            this.Name = "Characters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyAdventure!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Characters_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.instructions_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spacebar_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Witch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unicorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toothless)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tinkerbell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skydiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pegasus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hawk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Aang;
        private System.Windows.Forms.PictureBox Bat;
        private System.Windows.Forms.PictureBox Dragon;
        private System.Windows.Forms.PictureBox Hawk;
        private System.Windows.Forms.PictureBox Pegasus;
        private System.Windows.Forms.PictureBox Skydiver;
        private System.Windows.Forms.PictureBox Tinkerbell;
        private System.Windows.Forms.PictureBox Toothless;
        private System.Windows.Forms.PictureBox Unicorn;
        private System.Windows.Forms.PictureBox Witch;
        private System.Windows.Forms.PictureBox next_button;
        private System.Windows.Forms.Label instruction_1;
        private System.Windows.Forms.PictureBox instructions_button;
        private System.Windows.Forms.Label instruction_2;
        private System.Windows.Forms.RadioButton spacebar;
        private System.Windows.Forms.RadioButton mouse;
        private System.Windows.Forms.PictureBox spacebar_img;
        private System.Windows.Forms.PictureBox mouse_img;
    }
}