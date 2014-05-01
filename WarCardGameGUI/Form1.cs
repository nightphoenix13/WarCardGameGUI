// Written by Zack Rosales
// Introduction to C# Programming ITSE 1430 1001
// Program for page 351, # 11

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCardGameGUI
{
    public partial class Form1 : Form
    {

        // global variables
        int count,
            computerScore = 0,
            playerScore = 0;
        int[] cardValues = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, // clubs
                            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, // diamonds
                            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, // hearts
                            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,}, // spades
              computerCards = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                               0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
              playerCards = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                             0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
              cardOrder = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                           0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                           0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                           0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        const int DECK_SIZE = 52,
                  HAND_SIZE = 26;
        String computerResult,
               playerResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            clearOutput();
            FillDeck(cardOrder);
        }

        private void handButton_Click(object sender, EventArgs e)
        {
            compareCards(computerCards[count], playerCards[count]);
            displayResults();
            if (count == HAND_SIZE)
                displayFinal();                      
        }

        private void FillDeck(int[] cards) // FillDeck method start
        {
            Random ranNumGenerator = new Random();
            int randomNumber;
            
            // randomizing deck order
            for (int x = 0; x < DECK_SIZE; x++)
            {
                randomNumber = ranNumGenerator.Next(1, DECK_SIZE + 1);
                for (int y = 0; y < x; y++)
                {
                    if (randomNumber == cards[y])
                    {
                        randomNumber = ranNumGenerator.Next(1, DECK_SIZE + 1);
                        y = 0;
                    }
                }
                cards[x] = randomNumber;             
            }

            // splitting decks between players
            for (int x = 0; x < HAND_SIZE; x++)
            {
                computerCards[x] = cardOrder[x];
            }
            for (int x = 0; x < HAND_SIZE; x++)
            {
                playerCards[x] = cardOrder[x + HAND_SIZE];
            }

            infoLabel.Text = "Play your first hand.";
            startButton.Visible = false;
            count = 0;
            handButton.Visible = true;
        } // FillDeck method end

        private void compareCards(int comp, int player) // compareCards method start
        {
            // local variables
            String face,
                   suite;

            // finding computer card
            if (comp - 1 < 13)
                suite = "clubs";
            else if (comp - 1 < HAND_SIZE)
                suite = "diamonds";
            else if (comp - 1 < 39)
                suite = "hearts";
            else
                suite = "spades";
            if (cardValues[comp - 1] == 1)
                face = "Ace";
            else if (cardValues[comp - 1] == 11)
                face = "Jack";
            else if (cardValues[comp - 1] == 12)
                face = "Queen";
            else if (cardValues[comp - 1] == 13)
                face = "King";
            else
                face = String.Format("{0}", cardValues[comp - 1]);
            computerResult = String.Format("Computer has {0} of {1}. ", face, suite);

            // finding player card
            if (player - 1 < 13)
                suite = "clubs";
            else if (player - 1 < HAND_SIZE)
                suite = "diamonds";
            else if (player - 1 < 39)
                suite = "hearts";
            else
                suite = "spades";
            if (cardValues[player - 1] == 1)
                face = "Ace";
            else if (cardValues[player - 1] == 11)
                face = "Jack";
            else if (cardValues[player - 1] == 12)
                face = "Queen";
            else if (cardValues[player - 1] == 13)
                face = "King";
            else
                face = String.Format("{0}", cardValues[player - 1]);
            playerResult = String.Format("Player has {0} of {1}. ", face, suite);

            // calculating score
            if (cardValues[comp - 1] > cardValues[player - 1])
            {
                computerScore += 2;
            }
            else if (cardValues[comp - 1] < cardValues[player - 1])
            {
                playerScore += 2;
            }
            else
            {
                computerScore++;
                playerScore++;
            }
            count++;
            infoLabel.Text = "Play the next hand";
        } // compareCards method end

        private void displayResults() // displayResults method start
        {
            // local variables
            String output1,
                   output2;

            output1 = String.Format("Deal #{0}   {1}  {2}", count, computerResult, playerResult);
            output2 = String.Format("Computer Score is {0}.   Player score is {1}.", computerScore, playerScore);

            if (outputLabel8.Visible)
            {
                outputLabel1.Visible = false;
                outputLabel2.Visible = false;
                outputLabel3.Visible = false;
                outputLabel4.Visible = false;
                outputLabel5.Visible = false;
                outputLabel6.Visible = false;
                outputLabel7.Visible = false;
                outputLabel8.Visible = false;
                outputLabel1.Text = output1;
                outputLabel2.Text = output2;
                outputLabel1.Visible = true;
                outputLabel2.Visible = true;
            }
            else if (outputLabel6.Visible)
            {
                outputLabel7.Text = output1;
                outputLabel8.Text = output2;
                outputLabel7.Visible = true;
                outputLabel8.Visible = true;
            }
            else if (outputLabel4.Visible)
            {
                outputLabel5.Text = output1;
                outputLabel6.Text = output2;
                outputLabel5.Visible = true;
                outputLabel6.Visible = true;
            }
            else if (outputLabel2.Visible)
            {
                outputLabel3.Text = output1;
                outputLabel4.Text = output2;
                outputLabel3.Visible = true;
                outputLabel4.Visible = true;
            }
            else
            {
                outputLabel1.Text = output1;
                outputLabel2.Text = output2;
                outputLabel1.Visible = true;
                outputLabel2.Visible = true;
            }
        } // displayResults method end

        private void displayFinal() // displayFinal method start
        {
            // local variables
            String result;

            if (computerScore > playerScore)
                result = "The computer wins.";
            else if (playerScore > computerScore)
                result = "You won! Great job!";
            else
                result = "Tie game. No winner.";

            outputLabel9.Text = result;
            outputLabel9.Visible = true;
            startButton.Visible = true;
            handButton.Visible = false;
            infoLabel.Text = "Start a new game";

        } // displayFinal method end

        private void clearOutput() // clearOutput method start
        {
            outputLabel1.Visible = false;
            outputLabel2.Visible = false;
            outputLabel3.Visible = false;
            outputLabel4.Visible = false;
            outputLabel5.Visible = false;
            outputLabel6.Visible = false;
            outputLabel7.Visible = false;
            outputLabel8.Visible = false;
            outputLabel9.Visible = false;

            // resets score
            computerScore = 0;
            playerScore = 0;

        } // clearOutput method end
    }
}
