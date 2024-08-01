using System.Reflection;

namespace MauiSample;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private void ShowPasswordButton_Clicked(object sender, EventArgs e)
	{
		//var imageIconView = ((Grid)sender.Parent)
		//							.FindByName<Image>(IconImageName);
		//var entryPasswordView = ((Grid)sender.Parent)
		//						.FindByName<Entry>(EntryPasswordName);
		//var entryTextView = ((Grid)sender.Parent)
		//						.FindByName<Entry>(EntryTextName);

		// Switch visibility of Password Entry field and Text Entry fields
		EntryPassword.IsVisible = !EntryPassword.IsVisible;
		EntryText.IsVisible = !EntryText.IsVisible;

		// update the Show/Hide button Icon states 
		if (EntryPassword.IsVisible)
		{
			// Password is not Visible state
			ShowPasswordButtonIcon.Source = ImageSource.FromFile(
				"showpasswordicon.png");

			// Setting up Entry curser focus
			EntryPassword.Focus();
			EntryPassword.Text = EntryText.Text;
		}
		else
		{
			// Password is Visible state
			ShowPasswordButtonIcon.Source = ImageSource.FromFile(
				"hidepasswordicon.png");

			// Setting up Entry curser focus
			EntryText.Focus();
			EntryText.Text = EntryPassword.Text;
		}
	}
}

