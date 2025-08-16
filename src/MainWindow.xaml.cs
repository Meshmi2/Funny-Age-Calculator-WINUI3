using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace FACWU3
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DatePicker_DateChanged(object sender, Microsoft.UI.Xaml.Controls.DatePickerValueChangedEventArgs e)

        {
            ArgumentNullException.ThrowIfNull(e);
            if (datePicker.Date != null)
            {
                DateTime selectedDate = datePicker.Date.DateTime;
                DateTime now = DateTime.Now;

                if (selectedDate > now)
                {
                    resultTextBlock.Text = "La data selezionata è nel futuro.";
                    return;
                }

                TimeSpan elapsed = now - selectedDate;
                // Funzione per Convertire datepicker in datetime
                TimeSpan timeSpan = new TimeSpan(elapsed.Days, elapsed.Hours, elapsed.Minutes, elapsed.Seconds);
                TimeSpan difference = timeSpan;

                int months = Convert.ToInt32(difference.TotalDays / 30);
                int days = Convert.ToInt32(timeSpan.TotalDays);
                int minutes = Convert.ToInt32(timeSpan.TotalMinutes);
                int hours = Convert.ToInt32(timeSpan.TotalHours);
                long seconds = Convert.ToInt64(timeSpan.TotalSeconds);

                resultTextBlock.Text = ("you have a..     " + months + "   months   " + days + "   days   " + hours + "   hours   " + minutes + "   minutes   " + seconds + "   second   !!!!!");
            }
            else
            {
                resultTextBlock.Text = "Per favore, seleziona una data valida.";
            }
        
        }
    }
}