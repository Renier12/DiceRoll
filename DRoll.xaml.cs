using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dice_roll;

public partial class DRoll : ContentPage
{
	public DRoll()
	{
		InitializeComponent();
	}

    private int dice1Result;
    private int dice2Result;
    private int dice3Result;
    private int dice4Result;
    private int diceSumResult;
    private double diceD10Result;

    Random randomNumber = new Random();

    private int RandomNumber(int givenNumber)
    {
        int returnNumber;
        //givenNumber is incremented to adjust range
        returnNumber = randomNumber.Next(1, givenNumber+1);
        return returnNumber;
    }



    private void ButtonClicked(object sender, EventArgs e)
    {
        diceSumResult = 0;

        if(checkBoxDice1.IsChecked)
        {
            LabelOutDice1.IsVisible = true;
            dice1Result = RandomNumber(Convert.ToInt32(PickerDice1.SelectedItem));
            diceSumResult += dice1Result;
            LabelOutDice1.Text = "Dice 1: " + dice1Result.ToString() + " ";
        }
        else 
        {
            LabelOutDice1.IsVisible = false;
        }
        if(checkBoxDice2.IsChecked)
        {
            LabelOutDice2.IsVisible = true;
            dice2Result = RandomNumber(Convert.ToInt32(PickerDice2.SelectedItem));
            diceSumResult += dice2Result;
            LabelOutDice2.Text = "Dice 2: " + dice2Result.ToString() + " ";
        }
        else
        {
            LabelOutDice2.IsVisible = false;
        }
        if (checkBoxDice3.IsChecked)
        {
            LabelOutDice3.IsVisible = true;
            dice3Result = RandomNumber(Convert.ToInt32(PickerDice3.SelectedItem));
            diceSumResult += dice3Result;
            LabelOutDice3.Text = "Dice 3: " + dice3Result.ToString() + " ";
        }
        else
        {
            LabelOutDice3.IsVisible = false;
        }
        if (checkBoxDice4.IsChecked)
        {
            LabelOutDice4.IsVisible = true;
            dice4Result = RandomNumber(Convert.ToInt32(PickerDice4.SelectedItem));
            diceSumResult += dice4Result;
            LabelOutDice4.Text = "Dice 4: " + dice4Result.ToString() + " ";
        }
        else
        {
            LabelOutDice4.IsVisible = false;
        }
        if (checkBoxDiceD10.IsChecked)
        {
            LabelOutDiceD10.IsVisible = true;
            diceD10Result = RandomNumber(Convert.ToInt32(PickerDiceD10.SelectedItem));
            LabelOutDiceD10.Text = "D10: " + diceD10Result.ToString() + " OR " + (diceD10Result*10).ToString() + "%";
        }
        else
        {
            LabelOutDiceD10.IsVisible = false;
        }
        LabelOutSum.Text = "Sum of dice rolled: " + diceSumResult.ToString();
    }

#region Update UI
    private void checkBoxDice1CheckedChanged(object sender, EventArgs e)
    {
        if(checkBoxDice1.IsChecked == true)
        {
            PickerDice1.IsEnabled = true;
            PickerDice1.SelectedItem = 6;            
        }
        else
        {
            PickerDice1.IsEnabled = false;            
        }        
    }
    private void checkBoxDice2CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxDice2.IsChecked == true)
        {
            PickerDice2.IsEnabled = true;
            PickerDice2.SelectedItem = 6;            
        }
        else
        {
            PickerDice2.IsEnabled = false;
        }
    }
    private void checkBoxDice3CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxDice3.IsChecked == true)
        {
            PickerDice3.IsEnabled = true;
            PickerDice3.SelectedItem = 6;
        }
        else
        {
            PickerDice3.IsEnabled = false;
        }
    }
    private void checkBoxDice4CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxDice4.IsChecked == true)
        {
            PickerDice4.IsEnabled = true;
            PickerDice4.SelectedItem = 20;
        }
        else
        {
            PickerDice4.IsEnabled = false;
        }
    }
    private void checkBoxDiceD10CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxDiceD10.IsChecked == true)
        {
            PickerDiceD10.IsEnabled = true;
            PickerDiceD10.SelectedItem = 10;
        }
        else
        {
            PickerDiceD10.IsEnabled = false;
        }
    }
#endregion Update UI

}