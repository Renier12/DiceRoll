using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dice_roll;

public partial class DRoll : ContentPage
{
	public DRoll()
	{
		InitializeComponent();
	}

    private int number1 = 2;
    Random randomNumber = new Random();

    public int RandomNumber(int givenNumber)
    {
        givenNumber = randomNumber.Next(1, givenNumber);
        return givenNumber;
    }



    async void ButtonClicked(object sender, EventArgs e)
    {
        if (RadioButtonD4.IsChecked == true)
        {
            number1 = 4;
        } else if (RadioButtonD6.IsChecked == true)
        {
            number1 = 6;
        }else if (RadioButtonD8.IsChecked == true)
        {
            number1 = 8;
        }else if (RadioButtonD12.IsChecked == true)
        {
            number1 = 12;
        }else if (RadioButtonD20.IsChecked == true)
        {
            number1 = 20;
        }

        LabelOut.Text = RandomNumber(number1).ToString(); ;

    }
}