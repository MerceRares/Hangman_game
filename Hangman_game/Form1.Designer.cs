namespace Hangman_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWordDisplay = new Label();
            btnGuess = new Button();
            tbGuess = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWordDisplay
            // 
            lblWordDisplay.BorderStyle = BorderStyle.Fixed3D;
            lblWordDisplay.Font = new Font("SansSerif", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
            lblWordDisplay.Location = new Point(26, 21);
            lblWordDisplay.Name = "lblWordDisplay";
            lblWordDisplay.RightToLeft = RightToLeft.No;
            lblWordDisplay.Size = new Size(464, 67);
            lblWordDisplay.TabIndex = 0;
            lblWordDisplay.Text = "Spanzuratoarea";
            lblWordDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.Gold;
            btnGuess.Font = new Font("SansSerif", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnGuess.Location = new Point(12, 376);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(248, 62);
            btnGuess.TabIndex = 1;
            btnGuess.Text = "Ghiceste";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += btnGuess_Click;
            // 
            // tbGuess
            // 
            tbGuess.Font = new Font("SansSerif", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
            tbGuess.Location = new Point(383, 376);
            tbGuess.Name = "tbGuess";
            tbGuess.Size = new Size(96, 62);
            tbGuess.TabIndex = 2;
            tbGuess.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(23, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(467, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(517, 450);
            Controls.Add(pictureBox1);
            Controls.Add(tbGuess);
            Controls.Add(btnGuess);
            Controls.Add(lblWordDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWordDisplay;
        private Button btnGuess;
        private TextBox tbGuess;
        private PictureBox pictureBox1;
    }
}
