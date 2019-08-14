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

            buttonAdd.Clicked += ButtonAddClicked;

            buttonClear.Clicked += ButtonClearClicked;
        }

        private void ButtonAddClicked(object sender, EventArgs e)
        {
            Entry newEntry = new Entry
            {
                Placeholder = "Enter input here",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            newEntry.SetBinding(Entry.TextProperty, "InputValue");

            layout.Children.Add(newEntry);
        }

        private void ButtonClearClicked(object sender, EventArgs e)
        {
            layout.Children.Clear();
        }
    }
}
