using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPlayground
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            buttonSpeak.Clicked += ButtonSpeakClicked;
        }

        private void ButtonSpeakClicked(object sender, EventArgs e)
        {
            entryMessage.Text = "Button has been clicked";
        }
    }
}
