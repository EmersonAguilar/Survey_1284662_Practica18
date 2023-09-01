using Survey_1284662.Models;
using Survey_1284662.Views;

namespace Survey_1284662.Views;

public partial class SurveysView : ContentPage
{
	public SurveysView()
	{
		InitializeComponent();
		MessagingCenter.Subscribe<ContentPage, surveys>(this, Messages.NewSurveyComplete, (sender, args) =>
		{
			SurveysPanel.Children.Add(new Label() { Text = args.ToString() });
		});
	}

    private async void AddSurveyButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new SurverDetailsView());
    }
}