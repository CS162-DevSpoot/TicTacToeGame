namespace CS162_TicTacToeGame
{
    partial class TicTacToeGAME
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
            exitButton = new Button();
            resetGameButton = new Button();
            c3r3PictureBox = new PictureBox();
            c3r2PictureBox = new PictureBox();
            c3r1PictureBox = new PictureBox();
            c2r3PictureBox = new PictureBox();
            c2r2PictureBox = new PictureBox();
            c2r1PictureBox = new PictureBox();
            c1r3PictureBox = new PictureBox();
            c1r2PictureBox = new PictureBox();
            c1r1PictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)c3r3PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c3r2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c3r1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c2r3PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c2r2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c2r1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1r3PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1r2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1r1PictureBox).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.Font = new Font("Segoe UI", 9.75F);
            exitButton.ForeColor = SystemColors.Control;
            exitButton.Location = new Point(124, 359);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(218, 33);
            exitButton.TabIndex = 21;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // resetGameButton
            // 
            resetGameButton.BackColor = Color.LightSkyBlue;
            resetGameButton.Location = new Point(12, 359);
            resetGameButton.Name = "resetGameButton";
            resetGameButton.Size = new Size(106, 33);
            resetGameButton.TabIndex = 20;
            resetGameButton.Text = "Reset Game";
            resetGameButton.UseVisualStyleBackColor = false;
            resetGameButton.Click += resetGameButton_Click;
            // 
            // c3r3PictureBox
            // 
            c3r3PictureBox.BorderStyle = BorderStyle.Fixed3D;
            c3r3PictureBox.Location = new Point(236, 236);
            c3r3PictureBox.Name = "c3r3PictureBox";
            c3r3PictureBox.Size = new Size(106, 106);
            c3r3PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            c3r3PictureBox.TabIndex = 19;
            c3r3PictureBox.TabStop = false;
            c3r3PictureBox.Click += tileSpace_Click;
            // 
            // c3r2PictureBox
            // 
            c3r2PictureBox.BorderStyle = BorderStyle.Fixed3D;
            c3r2PictureBox.Location = new Point(124, 236);
            c3r2PictureBox.Name = "c3r2PictureBox";
            c3r2PictureBox.Size = new Size(106, 106);
            c3r2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            c3r2PictureBox.TabIndex = 18;
            c3r2PictureBox.TabStop = false;
            c3r2PictureBox.Click += tileSpace_Click;
            // 
            // c3r1PictureBox
            // 
            c3r1PictureBox.BorderStyle = BorderStyle.Fixed3D;
            c3r1PictureBox.Location = new Point(12, 236);
            c3r1PictureBox.Name = "c3r1PictureBox";
            c3r1PictureBox.Size = new Size(106, 106);
            c3r1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            c3r1PictureBox.TabIndex = 17;
            c3r1PictureBox.TabStop = false;
            c3r1PictureBox.Click += tileSpace_Click;
            // 
            // c2r3PictureBox
            // 
            c2r3PictureBox.BorderStyle = BorderStyle.Fixed3D;
            c2r3PictureBox.Location = new Point(236, 124);
            c2r3PictureBox.Name = "c2r3PictureBox";
            c2r3PictureBox.Size = new Size(106, 106);
            c2r3PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            c2r3PictureBox.TabIndex = 16;
            c2r3PictureBox.TabStop = false;
            c2r3PictureBox.Click += tileSpace_Click;
            // 
            // c2r2PictureBox
            // 
            c2r2PictureBox.BorderStyle = BorderStyle.Fixed3D;
            c2r2PictureBox.Location = new Point(124, 124);
            c2r2PictureBox.Name = "c2r2PictureBox";
            c2r2PictureBox.Size = new Size(106, 106);
            c2r2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            c2r2PictureBox.TabIndex = 15;
            c2r2PictureBox.TabStop = false;
            c2r2PictureBox.Click += tileSpace_Click;
            // 
            // c2r1PictureBox
            // 
            c2r1PictureBox.BorderStyle = BorderStyle.Fixed3D;
            c2r1PictureBox.Location = new Point(12, 124);
            c2r1PictureBox.Name = "c2r1PictureBox";
            c2r1PictureBox.Size = new Size(106, 106);
            c2r1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            c2r1PictureBox.TabIndex = 14;
            c2r1PictureBox.TabStop = false;
            c2r1PictureBox.Click += tileSpace_Click;
            // 
            // c1r3PictureBox
            // 
            c1r3PictureBox.BorderStyle = BorderStyle.Fixed3D;
            c1r3PictureBox.Location = new Point(236, 12);
            c1r3PictureBox.Name = "c1r3PictureBox";
            c1r3PictureBox.Size = new Size(106, 106);
            c1r3PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            c1r3PictureBox.TabIndex = 13;
            c1r3PictureBox.TabStop = false;
            c1r3PictureBox.Click += tileSpace_Click;
            // 
            // c1r2PictureBox
            // 
            c1r2PictureBox.BorderStyle = BorderStyle.Fixed3D;
            c1r2PictureBox.Location = new Point(124, 12);
            c1r2PictureBox.Name = "c1r2PictureBox";
            c1r2PictureBox.Size = new Size(106, 106);
            c1r2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            c1r2PictureBox.TabIndex = 12;
            c1r2PictureBox.TabStop = false;
            c1r2PictureBox.Click += tileSpace_Click;
            // 
            // c1r1PictureBox
            // 
            c1r1PictureBox.BorderStyle = BorderStyle.Fixed3D;
            c1r1PictureBox.Location = new Point(12, 12);
            c1r1PictureBox.Name = "c1r1PictureBox";
            c1r1PictureBox.Size = new Size(106, 106);
            c1r1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            c1r1PictureBox.TabIndex = 11;
            c1r1PictureBox.TabStop = false;
            c1r1PictureBox.Click += tileSpace_Click;
            // 
            // TicTacToeGAME
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 401);
            Controls.Add(exitButton);
            Controls.Add(resetGameButton);
            Controls.Add(c3r3PictureBox);
            Controls.Add(c3r2PictureBox);
            Controls.Add(c3r1PictureBox);
            Controls.Add(c2r3PictureBox);
            Controls.Add(c2r2PictureBox);
            Controls.Add(c2r1PictureBox);
            Controls.Add(c1r3PictureBox);
            Controls.Add(c1r2PictureBox);
            Controls.Add(c1r1PictureBox);
            Name = "TicTacToeGAME";
            Text = "TicTacToe Game";
            ((System.ComponentModel.ISupportInitialize)c3r3PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)c3r2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)c3r1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)c2r3PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)c2r2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)c2r1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1r3PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1r2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1r1PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private Button resetGameButton;
        private PictureBox c3r3PictureBox;
        private PictureBox c3r2PictureBox;
        private PictureBox c3r1PictureBox;
        private PictureBox c2r3PictureBox;
        private PictureBox c2r2PictureBox;
        private PictureBox c2r1PictureBox;
        private PictureBox c1r3PictureBox;
        private PictureBox c1r2PictureBox;
        private PictureBox c1r1PictureBox;
    }
}
