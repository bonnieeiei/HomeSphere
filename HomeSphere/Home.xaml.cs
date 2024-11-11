namespace HomeSphere;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}
	private void OnRepairClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Repair());
	}
	private void OnParcelClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Parcel());
	}
}