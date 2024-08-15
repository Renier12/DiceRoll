namespace Dice_roll;

public partial class DRoll : ContentPage
{
	public DRoll()
	{
		InitializeComponent();
	}

    async void ButtonClicked(object sender, EventArgs e)
    {
		await LabelOut.RelRotateTo(360, 1000);
		LabelOut.Text = "Spin?";

    }
}