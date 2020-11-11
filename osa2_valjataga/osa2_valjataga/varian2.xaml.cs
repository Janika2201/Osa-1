using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace osa2_valjataga
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class varian2 : ContentPage
    {
        Label label;
        DatePicker datePicker;
        public varian2()
        {
            InitializeComponent();
        }
        /*
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            label.Text = "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
            if (e.NewDate.ToString("dd/MM/yyyy") == "20/03/2021")
            {
                label.Text = "Овен";

                
            }
            if (e.NewDate.ToString("dd/MM/yyyy") == "21/04/2021")
            {
                label.Text = "Телец";
            }
            if (e.NewDate.ToString("dd/MM/yyyy") == "21/05/2021")
            {
                label.Text = "Близнецы";
                
            }
            if (e.NewDate.ToString("dd/MM/yyyy") == "21/06/2021")
            {
                label.Text = "Рак";
            }
        }
        */
        /*
        private void data_DateSelected_1(object sender, DateChangedEventArgs e)
        {
            label.Text = "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
            if (e.NewDate.ToString("dd/MM/yyyy") == "20/03/2021")
            {
                label.Text = "Овен";
                horos.Source = "oven.png";

            }

        }
        */

        private void changehoros_DateSelected(object sender, DateChangedEventArgs e)
        {
            label.Text =  e.NewDate.ToLongDateString();
            if (e.NewDate.ToString("dd/MM/yyyy") == "20/03/2021")
            {
                horos.Source = "oven.png";


            }
        }
    }
}