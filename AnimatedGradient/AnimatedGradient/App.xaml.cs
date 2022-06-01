using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimatedGradient
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Brush_Experimantal" }); //This is here because the Brush is still an experimantal component
            MainPage = new MainPage();                       //It's kind of just a disclaimer to the program
        } 

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
