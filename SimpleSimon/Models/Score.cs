using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSimon.Models
{
    public class Score : ObservableObject
    {
        private string _round;
        private string _playerWins;
        private string _simonWins;


        public string Round
        {
            get { return _round; }
            set
            {
                _round = value;
                OnPropertyChanged(nameof(Round));
            }
        }


        public string PlayerWins
        {
            get { return _playerWins; }
            set
            {
                _playerWins = value;
                OnPropertyChanged(nameof(PlayerWins));
            }
        }


        public string SimonWins
        {
            get { return _simonWins; }
            set
            {
                _simonWins = value;
                OnPropertyChanged(nameof(SimonWins));
            }
        }

    }
}
