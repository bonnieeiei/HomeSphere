﻿namespace HomeSphere;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnLoginClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Home());
	}
}

