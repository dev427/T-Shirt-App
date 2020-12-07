using System;
using Xamarin.Forms;

namespace LocalDatabaseTutorial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(sizeEntry.Text))
            {
                Person newPerson = new Person();
                newPerson.Name = nameEntry.Text;
                newPerson.Size = int.Parse(sizeEntry.Text);
                newPerson.Gender = genderEntry.Text;
                newPerson.Color = colorEntry.Text;
                newPerson.Address = addressEntry.Text;
                await App.Database.SavePersonAsync(newPerson);

                
                listView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
    }
}
