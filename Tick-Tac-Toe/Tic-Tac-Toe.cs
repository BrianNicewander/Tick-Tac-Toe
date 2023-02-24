using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tick_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblWinner.Text = ""; //Clears the winner label
            string[,] gameboard = new string[3, 3]; 
            bool playerX = true; // puts it as player x turn first
            int gamePlaces = 0; // keeps how many spots are filled


            while (gamePlaces < 9) //runs while the gameplace is less then 9
            {
                Random rand = new Random();
                int row = rand.Next(0, 3); //gets a random number for the row
                int col = rand.Next(0, 3); //gets a random number for the col

                if (gameboard[row, col] == null) //checks to make sure there is nothing in the label it picked
                {

                    //player X turn
                    if (playerX == true)
                    {
                        gameboard[row, col] = "X"; //puts a x in whatever label it is in
                        playerX = false; //turns player to false so it is O turn
                        gamePlaces++; //adds one to the gameplace
                    }

                    //Player O turn
                    else
                    {
                        gameboard[row, col] = "O"; //puts a O in whatever label it is in
                        playerX = true; //turns player to true so it is X turn
                        gamePlaces++; //adds one to the gameplace
                    }

                    System.Threading.Thread.Sleep(100);//slows down how fast the loop runs.
                }

                //This is in the while loop so it will check if there is a winner after every move
                //Checks to see if O wins

                //These check to see if O won horizontal.
                if (gameboard[0, 0] == "O" && gameboard[0, 1] == "O" && gameboard[0, 2] == "O") //If there is an O in all these spots O win
                {
                    lblWinner.Text = "O wins";
                    break; //If there is a winner this breaks out of the loop
                }
                else if (gameboard[1, 0] == "O" && gameboard[1, 1] == "O" && gameboard[1, 2] == "O") //If there is an O in all these spots O win
                {
                    lblWinner.Text = "O wins";
                    break; //If there is a winner this breaks out of the loop
                }
                else if (gameboard[2, 0] == "O" && gameboard[2, 1] == "O" && gameboard[2, 2] == "O") //If there is an O in all these spots O win
                {
                    lblWinner.Text = "O wins";
                    break; //If there is a winner this breaks out of the loop
                }

                //These check to see if O won vertical.
                else if (gameboard[0, 0] == "O" && gameboard[1, 0] == "O" && gameboard[2, 0] == "O") //If there is an O in all these spots O win
                {
                    lblWinner.Text = "O wins";
                    break; //If there is a winner this breaks out of the loop
                }
                else if (gameboard[0, 1] == "O" && gameboard[1, 1] == "O" && gameboard[2, 1] == "O") //If there is an O in all these spots O win
                {
                    lblWinner.Text = "O wins";
                    break; //If there is a winner this breaks out of the loop
                }
                else if (gameboard[0, 2] == "O" && gameboard[1, 2] == "O" && gameboard[2, 2] == "O") //If there is an O in all these spots O win
                {
                    lblWinner.Text = "O wins";
                    break; //If there is a winner this breaks out of the loop
                }

                //These check to see if O won at an \ or /.
                else if (gameboard[0, 0] == "O" && gameboard[1, 1] == "O" && gameboard[2, 2] == "O") //If there is an O in all these spots O win
                {
                    lblWinner.Text = "O wins";
                    break; //If there is a winner this breaks out of the loop
                }
                else if (gameboard[0, 2] == "O" && gameboard[1, 1] == "O" && gameboard[2, 0] == "O") //If there is an O in all these spots O win
                {
                    lblWinner.Text = "O wins";
                    break; //If there is a winner this breaks out of the loop
                }


                //Checks to see if X wins

                //These check to see if X won horizontal.
                if (gameboard[0, 0] == "X" && gameboard[0, 1] == "X" && gameboard[0, 2] == "X") //If there is an X in all these spots X win
                {
                    lblWinner.Text = "X wins";
                    break; //If there is a winner this breaks out of the loop
                }
                else if (gameboard[1, 0] == "X" && gameboard[1, 1] == "X" && gameboard[1, 2] == "X") //If there is an X in all these spots X win
                {
                    lblWinner.Text = "X wins";
                    break; //If there is a winner this breaks out of the loop
                }
                else if (gameboard[2, 0] == "X" && gameboard[2, 1] == "X" && gameboard[2, 2] == "X") //If there is an X in all these spots X win
                {
                    lblWinner.Text = "X wins";
                    break; //If there is a winner this breaks out of the loop
                }

                //These check to see if X won vertical.
                else if (gameboard[0, 0] == "X" && gameboard[1, 0] == "X" && gameboard[2, 0] == "X") //If there is an X in all these spots X win
                {
                    lblWinner.Text = "X wins";
                    break; //If there is a winner this breaks out of the loop
                }
                else if (gameboard[0, 1] == "X" && gameboard[1, 1] == "X" && gameboard[2, 1] == "X") //If there is an X in all these spots X win
                {
                    lblWinner.Text = "X wins";
                    break; //If there is a winner this breaks out of the loop
                }
                else if (gameboard[0, 2] == "X" && gameboard[1, 2] == "X" && gameboard[2, 2] == "X") //If there is an X in all these spots X win
                {
                    lblWinner.Text = "X wins";
                    break; //If there is a winner this breaks out of the loop
                }

                //These check to see if X won at an \ or /.
                else if (gameboard[0, 0] == "X" && gameboard[1, 1] == "X" && gameboard[2, 2] == "X") //If there is an X in all these spots X win
                {
                    lblWinner.Text = "X wins";
                    break; //If there is a winner this breaks out of the loop
                }
                else if (gameboard[0, 2] == "X" && gameboard[1, 1] == "X" && gameboard[2, 0] == "X") //If there is an X in all these spots X win
                {
                    lblWinner.Text = "X wins";
                    break; //If there is a winner this breaks out of the loop
                }

                if (gamePlaces == 9)//This runs if there is no winner after all 9 spots are filled up and no one has won
                {
                    lblWinner.Text = "It is a tie";
                }
            }

            //This prints the results from the loop above

            if (gameboard[0, 0] != null) //makes sure the label has something in it then puts whatever it is in it.
            {
                lblZeroZero.Text = gameboard[0, 0].ToString();
            }
            else //if there is nothing in the label it puts a empty space in it.
            {
                lblZeroZero.Text = " "; 
            }

            if (gameboard[0, 1] != null) //makes sure the label has something in it then puts whatever it is in it.
            {
                lblZeroOne.Text = gameboard[0, 1].ToString();
            }
            else //if there is nothing in the label it puts a empty space in it.
            {
                lblZeroOne.Text = " "; 
            }

            if (gameboard[0, 2] != null) //makes sure the label has something in it then puts whatever it is in it.
            {
                lblZeroTwo.Text = gameboard[0, 2].ToString();
            }
            else //if there is nothing in the label it puts a empty space in it.
            {
                lblZeroTwo.Text = " "; 
            }

            if (gameboard[1, 0] != null) //makes sure the label has something in it then puts whatever it is in it.
            {
                lblOneZero.Text = gameboard[1, 0].ToString();
            }
            else //if there is nothing in the label it puts a empty space in it.
            {
                lblOneZero.Text = " ";
            }

            if (gameboard[1, 1] != null) //makes sure the label has something in it then puts whatever it is in it.
            {
                lblOneOne.Text = gameboard[1, 1].ToString();
            }
            else //if there is nothing in the label it puts a empty space in it.
            {
                lblOneOne.Text = " ";
            }

            if (gameboard[1, 2] != null) //makes sure the label has something in it then puts whatever it is in it.
            {
                lblOneTwo.Text = gameboard[1, 2].ToString();
            }
            else //if there is nothing in the label it puts a empty space in it.
            {
                lblOneTwo.Text = " ";
            }

            if (gameboard[2, 0] != null) //makes sure the label has something in it then puts whatever it is in it.
            {
                lblTwoZero.Text = gameboard[2, 0].ToString();
            }
            else //if there is nothing in the label it puts a empty space in it.
            {
                lblTwoZero.Text = " ";
            }

            if (gameboard[2, 1] != null) //makes sure the label has something in it then puts whatever it is in it.
            {
                lblTwoOne.Text = gameboard[2, 1].ToString();
            }
            else //if there is nothing in the label it puts a empty space in it.
            {
                lblTwoOne.Text = " ";
            }

            if (gameboard[2, 2] != null) //makes sure the label has something in it then puts whatever it is in it.
            {
                lblTwoTwo.Text = gameboard[2, 2].ToString();
            }
            else //if there is nothing in the label it puts a empty space in it.
            {
                lblTwoTwo.Text = " ";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {//This closes the program
            this.Close();
        }
    }
}
