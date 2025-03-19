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

    private async void OnDoubleTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.DisplayAlert("Double Tap", "You have double tapped the item", "OK");
    }

    private async void OnSingleTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.DisplayAlert("Single Tap", "You have single tapped the item", "OK");
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

    partial void OnSelectedPersonChanged(Person value)
    {
        if (value is not null)
        {
            Console.WriteLine($"Selected Person: {value.Name}");
        }
    }

    private void AddPersons()
    {
        for (int index = 1; index < 100; index++)
        {
            People.Add(new Person(Id: index, Name: $"Random Person {index}"));
        }
    }
}