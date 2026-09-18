using System;
using UnityEngine;
using UnityEngine.UI;

public class ShuffleCode : MonoBehaviour
{
    int counter;

    public Text btnText1;
    public Text btnText2;
    public Text btnText3;
    public Text btnText4;
    public Text btnText5;
    public Text btnText6;
    public Text btnText7;
    public Text btnText8;
    public Text btnText9;
    public Text btnText10;
    public Text btnText11;
    public Text btnText12;
    public Text btnText13;
    public Text btnText14;
    public Text btnText15;
    public Text btnText16;

    public Text btnNumOfClicks;
    public Text txtDisplayWinning;

    public void Shuffle()
    {
        int[] numbers = new int[15];

        for (int i = 0; i < 15; i++)
        {
            numbers[i] = i + 1;
        }

        for (int i = 14; i > 0; i--)
        {
            int randomIndex = UnityEngine.Random.Range(0, i + 1);

            int temp = numbers[i];
            numbers[i] = numbers[randomIndex];
            numbers[randomIndex] = temp;
        }

        btnText1.text = numbers[0].ToString();
        btnText2.text = numbers[1].ToString();
        btnText3.text = numbers[2].ToString();
        btnText4.text = numbers[3].ToString();

        btnText5.text = numbers[4].ToString();
        btnText6.text = numbers[5].ToString();
        btnText7.text = numbers[6].ToString();
        btnText8.text = numbers[7].ToString();

        btnText9.text = numbers[8].ToString();
        btnText10.text = numbers[9].ToString();
        btnText11.text = numbers[10].ToString();
        btnText12.text = numbers[11].ToString();

        btnText13.text = numbers[12].ToString();
        btnText14.text = numbers[13].ToString();
        btnText15.text = numbers[14].ToString();

        btnText16.text = "";

        counter = 0;

        if (btnNumOfClicks != null)
            btnNumOfClicks.text = "Moves: 0";

        if (txtDisplayWinning != null)
            txtDisplayWinning.text = "";
    }

    public bool EmptySpotChecker(Text button1, Text button2)
    {
        if (button2.text == "")
        {
            button2.text = button1.text;
            button1.text = "";

            counter++;

            if (btnNumOfClicks != null)
                btnNumOfClicks.text = "Moves: " + counter;

            return true;
        }

        return false;
    }

    public void SolutionChecker()
    {
        if (btnText1.text == "1" &&
            btnText2.text == "2" &&
            btnText3.text == "3" &&
            btnText4.text == "4" &&
            btnText5.text == "5" &&
            btnText6.text == "6" &&
            btnText7.text == "7" &&
            btnText8.text == "8" &&
            btnText9.text == "9" &&
            btnText10.text == "10" &&
            btnText11.text == "11" &&
            btnText12.text == "12" &&
            btnText13.text == "13" &&
            btnText14.text == "14" &&
            btnText15.text == "15" &&
            btnText16.text == "")
        {
            if (txtDisplayWinning != null)
                txtDisplayWinning.text = "Result: Well done, you are a winner!";
        }
    }

    public void btnText1_Click()
    {
        if (EmptySpotChecker(btnText1, btnText2) ||
            EmptySpotChecker(btnText1, btnText5))
            SolutionChecker();
    }

    public void btnText2_Click()
    {
        if (EmptySpotChecker(btnText2, btnText1) ||
            EmptySpotChecker(btnText2, btnText3) ||
            EmptySpotChecker(btnText2, btnText6))
            SolutionChecker();
    }

    public void btnText3_Click()
    {
        if (EmptySpotChecker(btnText3, btnText2) ||
            EmptySpotChecker(btnText3, btnText4) ||
            EmptySpotChecker(btnText3, btnText7))
            SolutionChecker();
    }

    public void btnText4_Click()
    {
        if (EmptySpotChecker(btnText4, btnText3) ||
            EmptySpotChecker(btnText4, btnText8))
            SolutionChecker();
    }

    public void btnText5_Click()
    {
        if (EmptySpotChecker(btnText5, btnText1) ||
            EmptySpotChecker(btnText5, btnText6) ||
            EmptySpotChecker(btnText5, btnText9))
            SolutionChecker();
    }

    public void btnText6_Click()
    {
        if (EmptySpotChecker(btnText6, btnText2) ||
            EmptySpotChecker(btnText6, btnText5) ||
            EmptySpotChecker(btnText6, btnText7) ||
            EmptySpotChecker(btnText6, btnText10))
            SolutionChecker();
    }

    public void btnText7_Click()
    {
        if (EmptySpotChecker(btnText7, btnText3) ||
            EmptySpotChecker(btnText7, btnText6) ||
            EmptySpotChecker(btnText7, btnText8) ||
            EmptySpotChecker(btnText7, btnText11))
            SolutionChecker();
    }

    public void btnText8_Click()
    {
        if (EmptySpotChecker(btnText8, btnText4) ||
            EmptySpotChecker(btnText8, btnText7) ||
            EmptySpotChecker(btnText8, btnText12))
            SolutionChecker();
    }

    public void btnText9_Click()
    {
        if (EmptySpotChecker(btnText9, btnText5) ||
            EmptySpotChecker(btnText9, btnText10) ||
            EmptySpotChecker(btnText9, btnText13))
            SolutionChecker();
    }

    public void btnText10_Click()
    {
        if (EmptySpotChecker(btnText10, btnText6) ||
            EmptySpotChecker(btnText10, btnText9) ||
            EmptySpotChecker(btnText10, btnText11) ||
            EmptySpotChecker(btnText10, btnText14))
            SolutionChecker();
    }

    public void btnText11_Click()
    {
        if (EmptySpotChecker(btnText11, btnText7) ||
            EmptySpotChecker(btnText11, btnText10) ||
            EmptySpotChecker(btnText11, btnText12) ||
            EmptySpotChecker(btnText11, btnText15))
            SolutionChecker();
    }

    public void btnText12_Click()
    {
        if (EmptySpotChecker(btnText12, btnText8) ||
            EmptySpotChecker(btnText12, btnText11) ||
            EmptySpotChecker(btnText12, btnText16))
            SolutionChecker();
    }

    public void btnText13_Click()
    {
        if (EmptySpotChecker(btnText13, btnText9) ||
            EmptySpotChecker(btnText13, btnText14))
            SolutionChecker();
    }

    public void btnText14_Click()
    {
        if (EmptySpotChecker(btnText14, btnText10) ||
            EmptySpotChecker(btnText14, btnText13) ||
            EmptySpotChecker(btnText14, btnText15))
            SolutionChecker();
    }

    public void btnText15_Click()
    {
        if (EmptySpotChecker(btnText15, btnText11) ||
            EmptySpotChecker(btnText15, btnText14) ||
            EmptySpotChecker(btnText15, btnText16))
            SolutionChecker();
    }

    public void btnText16_Click()
    {
        if (EmptySpotChecker(btnText16, btnText12) ||
            EmptySpotChecker(btnText16, btnText15))
            SolutionChecker();
    }
}