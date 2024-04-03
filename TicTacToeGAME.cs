using System.Drawing;

namespace CS162_TicTacToeGame
{
    public partial class TicTacToeGAME : Form
    {
        public TicTacToeGAME()
        {
            InitializeComponent();
        }

        //global vairbale that holds the data for our gameboard.
        bool?[,] gameSpace = { {null, null, null },
                               {null, null, null },
                               {null, null, null } };

        bool secondPlayersTurn = false; // Flag to track whos turn it is, specifically tracking if it's the second players turn.

        private void resetGame() // Method to reseat the board and all the picture boxes.
        {
            computerGame = false;
            aiGame_Checkbox.Checked = false;

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

        private void resetGameButton_Click(object sender, EventArgs e) //Button click event handler, incase the players wanted to reset the game before someone won.
        {
            resetGame(); // Calling our resetGame method.
        }

        private void checkForWinners() // Checking for winners.
        {
            bool taylorWon = false; // Flags to track who has one.
            bool travisWon = false;

            //The following if statements check if there is a wining condition.
            if ((gameSpace[0, 0] == true) && (gameSpace[0, 1] == true) && (gameSpace[0, 2] == true)) { taylorWon = true; }
            if ((gameSpace[1, 0] == true) && (gameSpace[1, 1] == true) && (gameSpace[1, 2] == true)) { taylorWon = true; }
            if ((gameSpace[2, 0] == true) && (gameSpace[2, 1] == true) && (gameSpace[2, 2] == true)) { taylorWon = true; }

            if ((gameSpace[0, 0] == false) && (gameSpace[0, 1] == false) && (gameSpace[0, 2] == false)) { travisWon = true; }
            if ((gameSpace[1, 0] == false) && (gameSpace[1, 1] == false) && (gameSpace[1, 2] == false)) { travisWon = true; }
            if ((gameSpace[2, 0] == false) && (gameSpace[2, 1] == false) && (gameSpace[2, 2] == false)) { travisWon = true; }


            if ((gameSpace[0, 0] == true) && (gameSpace[1, 0] == true) && (gameSpace[2, 0] == true)) { taylorWon = true; }
            if ((gameSpace[0, 1] == true) && (gameSpace[1, 1] == true) && (gameSpace[2, 1] == true)) { taylorWon = true; }
            if ((gameSpace[0, 2] == true) && (gameSpace[1, 2] == true) && (gameSpace[2, 2] == true)) { taylorWon = true; }

            if ((gameSpace[0, 0] == false) && (gameSpace[1, 0] == false) && (gameSpace[2, 0] == false)) { travisWon = true; }
            if ((gameSpace[0, 1] == false) && (gameSpace[1, 1] == false) && (gameSpace[2, 1] == false)) { travisWon = true; }
            if ((gameSpace[0, 2] == false) && (gameSpace[1, 2] == false) && (gameSpace[2, 2] == false)) { travisWon = true; }


            if ((gameSpace[0, 0] == true) && (gameSpace[1, 1] == true) && (gameSpace[2, 2] == true)) { taylorWon = true; }
            if ((gameSpace[2, 0] == true) && (gameSpace[1, 1] == true) && (gameSpace[0, 2] == true)) { taylorWon = true; }

            if ((gameSpace[0, 0] == false) && (gameSpace[1, 1] == false) && (gameSpace[2, 2] == false)) { travisWon = true; }
            if ((gameSpace[2, 0] == false) && (gameSpace[1, 1] == false) && (gameSpace[0, 2] == false)) { travisWon = true; }

            if (travisWon && taylorWon) { MessageBox.Show("This Game Was A TIE!"); return; } // Checks if there's a tie, which techincally isn't needed now.

            if (taylorWon) { MessageBox.Show("Taylor WON!"); resetGame(); } //If taylor won aka player 1, say so and reset the game.
            if (travisWon) { MessageBox.Show("Travis WON!"); resetGame(); } //If travis won aka player 2, say so and reset the game.

            if (!travisWon && !taylorWon) { return; } //If no one won, contiune letting the players play.

        }

        bool computerGame = false;

        private void tileSpace_Click(object sender, EventArgs e) //Method to handle the pciturebox click event.
        {
            PictureBox tileSpace = (PictureBox)sender; //Get the picturebox clicked.
            char[] characters = tileSpace.Name.ToCharArray(); //Stringify it's control Name.

            int[] tileIndex = new int[2]; //Vairable to hold the "corrdinates" of the picturebox, aka which specific tile was clicked.

            int index = 0; //Var to hold index.
            foreach (var item in characters) //For every character in the contorl name do...
            {
                int tmp = 0;
                if (int.TryParse(item.ToString(), out tmp)) //Check and try to convert the character to an int. tileSpaces are all formated with coloumn and rows in their contorl name. So we can find the coloumn and row and store those values.

                {
                    tileIndex[index] = tmp; //Updating the values.
                    index++; //Updating the index of which to store the value.
                }
            }

            if (secondPlayersTurn && !computerGame) //Checking if it's the second players turn. If so, show travis, update the gameSapce/Board, and update the flag, else show taylor, update the gameSpace and flag.
            {
                tileSpace.Image = Resource1.TravisKelece;
                gameSpace[tileIndex[0] - 1, tileIndex[1] - 1] = false;

                secondPlayersTurn = false;
            }
            else if (!secondPlayersTurn && !computerGame)
            {
                tileSpace.Image = Resource1.TaylorSwift;
                gameSpace[tileIndex[0] - 1, tileIndex[1] - 1] = true;

                secondPlayersTurn = true;

            }

            if(computerGame && !secondPlayersTurn)
            {
                tileSpace.Image = Resource1.TaylorSwift;
                gameSpace[tileIndex[0] - 1, tileIndex[1] - 1] = true;

                secondPlayersTurn = true;
                AI_PickSpot();
            }

            checkForWinners(); //Checking for winners.
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aiGame_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox computerGameCheckbox = (CheckBox)sender;
            bool isComputerGame = computerGameCheckbox.Checked;

            resetGame();
            if (isComputerGame)
            {
                computerGame = true;
                secondPlayersTurn = firstPlayerDecider();
                if (secondPlayersTurn) { MessageBox.Show("The AI (Aka Travis) will go first."); } else { MessageBox.Show("You will go first, Taylor Swift."); }

                AI_PickSpot();
            }
            else
            {
                computerGame = false;
            }
        }

        private bool firstPlayerDecider()
        {
            Random rand = new Random();
            int rand1 = rand.Next(0, 100);
            int rand2 = rand.Next(0, 100);

            if(rand1 > rand2)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private bool AI_PickSpot()
        {
            if (!secondPlayersTurn) { return true; }
            Random random = new Random();

       
             int coloum = 0;
             int row = 0;

             bool spotFound = false;

            while (!spotFound)
            {
                coloum = random.Next(0, 3);
                row = random.Next(0, 3);

                if (gameSpace[coloum, row] == null)
                {
                    spotFound = true;
                }
            }

            PictureBox tileSpace = (PictureBox)this.Controls.Find($"c{coloum+1}r{row+1}PictureBox", true)[0];
            tileSpace.Image = Resource1.TravisKelece;
            gameSpace[coloum, row] = false;
            secondPlayersTurn = false;
            checkForWinners();
            return true;
        }

    }
}
