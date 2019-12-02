namespace Snake_AI
{
    partial class Defeat_Window
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
            this.Continue_Button = new System.Windows.Forms.Button();
            this.Static1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Continue_Button
            // 
            this.Continue_Button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Continue_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Continue_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Continue_Button.Location = new System.Drawing.Point(163, 56);
            this.Continue_Button.Name = "Continue_Button";
            this.Continue_Button.Size = new System.Drawing.Size(118, 39);
            this.Continue_Button.TabIndex = 0;
            this.Continue_Button.Text = "Continue";
            this.Continue_Button.UseVisualStyleBackColor = false;
            this.Continue_Button.Click += new System.EventHandler(this.Continue_Button_Click);
            // 
            // Static1
            // 
            this.Static1.AutoSize = true;
            this.Static1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Static1.Location = new System.Drawing.Point(12, 9);
            this.Static1.Name = "Static1";
            this.Static1.Size = new System.Drawing.Size(396, 37);
            this.Static1.TabIndex = 1;
            this.Static1.Text = "Congratulations, You won!";
            // 
            // Victoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 107);
            this.Controls.Add(this.Static1);
            this.Controls.Add(this.Continue_Button);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "Victoy";
            this.Text = "Victoy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Continue_Button;
        private System.Windows.Forms.Label Static1;
    }
}