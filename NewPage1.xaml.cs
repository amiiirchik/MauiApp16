using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace MauiApp16;

public partial class NewPage1 : Popup
{
	public NewPage1()
	{
		InitializeComponent();
	}

	private void ClosePopup(object sender, EventArgs e)
	{
        Close(true);
    }

    private void CloseApp(object sender, EventArgs e)
	{
		Application.Current.Quit();
	}
}