using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dice_roll;

public partial class DRoll : ContentPage
{
	public DRoll()
	{
		InitializeComponent();
	}

    private int selectedDiceSize = 0;
    private int diceResult = 0;
    private double diceRselutPerc = 0;
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
            selectedDiceSize = 4;
        } else if (RadioButtonD6.IsChecked == true)
        {
            selectedDiceSize = 6;
        }else if (RadioButtonD8.IsChecked == true)
        {
            selectedDiceSize = 8;
        }else if (RadioButtonD10.IsChecked == true)
        {
            selectedDiceSize = 10;
        }else if (RadioButtonD12.IsChecked == true)
        {
            selectedDiceSize = 12;
        }
        else if (RadioButtonD20.IsChecked == true)
        {
            selectedDiceSize = 20;
        }

        //Increment number1 to generat a rndom number between 0 and the upper boundry
        selectedDiceSize++;
        diceResult = RandomNumber(selectedDiceSize);

        LabelOut.Text = diceResult.ToString();

        //Had to do the following code in multiple lines. For some reason I got 0 when doing all in 1 line.
        selectedDiceSize--;
        diceResult = diceResult * 100;
        diceRselutPerc = diceResult / selectedDiceSize;

        LabelOutPerc.Text = (diceRselutPerc).ToString();

    }
}