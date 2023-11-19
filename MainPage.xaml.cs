using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewHeader;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}
}

public sealed partial class MainPageViewModel : ObservableObject
{
	public ObservableCollection<Person> People { get; private set; } = [];

	public MainPageViewModel()
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

public sealed record Person(int Id, string Name, string ImageName = "dotnet_bot.png");