using Courses.Modeles;
using Courses.Vues;

namespace Courses
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            // Récupération des valeurs depuis les champs du formulaire
            string nom = NomEntry.Text;
            string prenom = PrenomEntry.Text;
            DateTime dateDeNaissance = DateNaissancePicker.Date;
            var sexe = SexePicker.SelectedItem?.ToString();
            string email = EmailEntry.Text;
            string numeroTelephone = TelephoneEntry.Text;

            // Vous pouvez ajouter des validations pour vous assurer que les champs ne sont pas vides, etc.

            // Création d'un nouvel objet Coureur avec les informations récupérées
            new Coureur(nom, prenom, dateDeNaissance, sexe, email, numeroTelephone);
            new Coureur(nom, prenom, dateDeNaissance, sexe, email, numeroTelephone);


            await Navigation.PushAsync(new ListingPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Réinitialiser les contrôles
            NomEntry.Text = string.Empty;
            PrenomEntry.Text = string.Empty;
            DateNaissancePicker.Date = DateTime.Now;
            SexePicker.SelectedItem = null;
            EmailEntry.Text = string.Empty;
            TelephoneEntry.Text = string.Empty;
        }
    }
}