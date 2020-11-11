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
        DatePicker dateP;
        Editor edi, sign;
        Image img;
        DateTime aries = new DateTime(21 / 03);
        DateTime ariesend = new DateTime(19 / 04);
        System.DateTime moment = new System.DateTime();
        DatePicker datePicker;
        Image image;
        Entry etryyy;
        public varian2()
        {
            /*
            dateP = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now.AddYears(30),
                MinimumDate = DateTime.Now.AddYears(-90)
            };



            edi = new Editor
            {
                IsReadOnly = true
            };
            dateP.DateSelected += DateP_DateSelected;
            StackLayout stack = new StackLayout { Children = { dateP, edi } };
            this.Content = stack;

            private void DateP_DateSelected(object sender, DateChangedEventArgs e)
		{

			if (e.NewDate.Month>=3 && e.NewDate.Day <= 21 && e.NewDate.Month<=4 && e.NewDate.Day <= 19)
			{
				edi.Text = "asfdsadfdsf";
			}
			/*
			if (e.NewDate>=aries && e.NewDate<=ariesend)
			{
				edi.Text = "Aries";
			}
			edi.Text = e.NewDate.ToString("dd/MM");
			if (edi.Text>=("21/03"))
			{
				edi.Text = "Aries";
			}*/
			//edi.Text = e.NewDate.ToString("dd/MM");
			
            /*InitializeComponent();*/
            Grid griidd = new Grid();//
            ColumnDefinition colDef1 = new ColumnDefinition();//Это наиболее мощный и часто используемый контейнер, напоминающий обычную таблицу.Он содержит столбцы и строки, количество которых задает разработчик. Для определения строк используется свойство RowDefinitions, а для определения столбцов - свойство ColumnDefinitions:
            ColumnDefinition colDef2 = new ColumnDefinition();//Столбец Определение
            griidd.ColumnDefinitions.Add(colDef1);//столбцы
            griidd.ColumnDefinitions.Add(colDef2);
            RowDefinition rowDef1 = new RowDefinition();//Он содержит столбцы и строки, количество которых задает разработчик. Для определения строк используется свойство RowDefinitions
            RowDefinition rowDef2 = new RowDefinition();//Он содержит столбцы и строки, количество которых задает разработчик.Для определения строк используется свойство RowDefinitions
            griidd.RowDefinitions.Add(rowDef1);
            griidd.RowDefinitions.Add(rowDef2);

            datePicker = new DatePicker
            {
                BackgroundColor = Color.LightGray,
                Format = "D",
            };
            datePicker.DateSelected += DataPicker_DateSelected;
            griidd.Children.Add(datePicker, 0, 0);
            etryyy = new Entry
            {
                BackgroundColor = Color.LightBlue,
                Text = "Teie Tähtkuju/Ваш знак зодиака",
            };
            griidd.Children.Add(etryyy, 0, 1);
            Grid.SetColumnSpan(etryyy, 2);


            image = new Image();
            image.Source = "oven.png";
            image.Source = "telets.png";
            image.Source = "bliznisi.png";
            image.Source = "rak.jpg";
            image.Source = "lev.png";
            image.Source = "deva.png";
            image.Source = "vesi.png";
            image.Source = "skorpion.png";
            image.Source = "strelets.png";
            image.Source = "kozerog.png";
            image.Source = "vodolei.png";
            image.Source = "riba.png";
            griidd.Children.Add(image, 1, 0);

            Content = griidd;
        }

        private void DataPicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            etryyy.Text = "Teie Tähtkuju/Ваш знак зодиака:\n" + e.NewDate.ToString("d");
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
    }
}