namespace WindowPong
{
    partial class BallWindow
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
            // Muahahahahahaha I edited it

            this.ballPhysics = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ballPhysics
            // 
            this.ballPhysics.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BallPhysics_DoWork);
            // 
            // BallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(80, 42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BallWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ball";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.BallWindow_Load);
            this.Shown += new System.EventHandler(this.BallWindow_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BallWindow_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker ballPhysics;
    }
}

