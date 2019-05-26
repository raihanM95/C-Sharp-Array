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
    public partial class ListForm : Form
    {
        List<int> numbers = new List<int>();
        List<string> names = new List<string>();

        public ListForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            numbers.Add(Convert.ToInt32(numberTextBox.Text));
            names.Add(nameTextBox.Text);

            string message = "Use for loop\n";

            for (int index = 0; index < numbers.Count; index++)
            {
                message = message + "Number: " + numbers[index] + ", Name: " + names[index] + "\n\n";
            }

            message = message + "Use foreach loop\n";

            int i = 0;
            foreach(int number in numbers)
            {
                message = message + "Number: " + number + ", Name: " + names[i] + "\n";
                i++;
            }

            showRichTextBox.Text = message;
        }
    }
}
