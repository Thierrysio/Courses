using Courses.Modeles;
using Microsoft.Extensions.Logging.Abstractions;

namespace Courses.Vues;

public partial class ListingPage : ContentPage
{
	public ListingPage()
	{
		InitializeComponent();

        listViewCoureurs.ItemsSource = Coureur.CollClasse; // Assurez-vous que la classe Coureur a une collection statique appelée CollClasse.

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

    }

    
}