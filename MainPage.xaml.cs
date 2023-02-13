using CommunityToolkit;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Maui.Views;

namespace MauiApp16;

public partial class MainPage : ContentPage
{
	private int count = 1;

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_False(object sender, EventArgs e)
    {
		CreateToast();
    }

	private void Button_True(object sender, EventArgs e)
	{
		CreatePopup();
	}

	private void CreatePopup()       //Выиграли
	{
		Popup popup = new NewPage1();
		Random rnd = new Random();
		count = 0;
		int win = rnd.Next(4);
		this.ShowPopup(popup);
		for(int i = 0; i < vsl.Children.Count; i++)
		{
			if (i == win)
			{
				Button btn = vsl.Children[i] as Button;
                btn.Clicked += Button_True;
            }
			else
			{
				Button btn = vsl.Children[i] as Button;
				btn.Clicked += Button_False;
            }
		}
	}

	private void CreateToast()      //Проиграли
	{
		if(count > 3)
		{
			CreateSnackBar();
			return;
        }
        Toast toast = new Toast() { Text = "Не та кнопка, попробуйте еще раз", Duration = ToastDuration.Short, TextSize = 14 };
		count++;
		toast.Show();
		Thread.Sleep(1000);
	}

	private void CreateSnackBar()
	{
		Snackbar sb = (Snackbar)Snackbar.Make("Вы ошиблись слишком много раз, пора домой", () =>
		{
			Application.Current.Quit();
		}, "Ok", TimeSpan.FromSeconds(2), null, null);
		sb.Show();
		
	}
}