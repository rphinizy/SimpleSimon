using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSimon.Models
{
    public class Buttons : ObservableObject
    {
        private string _red;
        private string _yellow;
        private string _green;
        private string _blue;

        public string Blue
        {
            get { return _blue; }
            set { 
                _blue = value;
                OnPropertyChanged(nameof(Blue));
            }
        }


        public string Green
        {
            get { return _green; }
            set {
                _green = value;
                OnPropertyChanged(nameof(Green));
            }
        }


        public string Yellow
        {
            get { return _yellow; }
            set { 
                _yellow = value;
                OnPropertyChanged(nameof(Yellow));
            }
        }


        public string Red
        {
            get { return _red; }
            set
            {
                _red = value;
                OnPropertyChanged(nameof(Red));
            }
        }

    }

   

}
