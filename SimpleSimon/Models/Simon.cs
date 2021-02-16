using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSimon.Models
{
    public class Simon : ObservableObject
    {
        private string _result;
        private string _resultColor;
       
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
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
    }
}
