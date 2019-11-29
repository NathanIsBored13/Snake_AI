namespace Snake_AI
{
    partial class Snake_Window
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
            this.Game_Bord = new System.Windows.Forms.PictureBox();
            this.Static1 = new System.Windows.Forms.Label();
            this.Score_Display = new System.Windows.Forms.Label();
            this.Static2 = new System.Windows.Forms.Label();
            this.Ticks_Display = new System.Windows.Forms.Label();
            this.Static3 = new System.Windows.Forms.Label();
            this.Generic_Display = new System.Windows.Forms.Label();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Bord)).BeginInit();
            this.SuspendLayout();
            // 
            // Game_Bord
            // 
            this.Game_Bord.BackColor = System.Drawing.SystemColors.GrayText;
            this.Game_Bord.Location = new System.Drawing.Point(12, 12);
            this.Game_Bord.Name = "Game_Bord";
            this.Game_Bord.Size = new System.Drawing.Size(426, 426);
            this.Game_Bord.TabIndex = 0;
            this.Game_Bord.TabStop = false;
            // 
            // Static1
            // 
            this.Static1.AutoSize = true;
            this.Static1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Static1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Static1.Location = new System.Drawing.Point(444, 12);
            this.Static1.Name = "Static1";
            this.Static1.Size = new System.Drawing.Size(75, 26);
            this.Static1.TabIndex = 1;
            this.Static1.Text = "Score:";
            // 
            // Score_Display
            // 
            this.Score_Display.AutoSize = true;
            this.Score_Display.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Score_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Score_Display.Location = new System.Drawing.Point(525, 12);
            this.Score_Display.Name = "Score_Display";
            this.Score_Display.Size = new System.Drawing.Size(48, 26);
            this.Score_Display.TabIndex = 2;
            this.Score_Display.Text = "000";
            // 
            // Static2
            // 
            this.Static2.AutoSize = true;
            this.Static2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Static2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Static2.Location = new System.Drawing.Point(444, 38);
            this.Static2.Name = "Static2";
            this.Static2.Size = new System.Drawing.Size(68, 26);
            this.Static2.TabIndex = 3;
            this.Static2.Text = "Ticks:";
            // 
            // Ticks_Display
            // 
            this.Ticks_Display.AutoSize = true;
            this.Ticks_Display.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ticks_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Ticks_Display.Location = new System.Drawing.Point(525, 38);
            this.Ticks_Display.Name = "Ticks_Display";
            this.Ticks_Display.Size = new System.Drawing.Size(48, 26);
            this.Ticks_Display.TabIndex = 4;
            this.Ticks_Display.Text = "000";
            // 
            // Static3
            // 
            this.Static3.AutoSize = true;
            this.Static3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Static3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Static3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Static3.Location = new System.Drawing.Point(447, 64);
            this.Static3.Name = "Static3";
            this.Static3.Size = new System.Drawing.Size(72, 52);
            this.Static3.TabIndex = 5;
            this.Static3.Text = "Window Size:\r\nTick Speed:\r\nBlocks Free:\r\nAI State:";
            // 
            // Generic_Display
            // 
            this.Generic_Display.AutoSize = true;
            this.Generic_Display.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Generic_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Generic_Display.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Generic_Display.Location = new System.Drawing.Point(525, 64);
            this.Generic_Display.Name = "Generic_Display";
            this.Generic_Display.Size = new System.Drawing.Size(49, 52);
            this.Generic_Display.TabIndex = 6;
            this.Generic_Display.Text = "000, 000\r\n000\r\n000\r\n000";
            this.Generic_Display.Click += new System.EventHandler(this.Generic_Display_Click);
            // 
            // Settings_Button
            // 
            this.Settings_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Settings_Button.Location = new System.Drawing.Point(449, 119);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(124, 40);
            this.Settings_Button.TabIndex = 7;
            this.Settings_Button.Text = "Settings";
            this.Settings_Button.UseVisualStyleBackColor = true;
            // 
            // Reset_Button
            // 
            this.Reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Reset_Button.Location = new System.Drawing.Point(450, 165);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(124, 40);
            this.Reset_Button.TabIndex = 8;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(450, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Snake_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Settings_Button);
            this.Controls.Add(this.Generic_Display);
            this.Controls.Add(this.Static3);
            this.Controls.Add(this.Ticks_Display);
            this.Controls.Add(this.Static2);
            this.Controls.Add(this.Score_Display);
            this.Controls.Add(this.Static1);
            this.Controls.Add(this.Game_Bord);
            this.Name = "Snake_Window";
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.Game_Bord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Game_Bord;
        private System.Windows.Forms.Label Static1;
        private System.Windows.Forms.Label Score_Display;
        private System.Windows.Forms.Label Static2;
        private System.Windows.Forms.Label Ticks_Display;
        private System.Windows.Forms.Label Static3;
        private System.Windows.Forms.Label Generic_Display;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button button1;
    }
}

