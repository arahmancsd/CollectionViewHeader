using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewHeader;

public partial class Page3 : ContentPage
{
    public Page3()
    {
        InitializeComponent();
        BindingContext = new Page3ViewModel();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.DisplayAlert("Alert", "You have double tapped the item", "OK");
    }
}

public sealed partial class Page3ViewModel : ObservableObject
{
    public ObservableCollection<Person> People { get; private set; } = [];

    public Page3ViewModel()
    {
        AddPersons();
    }

    [ObservableProperty]
    private Person selectedPerson = new(1, $"Random Person 1");

    private void AddPersons()
    {
        for (int index = 1; index < 100; index++)
        {
            People.Add(new Person(Id: index, Name: $"Random Person {index}"));
        }
    }
}