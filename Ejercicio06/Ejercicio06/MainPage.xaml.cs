using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio06
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new TapDemo());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new PinchDemo());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new PanDemo());
            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new SwipeDemo());
            };
        }
    }
}
