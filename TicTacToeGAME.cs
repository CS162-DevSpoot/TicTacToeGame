using System.Drawing;

namespace CS162_TicTacToeGame
{
    public partial class TicTacToeGAME : Form
    {
        public TicTacToeGAME()
        {
            InitializeComponent();
        }

        bool?[,] gameSpace = { {null, null, null },
                               {null, null, null },
                               {null, null, null } };

        bool secondPlayersTurn = false;

        private void resetGame ()
        {
            for (int COLOUM = 0; COLOUM < gameSpace.GetLength(0); COLOUM++)
            {
                for (int ROW = 0; ROW < gameSpace.GetLength(1); ROW++)
                {
                    PictureBox spacePictureBox = (PictureBox)this.Controls.Find($"c{COLOUM + 1}r{ROW + 1}PictureBox", true)[0];
                    spacePictureBox.Image = null;
                    gameSpace[COLOUM, ROW] = null;

                }
            }
        }

        private void resetGameButton_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void checkForWinners()
        {
            bool taylorWon = false;
            bool travisWon = false;

            if ((gameSpace[0, 0] == true) && (gameSpace[0, 1] == true) && ( gameSpace[0, 2] == true)){ taylorWon = true; }
            if ((gameSpace[1, 0] == true) && (gameSpace[1, 1] == true) && (gameSpace[1, 2] == true)) {taylorWon = true; }
            if ((gameSpace[2, 0] == true) && (gameSpace[2, 1] == true) && (gameSpace[2, 2] == true)) {taylorWon = true;  }

            if ((gameSpace[0, 0] == false) && (gameSpace[0, 1] == false) && (gameSpace[0, 2] == false)) { travisWon = true;  }
            if ((gameSpace[1, 0] == false) && (gameSpace[1, 1] == false) && (gameSpace[1, 2] == false)) { travisWon = true;  }
            if ((gameSpace[2, 0] == false) && (gameSpace[2, 1] == false) && (gameSpace[2, 2] == false)) { travisWon = true;  }


            if ((gameSpace[0, 0] == true) && (gameSpace[1, 0] == true) && (gameSpace[2, 0] == true)) {taylorWon = true;  }
            if ((gameSpace[0, 1] == true) && (gameSpace[1, 1] == true) && (gameSpace[2, 1] == true)) {taylorWon = true;  }
            if ((gameSpace[0, 2] == true) && (gameSpace[1, 2] == true) && (gameSpace[2, 2] == true)) {taylorWon = true;  }

            if ((gameSpace[0, 0] == false) && (gameSpace[1, 0] == false) && (gameSpace[2, 0] == false)) { travisWon = true;  }
            if ((gameSpace[0, 1] == false) && (gameSpace[1, 1] == false) && (gameSpace[2, 1] == false)) { travisWon = true;  }
            if ((gameSpace[0, 2] == false) && (gameSpace[1, 2] == false) && (gameSpace[2, 2] == false)) { travisWon = true;  }


            if ((gameSpace[0, 0] == true) && (gameSpace[1, 1] == true) && (gameSpace[2, 2] == true)) {taylorWon = true;  }
            if ((gameSpace[2, 0] == true) && (gameSpace[1, 1] == true) && (gameSpace[0, 2] == true)) {taylorWon = true;  }

            if ((gameSpace[0, 0] == false) && (gameSpace[1, 1] == false) && (gameSpace[2, 2] == false)) { travisWon = true;  }
            if ((gameSpace[2, 0] == false) && (gameSpace[1, 1] == false) && (gameSpace[0, 2] == false)) { travisWon = true;  }

            if(travisWon && taylorWon) { MessageBox.Show("This Game Was A TIE!"); return; }
            if (taylorWon) { MessageBox.Show("Taylor WON!"); resetGame(); }
            if (travisWon) { MessageBox.Show("Travis WON!"); resetGame(); }
            if(!travisWon && !taylorWon) { return; }

        }


        private void tileSpace_Click(object sender, EventArgs e)
        {
           PictureBox tileSpace = (PictureBox)sender;
            char[] characters = tileSpace.Name.ToCharArray();

            int[] tileIndex = new int[2];

            int index = 0;
            foreach (var item in characters)
            {
                int tmp = 0;
                if (int.TryParse(item.ToString(), out tmp))
                {
                    tileIndex[index] = tmp;
                    index++;
                }
            }

            if (secondPlayersTurn)
            {
                tileSpace.Image = Resource1.TravisKelece;
                gameSpace[tileIndex[0]-1, tileIndex[1]-1] = false;

                secondPlayersTurn = false;
            }
            else
            {
                tileSpace.Image = Resource1.TaylorSwift;
                gameSpace[tileIndex[0] - 1, tileIndex[1] - 1] = true;

                secondPlayersTurn = true;

            }
            //MessageBox.Show($"The Tile you clicked is located at ({tileIndex[0]}, {tileIndex[1]}).");
            checkForWinners();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
