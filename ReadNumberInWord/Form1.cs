using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * This program convert NUMBER (length <= 9) to WORDS. 
 * Author: Kevin Mac
 */
namespace ReadNumberInWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            
            int number = int.Parse(numInputTextBox.Text);
            int numberLength = numInputTextBox.Text.Length;
            if (number < 0)
            { 
                number *= -1;
                wordsTextBox.Text += "(Negative) ";
            }
            int hundredMillionth = number % 1000000000 / 100000000;
            int tenMillionth = number % 100000000 / 10000000;
            int millionth = number % 10000000 / 1000000;
            int hundredThousandth = number % 1000000 / 100000;
            int tenThousandth = number % 100000 / 10000;
            int thousandth = number % 10000 / 1000;
            int hundredth = number % 1000 / 100;
            int tenth = number % 100 / 10;
            int unit = number % 10;
            

            //------------------------Count = 9------------------------
            if (numberLength == 9)
            {
                if (hundredMillionth == 1)
                { wordsTextBox.Text += "One Hundred "; }
                else if (hundredMillionth == 2)
                { wordsTextBox.Text += "Two Hundred "; }
                else if (hundredMillionth == 3)
                { wordsTextBox.Text += "Three Hundred "; }
                else if (hundredMillionth == 4)
                { wordsTextBox.Text += "Four Hundred "; }
                else if (hundredMillionth == 5)
                { wordsTextBox.Text += "Five Hundred "; }
                else if (hundredMillionth == 6)
                { wordsTextBox.Text += "Six Hundred "; }
                else if (hundredMillionth == 7)
                { wordsTextBox.Text += "Seven Hundred "; }
                else if (hundredMillionth == 8)
                { wordsTextBox.Text += "Eight Hundred "; }
                else if (hundredMillionth == 9)
                { wordsTextBox.Text += "Nine Hundred "; }
                numberLength--;
                number %= 100000000;
            }
            //------------------------Length 8------------------------
            if (numberLength == 8)
            {
                if (tenMillionth > 1)
                { wordsTextBox.Text += "and "; }
                if (tenMillionth == 1 && millionth == 0)
                { wordsTextBox.Text += "Ten "; }
                else if (tenMillionth == 2)
                { wordsTextBox.Text += "Twenty "; }
                else if (tenMillionth == 3)
                { wordsTextBox.Text += "Thirty "; }
                else if (tenMillionth == 4)
                { wordsTextBox.Text += "Forty "; }
                else if (tenMillionth == 5)
                { wordsTextBox.Text += "Fifty "; }
                else if (tenMillionth == 6)
                { wordsTextBox.Text += "Sixty "; }
                else if (tenMillionth == 7)
                { wordsTextBox.Text += "Seventy "; }
                else if (tenMillionth == 8)
                { wordsTextBox.Text += "Eighty "; }
                else if (tenMillionth == 9)
                { wordsTextBox.Text += "Ninety "; }
                if (millionth == 0 && (tenMillionth != 0 || hundredMillionth != 0))
                { wordsTextBox.Text += "Million "; }
                numberLength--;
                number %= 10000000;

                if (tenMillionth == 1)
                {
                    if (millionth == 1)
                    { wordsTextBox.Text += "Eleven Million "; }
                    else if (millionth == 2)
                    { wordsTextBox.Text += "Twelve Million "; }
                    else if (millionth == 3)
                    { wordsTextBox.Text += "Thirteen Million "; }
                    else if (millionth == 4)
                    { wordsTextBox.Text += "Fourteen Million "; }
                    else if (millionth == 5)
                    { wordsTextBox.Text += "Fifteen Million "; }
                    else if (millionth == 6)
                    { wordsTextBox.Text += "Sixteen Million "; }
                    else if (millionth == 7)
                    { wordsTextBox.Text += "Seventeen Million "; }
                    else if (millionth == 8)
                    { wordsTextBox.Text += "Eighteen Million "; }
                    else if (millionth == 9)
                    { wordsTextBox.Text += "Nineteen Million "; }
                    numberLength--;
                    number %= 1000000;
                }
            }
            //------------------------Length 7------------------------
            if (numberLength == 7)
            {
                if (millionth == 1)
                { wordsTextBox.Text += "One Million "; }
                else if (millionth == 2)
                { wordsTextBox.Text += "Two Million "; }
                else if (millionth == 3)
                { wordsTextBox.Text += "Three Million "; }
                else if (millionth == 4)
                { wordsTextBox.Text += "Four Million "; }
                else if (millionth == 5)
                { wordsTextBox.Text += "Five Million "; }
                else if (millionth == 6)
                { wordsTextBox.Text += "Six Million "; }
                else if (millionth == 7)
                { wordsTextBox.Text += "Seven Million "; }
                else if (millionth == 8)
                { wordsTextBox.Text += "Eight Million "; }
                else if (millionth == 9)
                { wordsTextBox.Text += "Nine Million "; }
                numberLength--;
                number %= 1000000;
            }
            //------------------------Length 6------------------------
            if (numberLength == 6)
            {
                if (hundredThousandth == 1)
                { wordsTextBox.Text += "One Hundred "; }
                else if (hundredThousandth == 2)
                { wordsTextBox.Text += "Two Hundred "; }
                else if (hundredThousandth == 3)
                { wordsTextBox.Text += "Three Hundred "; }
                else if (hundredThousandth == 4)
                { wordsTextBox.Text += "Four Hundred "; }
                else if (hundredThousandth == 5)
                { wordsTextBox.Text += "Five Hundred "; }
                else if (hundredThousandth == 6)
                { wordsTextBox.Text += "Six Hundred "; }
                else if (hundredThousandth == 7)
                { wordsTextBox.Text += "Seven Hundred "; }
                else if (hundredThousandth == 8)
                { wordsTextBox.Text += "Eight Hundred "; }
                else if (hundredThousandth == 9)
                { wordsTextBox.Text += "Nine Hundred "; }
                numberLength--;
                number %= 100000;
            }
            //---------------------------------Length 5---------------------------------
            if (numberLength == 5)
            {
                if (tenThousandth > 1)
                { wordsTextBox.Text += "and "; }
                if (tenThousandth == 1 && thousandth == 0)
                { wordsTextBox.Text += "Ten "; }
                else if (tenThousandth == 2)
                { wordsTextBox.Text += "Twenty "; }
                else if (tenThousandth == 3)
                { wordsTextBox.Text += "Thirty "; }
                else if (tenThousandth == 4)
                { wordsTextBox.Text += "Forty "; }
                else if (tenThousandth == 5)
                { wordsTextBox.Text += "Fifty "; }
                else if (tenThousandth == 6)
                { wordsTextBox.Text += "Sixty "; }
                else if (tenThousandth == 7)
                { wordsTextBox.Text += "Seventy "; }
                else if (tenThousandth == 8)
                { wordsTextBox.Text += "Eighty "; }
                else if (tenThousandth == 9)
                { wordsTextBox.Text += "Ninety "; }
                if (thousandth == 0 && (tenThousandth != 0 || hundredThousandth != 0))
                { wordsTextBox.Text += "Thousand "; }
                numberLength--;
                number %= 10000;
                if (tenThousandth == 1)
                {
                    if (thousandth == 1)
                    { wordsTextBox.Text += "Eleven Thousand "; }
                    else if (thousandth == 2)
                    { wordsTextBox.Text += "Twelve Thousand "; }
                    else if (thousandth == 3)
                    { wordsTextBox.Text += "Thirteen Thousand "; }
                    else if (thousandth == 4)
                    { wordsTextBox.Text += "Fourteen Thousand "; }
                    else if (thousandth == 5)
                    { wordsTextBox.Text += "Fifteen Thousand "; }
                    else if (thousandth == 6)
                    { wordsTextBox.Text += "Sixteen Thousand "; }
                    else if (thousandth == 7)
                    { wordsTextBox.Text += "Seventeen Thousand "; }
                    else if (thousandth == 8)
                    { wordsTextBox.Text += "Eighteen Thousand "; }
                    else if (thousandth == 9)
                    { wordsTextBox.Text += "Nineteen Thousand "; }
                    numberLength--;
                    number %= 1000;
                }
            }
            //---------------------------------Length 4---------------------------------
            if (numberLength == 4)
            {
                if (thousandth == 1)
                { wordsTextBox.Text += "One Thousand "; }
                else if (thousandth == 2)
                { wordsTextBox.Text += "Two Thousand "; }
                else if (thousandth == 3)
                { wordsTextBox.Text += "Three Thousand "; }
                else if (thousandth == 4)
                { wordsTextBox.Text += "Four Thousand "; }
                else if (thousandth == 5)
                { wordsTextBox.Text += "Five Thousand "; }
                else if (thousandth == 6)
                { wordsTextBox.Text += "Six Thousand "; }
                else if (thousandth == 7)
                { wordsTextBox.Text += "Seven Thousand "; }
                else if (thousandth == 8)
                { wordsTextBox.Text += "Eight Thousand "; }
                else if (thousandth == 9)
                { wordsTextBox.Text += "Nine Thousand "; }
                numberLength--;
                number %= 1000;
            }
            //---------------------------------Length 3---------------------------------
            if (numberLength == 3)
            {
                if (hundredth == 1)
                { wordsTextBox.Text += "One hundred "; }
                else if (hundredth == 2)
                { wordsTextBox.Text += "Two hundred "; }
                else if (hundredth == 3)
                { wordsTextBox.Text += "Three hundred "; }
                else if (hundredth == 4)
                { wordsTextBox.Text += "Four hundred "; }
                else if (hundredth == 5)
                { wordsTextBox.Text += "Five hundred "; }
                else if (hundredth == 6)
                { wordsTextBox.Text += "Six hundred "; }
                else if (hundredth == 7)
                { wordsTextBox.Text += "Seven hundred "; }
                else if (hundredth == 8)
                { wordsTextBox.Text += "Eight hundred "; }
                else if (hundredth == 9)
                { wordsTextBox.Text += "Nine hundred "; }
                numberLength--;
                number %= 100;
            }
            //---------------------------------Length 2---------------------------------
            if (numberLength == 2)
            {
                if ((hundredMillionth > 0 || tenMillionth > 0 || millionth > 0 || 
                    hundredThousandth > 0 || tenThousandth > 0 || thousandth > 0 || 
                    hundredth > 0) && unit != 0)
                { wordsTextBox.Text += "and "; }
                if (tenth == 1)
                {
                    if (unit == 0)
                    { wordsTextBox.Text += "Ten"; }
                    else if (unit == 1)
                    { wordsTextBox.Text += "Eleven";}
                    else if (unit == 2)
                    { wordsTextBox.Text += "Twelve";}
                    else if (unit == 3)
                    { wordsTextBox.Text += "Thirteen";}
                    else if (unit == 4)
                    { wordsTextBox.Text += "Fourteen";}
                    else if (unit == 5)
                    { wordsTextBox.Text += "Fifteen";}
                    else if (unit == 6)
                    { wordsTextBox.Text += "Sixteen";}
                    else if (unit == 7)
                    { wordsTextBox.Text += "Seventeen";}
                    else if (unit == 8)
                    { wordsTextBox.Text += "Eighteen";}
                    else if (unit == 9)
                    { wordsTextBox.Text += "Nineteen";}
                    return;
                }
                else if (tenth == 2)
                { wordsTextBox.Text += "Twenty "; }
                else if (tenth == 3)
                { wordsTextBox.Text += "Thirty "; }
                else if (tenth == 4)
                { wordsTextBox.Text += "Forty "; }
                else if (tenth == 5)
                { wordsTextBox.Text += "Fifty "; }
                else if (tenth == 6)
                { wordsTextBox.Text += "Sixty "; }
                else if (tenth == 7)
                { wordsTextBox.Text += "Seventy "; }
                else if (tenth == 8)
                { wordsTextBox.Text += "Eightty "; }
                else if (tenth == 9)
                { wordsTextBox.Text += "Ninety "; }
                numberLength--;
            }
            //---------------------------------Length 1---------------------------------
            if (numberLength == 1)
            {
                if (unit == 1)
                { wordsTextBox.Text += "One "; }
                else if (unit == 2)
                { wordsTextBox.Text += "Two "; }
                else if (unit == 3)
                { wordsTextBox.Text += "Three "; }
                else if (unit == 4)
                { wordsTextBox.Text += "Four "; }
                else if (unit == 5)
                { wordsTextBox.Text += "Five "; }
                else if (unit == 6)
                { wordsTextBox.Text += "Six "; }
                else if (unit == 7)
                { wordsTextBox.Text += "Seven "; }
                else if (unit == 8)
                { wordsTextBox.Text += "Eight "; }
                else if (unit == 9)
                { wordsTextBox.Text += "Nine "; }
            }
            convertButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numInputTextBox.Clear();
            wordsTextBox.Clear();
            convertButton.Enabled = true;
        }
    }
}
