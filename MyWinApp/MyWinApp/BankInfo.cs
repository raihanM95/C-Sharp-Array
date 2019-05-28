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
    public partial class BankInfo : Form
    {
        List<string> users = new List<string>();
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<string> contacts = new List<string>();
        List<string> emails = new List<string>();
        List<string> addresses = new List<string>();
        List<string> accountsNo = new List<string>();
        List<int> amount = new List<int>();

        public BankInfo()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                checkUserLabel.Text = "";
                checkContactLabel.Text = "";
                checkEmailLabel.Text = "";
                checkAccountLabel.Text = "";

                string user = userNameTextBox.Text;
                string fName = firstNameTextBox.Text;
                string lName = lastNameTextBox.Text;
                string contact = contactNoTextBox.Text;
                string email = emailTextBox.Text;
                string address = addressTextBox.Text;
                string accountNo = accountNoTextBox.Text;

                if (String.IsNullOrEmpty(user))
                {
                    checkUserLabel.Text = "This field is required";
                    return;
                }
                else if (String.IsNullOrEmpty(contact))
                {
                    checkContactLabel.Text = "This field is required";
                    return;
                }
                else if (String.IsNullOrEmpty(email))
                {
                    checkEmailLabel.Text = "This field is required";
                    return;
                }
                else if (String.IsNullOrEmpty(accountNo))
                {
                    checkAccountLabel.Text = "This field is required";
                    return;
                }

                if (UserExists(user))
                {
                    checkUserLabel.Text = "Duplicate username found!";
                    return;
                }
                else if (ContactExists(contact))
                {
                    checkContactLabel.Text = "Duplicate contact found!";
                    return;
                }
                else if (EmailExists(email))
                {
                    checkEmailLabel.Text = "Duplicate email found!";
                    return;
                }
                else if (AccountNoExists(accountNo))
                {
                    checkAccountLabel.Text = "Duplicate account found!";
                    return;
                }

                users.Add(user);
                firstNames.Add(fName);
                lastNames.Add(lName);
                contacts.Add(contact);
                emails.Add(email);
                addresses.Add(address);
                accountsNo.Add(accountNo);

                showRichTextBox.Text = Display();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            showRichTextBox.Text = Display();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {

        }

        private void BalanceButton_Click(object sender, EventArgs e)
        {

        }

        private string Display()
        {
            string message = "";
            message = " SL\t| User name\t| First name\t| Last name\t| Contact No\t| Email\t| Address\t| Account No\n";

            for(int index = 0; index < users.Count; index++)
            {
                message = message + " " + (index+1) + "\t " + users[index] + "\t " + firstNames[index] + "\t " + lastNames[index] + "\t " + contacts[index] + "\t " + emails[index] + "\t " + addresses[index] + "\t " + accountsNo[index] + "\n";
            }

            return message;
        }

        private bool UserExists(string user)
        {
            bool isExists = false;

            foreach (string userCheck in users)
            {
                if (userCheck == user)
                    isExists = true;
            }
            return isExists;
        }

        private bool ContactExists(string contact)
        {
            bool isExists = false;

            foreach (string contactCheck in contacts)
            {
                if (contactCheck == contact)
                    isExists = true;
            }
            return isExists;
        }

        private bool EmailExists(string email)
        {
            bool isExists = false;

            foreach (string emailCheck in emails)
            {
                if (emailCheck == email)
                    isExists = true;
            }
            return isExists;
        }

        private bool AccountNoExists(string account)
        {
            bool isExists = false;

            foreach (string accountCheck in accountsNo)
            {
                if (accountCheck == account)
                    isExists = true;
            }
            return isExists;
        }
    }
}
