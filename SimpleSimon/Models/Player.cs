using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSimon.Models
{
    public class Player : ObservableObject
    {
        private string _name;
        private string _result;
        private string _resultColor;
        private int _playerSays;


        public string Name
        {
            get { return _name; }
            set { 
                _name = value;
                OnPropertyChanged(nameof(Name));
                }
        }

        public string ResultColor
        {
            get { return _resultColor; }
            set
            {
                _resultColor = value;
                OnPropertyChanged(nameof(ResultColor));
            }
        }
        public string Result
        {
            get { return _result; }
            set { 
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public int PlayerSays
        {
            get { return _playerSays; }
            set
            {
                _playerSays = value;
                OnPropertyChanged(nameof(PlayerSays));
            }
        }

    }
}
