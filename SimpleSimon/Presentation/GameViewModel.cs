using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;
using SimpleSimon.Models;
using System.Windows.Threading;

namespace SimpleSimon.Presentation
{
    public class GameViewModel : ObservableObject
    {
        private Player _player;
        private Buttons _buttons;
        private Simon _simon;
        private Random _random;
        private Score _score;

        private int playerWins=0;
        private int simonWins = 0;
        private int roundCount=0;
        public int simonPlay;

        private bool playerClicked;

        private string buttonPushed;


        //******
        //Models
        //*******
        public Player Player
        {
            get { return _player; }
            set
            {
                _player = value;
                OnPropertyChanged(nameof(Player));
            }
        }

        public Simon Simon
        {
            get { return _simon; }
            set
            {
                _simon = value;
                OnPropertyChanged(nameof(Simon));
            }
        }

        public Buttons Buttons
        {
            get { return _buttons; }
            set
            {
                _buttons = value;
                OnPropertyChanged(nameof(Buttons));

            }
        }

        public Score Score
        {
            get { return _score; }
            set
            {
                _score = value;
                OnPropertyChanged(nameof(Score));

            }
        }

        // *************************************
        //  Methods to linked with button clicks
        //**************************************

        public void RedClick()
        {
            SetGameBoard();
            buttonPushed = "Red";
            playerClicked = true;
            PlayRound();
        }

        public void YellowClick()
        {
            SetGameBoard();
            buttonPushed = "Yellow";
            playerClicked = true;
            PlayRound(); 
        }

        public void GreenClick()
        {
            SetGameBoard();
            buttonPushed = "Green";
            playerClicked = true;
            PlayRound();
        }

        public void BlueClick()
        {
            SetGameBoard();
            buttonPushed = "Blue";
            playerClicked = true;
            PlayRound();
        }


        // ***********************
        // Methods for game play
        //************************

        public void PlayRound()
        {
            //wait for player to click a button
            if (playerClicked == true)
            {
                //round had begun
                roundCount++;

                //simon chooses one of the 4 colors at random
                int simonPlay = _random.Next(1, 5);

                //player choice assigned a number based on color 
                switch (buttonPushed)
                {
                    case "Red":
                        Player.PlayerSays = 1;
                        playerClicked = false;
                        break;

                    case "Yellow":
                        Player.PlayerSays = 2;
                        playerClicked = false;
                        break;

                    case "Green":
                        Player.PlayerSays = 3;
                        playerClicked = false;
                        break;

                    case "Blue":
                        Player.PlayerSays = 4;
                        playerClicked = false;
                        break;
                }

                //change color of button based on Simon's choice
                switch (simonPlay)
                {
                    case 1:
                        Buttons.Red = "Red";
                        break;

                    case 2:
                        Buttons.Yellow = "Yellow";
                        break;

                    case 3:
                        Buttons.Green = "Lime";
                        break;

                    case 4:
                        Buttons.Blue = "Cyan";
                        break;
                }

                //compare player choice with simon choice 

                //if player choose the same then player wins
                if (Player.PlayerSays == simonPlay)
                {
                    playerWins++;
                    Score.PlayerWins = "Wins: " +playerWins.ToString();
                    Score.Round = "Round: " + roundCount.ToString();

                    Player.Result = "WINNER";
                    Player.ResultColor = "Green";

                    Simon.Result = "LOSER";
                    Simon.ResultColor = "Red";
                }

                //if player chouce did not match then player loses
                if (Player.PlayerSays != simonPlay)
                {
                    simonWins++;
                    Score.SimonWins = "Wins: " +simonWins.ToString();
                    Score.Round = "Round: " + roundCount.ToString();

                    Player.Result = "LOSER";
                    Player.ResultColor = "Red";

                    Simon.Result = "WINNER";
                    Simon.ResultColor = "Green";
                }
            }
        }
       
        public void NewGameSet()
        {
            //reset Button properties
            Buttons.Red = "DarkRed";
            Buttons.Yellow = "DarkGoldenrod";
            Buttons.Green = "Green";
            Buttons.Blue = "Blue";

            //reset Player properties
            Score.PlayerWins = "Wins:";
            Player.Result = "";
            Player.ResultColor = "";

            //reset Simon properties
            Score.SimonWins = "Wins:";
            Simon.Result = "";
            Simon.ResultColor = "";

            Score.Round = "Round:";

            //reset local variables
            simonWins = 0;
            playerWins = 0;
            roundCount = 0;
        }

        private void SetGameBoard()
        {   
            //method to reset the game board colors between rounds
            Buttons.Red = "DarkRed";
            Buttons.Yellow = "DarkGoldenrod";
            Buttons.Green = "Green";
            Buttons.Blue = "Blue";
        }


        // ****************
        // Game Initialize
        //*****************
        public GameViewModel()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            //instanciate models 
            _player = new Player();
            _buttons = new Buttons();
            _simon = new Simon();
            _score = new Score();

            //random number used for Simon
            _random = new Random();

            // method call to reset the game. 
            NewGameSet();

            //First time game opened display messgae in the name field. 
            Player.Name = "Enter Name";
        }

    }
}
