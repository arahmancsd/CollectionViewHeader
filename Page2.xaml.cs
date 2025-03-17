using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewHeader;

public partial class Page2 : ContentPage
{
    public Page2()
    {
        InitializeComponent();
        BindingContext = new Page2ViewModel();
    }
}

public sealed partial class Page2ViewModel : ObservableObject
{
    public ObservableCollection<Person> People { get; private set; } = [];

    public Page2ViewModel()
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