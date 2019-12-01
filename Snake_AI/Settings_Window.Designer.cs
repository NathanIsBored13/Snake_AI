namespace Snake_AI
{
    partial class Settings_Window
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
            this.Tick_Speed_Input = new System.Windows.Forms.TrackBar();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Static1 = new System.Windows.Forms.Label();
            this.Bord_Size_Input = new System.Windows.Forms.TextBox();
            this.Static2 = new System.Windows.Forms.Label();
            this.Tick_Speed_Display = new System.Windows.Forms.Label();
            this.Set_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tick_Speed_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // Tick_Speed_Input
            // 
            this.Tick_Speed_Input.Location = new System.Drawing.Point(140, 41);
            this.Tick_Speed_Input.Minimum = 1;
            this.Tick_Speed_Input.Name = "Tick_Speed_Input";
            this.Tick_Speed_Input.Size = new System.Drawing.Size(157, 45);
            this.Tick_Speed_Input.TabIndex = 0;
            this.Tick_Speed_Input.Value = 10;
            this.Tick_Speed_Input.Scroll += new System.EventHandler(this.Tick_Speed_Input_Scroll);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(240, 95);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(52, 24);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Static1
            // 
            this.Static1.AutoSize = true;
            this.Static1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Static1.Location = new System.Drawing.Point(12, 9);
            this.Static1.Name = "Static1";
            this.Static1.Size = new System.Drawing.Size(109, 26);
            this.Static1.TabIndex = 2;
            this.Static1.Text = "Bord size:";
            // 
            // Bord_Size_Input
            // 
            this.Bord_Size_Input.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Bord_Size_Input.Location = new System.Drawing.Point(140, 15);
            this.Bord_Size_Input.MaxLength = 20;
            this.Bord_Size_Input.Name = "Bord_Size_Input";
            this.Bord_Size_Input.Size = new System.Drawing.Size(157, 20);
            this.Bord_Size_Input.TabIndex = 3;
            // 
            // Static2
            // 
            this.Static2.AutoSize = true;
            this.Static2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Static2.Location = new System.Drawing.Point(12, 41);
            this.Static2.Name = "Static2";
            this.Static2.Size = new System.Drawing.Size(122, 26);
            this.Static2.TabIndex = 4;
            this.Static2.Text = "Tick speed:";
            // 
            // Tick_Speed_Display
            // 
            this.Tick_Speed_Display.AutoSize = true;
            this.Tick_Speed_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Tick_Speed_Display.Location = new System.Drawing.Point(199, 75);
            this.Tick_Speed_Display.Name = "Tick_Speed_Display";
            this.Tick_Speed_Display.Size = new System.Drawing.Size(50, 17);
            this.Tick_Speed_Display.TabIndex = 5;
            this.Tick_Speed_Display.Text = "000ms";
            this.Tick_Speed_Display.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Set_Button
            // 
            this.Set_Button.Location = new System.Drawing.Point(182, 95);
            this.Set_Button.Name = "Set_Button";
            this.Set_Button.Size = new System.Drawing.Size(52, 24);
            this.Set_Button.TabIndex = 6;
            this.Set_Button.Text = "Set";
            this.Set_Button.UseVisualStyleBackColor = true;
            this.Set_Button.Click += new System.EventHandler(this.Set_Button_Click);
            // 
            // Settings_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 129);
            this.Controls.Add(this.Set_Button);
            this.Controls.Add(this.Tick_Speed_Display);
            this.Controls.Add(this.Static2);
            this.Controls.Add(this.Bord_Size_Input);
            this.Controls.Add(this.Static1);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Tick_Speed_Input);
            this.Name = "Settings_Window";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tick_Speed_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Tick_Speed_Input;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label Static1;
        private System.Windows.Forms.TextBox Bord_Size_Input;
        private System.Windows.Forms.Label Static2;
        private System.Windows.Forms.Label Tick_Speed_Display;
        private System.Windows.Forms.Button Set_Button;
    }
}