using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TicTacToe
{
    public partial class MainPage : ContentPage
    {

        GameEngine engine = new GameEngine();
        List<char> firstList = new List<char>();
        bool firstPlayer = true;
        List<char> secondList = new List<char>();
        private int squareCounter = 0;
        private char[] winningResult;

        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            squareCounter++;
            Button clickedButton = (Button)sender;
            if (firstPlayer)
            {
                clickedButton.Text = "X";
                //clickedButton.IsEnabled = false;

                firstList.Add(clickedButton.ClassId[0]);
                firstPlayer = false;
                winningResult = engine.CheckIfWon(firstList);
            }
            else
            {
                clickedButton.Text = "O";
                //clickedButton.IsEnabled = false;

                secondList.Add(clickedButton.ClassId[0]);
                firstPlayer = true;
                winningResult = engine.CheckIfWon(secondList);
            }

            if (winningResult != null)
            {

                ResultLbl.IsVisible = true;
                replayBtn.IsVisible = true;
                closeBtn.IsVisible = true;
                ColorWinningButtons(winningResult);
                DisableButtonClicks(Button1, Button2, Button3, Button4, Button5,
                                    Button6, Button7, Button8, Button9);

            }

            if (squareCounter == 9) //An gemisei to tablo xwris nikiti
            {
                ResultLbl.Text = "NO WINNER!\nPlay again?";
                ResultLbl.IsVisible = true;
                replayBtn.IsVisible = true;
                closeBtn.IsVisible = true;
            }
        }

        private void CloseBtn_OnClicked(object sender, EventArgs e)
        {
            if (Device.OS == TargetPlatform.Android)
            {
                DependencyService.Get<ICloseApp>().Close_App();
            }
        }
        private void DisableButtonClicks(Button btn1, Button btn2, Button btn3, Button btn4,
                                         Button btn5, Button btn6, Button btn7, Button btn8,
                                         Button btn9)
        {
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
        }
        private void ReplayBtn_OnClicked(object sender, EventArgs e)
        {
            squareCounter = 0;
            firstList.Clear();
            secondList.Clear();
            InitializeComponent(); //comment
        }

        public void ColorWinningButtons(char[] result) //3 theseis 1-9
        {
            foreach (var position in result)
            {
                switch (position)
                {
                    case '1':
                        Button1.BackgroundColor = Color.Chartreuse;
                        break;
                    case '2':
                        Button2.BackgroundColor = Color.Chartreuse;
                        break;
                    case '3':
                        Button3.BackgroundColor = Color.Chartreuse;
                        break;
                    case '4':
                        Button4.BackgroundColor = Color.Chartreuse;
                        break;
                    case '5':
                        Button5.BackgroundColor = Color.Chartreuse;
                        break;
                    case '6':
                        Button6.BackgroundColor = Color.Chartreuse;
                        break;
                    case '7':
                        Button7.BackgroundColor = Color.Chartreuse;
                        break;
                    case '8':
                        Button8.BackgroundColor = Color.Chartreuse;
                        break;
                    case '9':
                        Button9.BackgroundColor = Color.Chartreuse;
                        break;
                }
            }
        }
    }
}
