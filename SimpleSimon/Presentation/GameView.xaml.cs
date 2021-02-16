using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleSimon.Presentation
{
    /// <summary>
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : Window
    {
        GameViewModel _gameViewModel;

        public GameView()
        {
            _gameViewModel = new GameViewModel();

            DataContext = _gameViewModel;

            InitializeComponent();
        }

        private void Button_Click_Red(object sender, RoutedEventArgs e)
        {
            _gameViewModel.RedClick();
        }

        private void button_yellow_Click(object sender, RoutedEventArgs e)
        {
            _gameViewModel.YellowClick();

        }
        private void Button_Click_Green(object sender, RoutedEventArgs e)
        {
            _gameViewModel.GreenClick();
        }
        private void Button_Click_Blue(object sender, RoutedEventArgs e)
        {
            _gameViewModel.BlueClick();
        }

        private void Button_Enter_Click(object sender, RoutedEventArgs e)
        {

            bool allCharactersInStringAreDigits = textBox_Value.Text.Any(char.IsDigit);

            if (allCharactersInStringAreDigits == true)
            {
                textBox_Value.Text = "Letters Only!";
                _gameViewModel.NewGameSet();
            }

            else
            {
                _gameViewModel.Player.Name = textBox_Value.Text;
                textBox_Value.Text = "";
                _gameViewModel.NewGameSet();

            }

            

          
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_New_Game_Click(object sender, RoutedEventArgs e)
        {
            _gameViewModel.NewGameSet();
        }

        private void Button_HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }
    }

    
}
