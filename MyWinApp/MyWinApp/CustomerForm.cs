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
    public partial class CustomerForm : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string user;
            string name;
            int age;

            try
            {
                if (String.IsNullOrEmpty(ageTextBox.Text))
                {
                    MessageBox.Show("Age is required");
                    return;
                }

                user = userTextBox.Text;
                name = nameTextBox.Text;
                age = Convert.ToInt32(ageTextBox.Text);

                users.Add(user);
                names.Add(name);
                ages.Add(age);

                showRichTextBox.Text = Display();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string Display()
        {
            string message = "";
            message = " SL\tUser\tName\tAge\n";

            for(int index = 0; index < users.Count; index++)
            {
                message = message + " " + (index + 1) + "\t" + users[index] + "\t" + names[index] + "\t" + ages[index] + "\n";
            }
            return message;
        }
    }
}
