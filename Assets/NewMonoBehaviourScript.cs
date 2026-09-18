using System;

using UnityEngine;

using UnityEngine.UI;




public class ShuffleCode : MonoBehaviour

{

    int counter;




    // Puzzle buttons (16 tiles: 1–15 plus empty slot)

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




    // UI controls

    public Text btnNumOfClicks;

    public Text txtDisplayWinning;




    // --- Shuffle Logic ---

    public void Shuffle()

    {

        int[] bnum = new int[16];

        int i = 1, j, rowchecker;

        bool flag;




        do

        {

            flag = false;

            rowchecker = UnityEngine.Random.Range(1, 16);




            for (j = 1; j < i; j++)

            {

                if (bnum[j] == rowchecker)

                {

                    flag = true;

                    break;

                }

            }




            if (!flag)

            {

                bnum[i] = rowchecker;

                i++;

            }




        } while (i <= 15);




        // Assign shuffled values to buttons

        btnText1.text = Convert.ToString(bnum[1]);

        btnText2.text = Convert.ToString(bnum[2]);

        btnText3.text = Convert.ToString(bnum[3]);

        btnText4.text = Convert.ToString(bnum[4]);

        btnText5.text = Convert.ToString(bnum[5]);

        btnText6.text = Convert.ToString(bnum[6]);

        btnText7.text = Convert.ToString(bnum[7]);

        btnText8.text = Convert.ToString(bnum[8]);

	btnText9.text = Convert.ToString(bnum[9]);

	btnText10.text = Convert.ToString(bnum[10]);

	btnText11.text = Convert.ToString(bnum[11]);

	btnText12.text = Convert.ToString(bnum[12]);

	btnText13.text = Convert.ToString(bnum[13]);

	btnText14.text = Convert.ToString(bnum[14]);

	btnText15.text = Convert.ToString(bnum[15]);







        btnText16.text = ""; // empty slot

        counter = 0;

        btnNumOfClicks.text = "Moves: 0";

        txtDisplayWinning.text = "";

    }




    // --- Empty Spot Checker ---

    public void EmptySpotChecker(Text Button1, Text Button2)

    {

        if (Button2.text == "")

        {

            Button2.text = Button1.text;

            Button1.text = "";

            counter++;

            btnNumOfClicks.text = "Moves: " + counter;

        }

    }




    // --- Solution Checker ---

    public void SolutionChecker()

    {

        if (btnText1.text == "1" && btnText2.text == "2" &&

            btnText3.text == "3" && btnText4.text == "4" &&

            btnText5.text == "5" && btnText6.text == "6" &&

            btnText7.text == "7" && btnText8.text == "8" &&

	    btnText9.text == "9" && btnText10.text == "10" &&

	    btnText11.text == "11" && btnText12.text == "12" &&

	    btnText13.text == "13" && btnText14.text == "14" &&

	    btnText15.text == "15" &&

	    

            btnText16.text == "")

        {

            txtDisplayWinning.text = "🎉 Well done, you are a winner!";

        }

    }




    // --- Button Click Events (neighbors in 4×4 grid) ---

    public void btnText1_Click()

    {

        EmptySpotChecker(btnText1, btnText2);

        EmptySpotChecker(btnText1, btnText5);

        SolutionChecker();

    }




    public void btnText2_Click()

    {

        EmptySpotChecker(btnText2, btnText1);

        EmptySpotChecker(btnText2, btnText3);

        EmptySpotChecker(btnText2, btnText6);

        SolutionChecker();

    }




    public void btnText3_Click()

    {

        EmptySpotChecker(btnText3, btnText2);

        EmptySpotChecker(btnText3, btnText4);

        EmptySpotChecker(btnText3, btnText7);

        SolutionChecker();

    }




    public void btnText4_Click()

    {

        EmptySpotChecker(btnText4, btnText3);

        EmptySpotChecker(btnText4, btnText8);

        

        SolutionChecker();

    }




    public void btnText5_Click()

    {

        EmptySpotChecker(btnText5, btnText1);

        EmptySpotChecker(btnText5, btnText6);

        EmptySpotChecker(btnText5, btnText9);

        

        SolutionChecker();

    }




    public void btnText6_Click()

    {

        EmptySpotChecker(btnText6, btnText2);

        EmptySpotChecker(btnText6, btnText5);

        EmptySpotChecker(btnText6, btnText7);

        EmptySpotChecker(btnText6, btnText10);




        SolutionChecker();

    }




    public void btnText7_Click()

    {

        EmptySpotChecker(btnText7, btnText3);

        EmptySpotChecker(btnText7, btnText6);

 	EmptySpotChecker(btnText7, btnText8);

        EmptySpotChecker(btnText7, btnText11);




        SolutionChecker();

    }




    public void btnText8_Click()

    {

        EmptySpotChecker(btnText8, btnText4);

        EmptySpotChecker(btnText8, btnText7);

        EmptySpotChecker(btnText8, btnText12);

        SolutionChecker();

    }




    public void btnText9_Click()

    {

        EmptySpotChecker(btnText9, btnText5);

        EmptySpotChecker(btnText9, btnText10);

	EmptySpotChecker(btnText9, btnText13);

        SolutionChecker();

    }

     public void btnText10_Click()

    {

        EmptySpotChecker(btnText10, btnText6);

        EmptySpotChecker(btnText10, btnText9);

	EmptySpotChecker(btnText10, btnText11);

	EmptySpotChecker(btnText10, btnText14);

        SolutionChecker();

    }

     public void btnText11_Click()

    {

        EmptySpotChecker(btnText11, btnText7);

        EmptySpotChecker(btnText11, btnText10);

	EmptySpotChecker(btnText11, btnText12);

        EmptySpotChecker(btnText11, btnText15);

        SolutionChecker();

    }

     public void btnText12_Click()

    {

        EmptySpotChecker(btnText12, btnText8);

        EmptySpotChecker(btnText12, btnText11);

	EmptySpotChecker(btnText12, btnText16);

        SolutionChecker();

    }

     public void btnText13_Click()

    {

        EmptySpotChecker(btnText13, btnText9);

        EmptySpotChecker(btnText13, btnText14);

	

        SolutionChecker();

    }

     public void btnText14_Click()

    {

        EmptySpotChecker(btnText14, btnText15);

        EmptySpotChecker(btnText14, btnText14);

	EmptySpotChecker(btnText14, btnText13);

        SolutionChecker();

     

    }




	  public void btnText15_Click()

    {

        EmptySpotChecker(btnText15, btnText11);

        EmptySpotChecker(btnText15, btnText14);

	EmptySpotChecker(btnText15, btnText16);

        SolutionChecker();

    }

}