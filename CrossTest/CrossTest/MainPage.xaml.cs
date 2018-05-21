using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossTest
{
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 4).ToString();
        int scores = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text==bomb)
            {
               scores = 0;
               await DisplayAlert("Verdict", "Game Over", "Cancel");
               bomb = new Random().Next(1, 4).ToString();
            }
            else
            {
                scores++;
                await DisplayAlert("Keep Going","Scores"+scores,"Continue");
                bomb = new Random().Next(1, 4).ToString();
            }
        }

    }
}
