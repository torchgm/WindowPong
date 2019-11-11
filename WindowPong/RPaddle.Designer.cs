namespace WindowPong
{
    partial class RPaddle
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
            this.Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(57, 63);
            this.Score.TabIndex = 1;
            this.Score.Text = "0";
            // 
            // RPaddle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(122, 865);
            this.Controls.Add(this.Score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RPaddle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Player 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Score;
    }
}