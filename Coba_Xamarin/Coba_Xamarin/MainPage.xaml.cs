using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Coba_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            valueLabel.Text = ((Slider)sender).Value.ToString("F3");
        }

        async void OnButtonClicked(Object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked", " The button labelid'" + button.Text + "'has been clicked '", "OK");
        }
    }

   
}
