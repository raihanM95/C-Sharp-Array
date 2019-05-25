using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    
    public partial class ArrayForm : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int index;
        int position;

        public ArrayForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message = "";

            for(int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "Index: " + "[" + index + "]" + " Value: " + number[index] + "\n";
            }

            showRichTextBox.Text = message;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            number[index] = Convert.ToInt32(numberTextBox.Text);
            index++;

            string message = "";

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "Index: " + "[" + index + "]" + " Value: " + number[index] + "\n";
            }

            showRichTextBox.Text = message;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";

            for (int index = 9; index >= 0; index--)
            {
                if (number[index] != 0)
                    message = message + "Index: " + "[" + index + "]" + " Value: " + number[index] + "\n";
            }

            showRichTextBox.Text = message;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            string message = "";
            int sum = 0;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    sum += number[index];
            }
            message = Convert.ToString(sum);
            showRichTextBox.Text = message;
        }

        private void CopyArrayButton_Click(object sender, EventArgs e)
        {
            int[] numberCopy = new int[size];

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    numberCopy[index] = number[index];
            }

            string message = "";

            for (int index = 0; index < numberCopy.Length; index++)
            {
                if (numberCopy[index] != 0)
                    message = message + "Index: " + "[" + index + "]" + " Value: " + numberCopy[index] + "\n";
            }

            showRichTextBox.Text = message;
        }

        private void DuplicateShowButton_Click(object sender, EventArgs e)
        {
            string message = "";

            for (int index = 0; index < number.Length; index++)
            {
                for(int j = index; j < number.Length; j++)
                {
                    if (number[index] == number[j])
                    {
                        
                        break;
                    }
                    message = message + "Index: " + "[" + index + "]" + " Value du: " + number[index] + "\n";
                }
            }

            showRichTextBox.Text = message;
        }

        private void UniqueShowButton_Click(object sender, EventArgs e)
        {
            showRichTextBox.Clear();

            int counter = 0;
            int index, index2, index3; 
            showRichTextBox.SelectedText = "The unique elements found in the array are : \n";
            for (index = 0; index < number.Length; index++)
            {
                counter = 0;

                /* check duplicate before the current position and
                increase counter by 1 if found.*/
                for (index2 = 0; index2 < index - 1; index2++)
                {
                    /* increment the counter when the seaarch value is duplicate.*/
                    if (number[index] == number[index2])
                    {
                        counter++;
                    }
                }
                /* check duplicate after the current position and
                  increase counter by 1 if found.*/
                for (index3 = index + 1; index3 < number.Length; index3++)
                {
                    /* increment the counter when the seaarch value is duplicate.*/
                    if (number[index] == number[index3])
                    {
                        counter++;
                    }
                }
                /* print the value of the current position of the array as unique value 
                when counter remain contains its initial value.*/
                if (counter == 0)
                {
                    showRichTextBox.SelectedText = number[index] + ", ";
                }
            }
        }

        private void MaxMinButton_Click(object sender, EventArgs e)
        {
            int max, min;
            max = number[0];
            min = number[0];
            string message = "";

            for (int index = 1; index < number.Length; index++)
            {
                if (number[index] > max)
                {
                    max = number[index];
                }
                if (number[index] < min)
                {
                    min = number[index];
                }
            }

            message = "Maximum element : " + max + "\n" + "Minimum element : " + min;
            showRichTextBox.Text = message;
        }

        private void EvenOddButton_Click(object sender, EventArgs e)
        {
            showRichTextBox.Clear();

            int[] even = new int[size];
            int[] odd = new int[size];
            int evenIndex = 0;
            int oddIndex = 0;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] % 2 == 0)
                {
                    even[evenIndex] = number[index];
                    evenIndex++;
                }
                else
                {
                    odd[oddIndex] = number[index];
                    oddIndex++;
                }
            }

            showRichTextBox.SelectedText = "The Even elements are : \n";
            for (index = 0; index < evenIndex; index++)
            {
                if (even[index] != 0)
                    showRichTextBox.SelectedText = even[index] + ", ";
            }

            showRichTextBox.SelectedText = "\nThe Odd elements are : \n";
            for (index = 0; index < oddIndex; index++)
            {
                showRichTextBox.SelectedText = odd[index] + ", ";
            }
        }

        private void AscDescButton_Click(object sender, EventArgs e)
        {
            showRichTextBox.Clear();

            int ascIndex, descIndex, temp;

            //ascending order

            for (int index = 0; index < number.Length; index++)
            {
                for (ascIndex = index + 1; ascIndex < number.Length; ascIndex++)
                {
                    if (number[ascIndex] < number[index])
                    {
                        temp = number[index];
                        number[index] = number[ascIndex];
                        number[ascIndex] = temp;
                    }
                }
            }

            showRichTextBox.SelectedText = "\nElements of array in sorted ascending order:\n";
            for (ascIndex = 0; ascIndex < number.Length; ascIndex++)
            {
                if (number[ascIndex] != 0)
                    showRichTextBox.SelectedText = number[ascIndex] + ", ";
            }

            //descending order

            for (index = 0; index < number.Length; index++)
            {
                for (descIndex = index + 1; descIndex < number.Length; descIndex++)
                {
                    if (number[index] < number[descIndex])
                    {
                        temp = number[index];
                        number[index] = number[descIndex];
                        number[descIndex] = temp;
                    }
                }
            }

            showRichTextBox.SelectedText = "\nElements of array in sorted descending order:\n";
            for (descIndex = 0; descIndex < number.Length; descIndex++)
            {
                if (number[descIndex] != 0)
                    showRichTextBox.SelectedText = number[descIndex] + ", ";
            }
        }

        private void InsertNewValueButton_Click(object sender, EventArgs e)
        {
            /* insert new value in the array sorted list */
            showRichTextBox.Clear();

            int newValue = Convert.ToInt32(numberTextBox.Text);
            /* determine the position where the new value will be insert.*/
            for (index = 0; index < number.Length; index++)
            {
                if (newValue < number[index])
                {
                    position = index;
                    break;
                }
            }

            /* move all data at right side of the array */
            for (index = number.Length; index >= position; index--)
            {
                number[index] = number[index - 1];
            }

            /* insert value at the proper position */
            number[position] = newValue;

            showRichTextBox.SelectedText = "\n\nAfter Insert the list is :\n ";
            for (index = 0; index <= number.Length; index++)
                showRichTextBox.SelectedText = number[index] + "";
        }
    }
}
