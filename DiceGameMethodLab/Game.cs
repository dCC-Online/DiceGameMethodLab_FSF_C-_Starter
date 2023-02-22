using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameMethodLab
{
    internal class Game
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        int playerOneScore;
        int playerTwoScore;
        Random rand;

        //Constructor - Sets the scores to 0 when a new game is created
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            rand = new Random();
        }

        //Member Methods
        public int RollDice(int numberOfSides)
        {
            //This method is complete! When called, it will return a random number.
            //You will need to pass in an integer as the parameter to represent the
            //number of sides of the dice being rolled.
            return rand.Next(numberOfSides);
        }

        public void DisplayWelcome()
        {
            //This method is complete! It will display a welcome message to the player
            //Notice that it is already being called inside the RunGame() method,
            //so it will run when you start the application.
            Console.WriteLine("Welcome to the game!");
        }

        //Don't change anything above this ^^^^^^^^^^^^


        public int ChooseNumberOfSides()
        {
            //This method should prompt the user to enter the number of sides,
            //capture user input and return it after converting it to an integer.
            //This method only needs to be called once in RunGame(), but the returned
            //value should be captured as a variable that will be passed into the
            //RollDice() method each time it's called.


            return 0;
        }


        public void CompareRolls(int playerOneRoll, int playerTwoRoll)
        {
            //This method should compare the two parameter values, then increase the
            //score of whoever's roll is higher
            //For example, if playerOneRoll is 5 and playerTwoRoll is 2,
            //playerOneScore should be increased by 1.




        }


        public void DisplayWinner()
        {
            //This method should print a message declaring the winner of the game,
            //ie, the first player who reaches a score of 3



        }


        public void RunGame()
        {
            //This is the main method that is called in the Program when you press Start
            //Call your other methods inside this method
            //You should incorporate a loop to allow for rounds of play
            //to continue until there is a winner


            DisplayWelcome();






        }
    }
}
