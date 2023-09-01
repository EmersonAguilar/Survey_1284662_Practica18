using Survey_1284662.Models;

namespace Survey_1284662.Views;

public partial class SurverDetailsView : ContentPage
{

    private readonly string[] teams =
    {
        "Alianza Lima",
        "América",
        "Boca juniors",
        "Caracas FC",
        "Colo-Colo",
        "Peñarol",
        "Real Madrid",
        "Saprissa"
    };

	public SurverDetailsView()
	{
		InitializeComponent();
	}


    private async void FavoriteTeamButton_Clicked(object sender, EventArgs e)
    {
        var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTEamTitle, null, null, teams);
        if (!string.IsNullOrWhiteSpace(favoriteTeam))
        {
            FavoriteTeamLabel.Text = favoriteTeam;
        }
    }

    private async void OkButton_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
        {
            return;
        }

        var newSurvey = new surveys()
        {
            Name = NameEntry.Text,
            Birthdate = BirthdataPicker.Date,
            FavoriteTeam = FavoriteTeamLabel.Text
        };

        MessagingCenter.Send((ContentPage)this,
            Messages.NewSurveyComplete, newSurvey);

        await Navigation.PopAsync();
    }
}