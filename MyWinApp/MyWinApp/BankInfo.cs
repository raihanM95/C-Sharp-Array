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
        // List
        List<string> users = new List<string>();
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<int> contacts = new List<int>();
        List<string> emails = new List<string>();
        List<string> addresses = new List<string>();
        List<int> accountsNo = new List<int>();
        List<int> balances = new List<int>();

        public BankInfo()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation check label
                checkUserLabel.Text = "";
                checkContactLabel.Text = "";
                checkEmailLabel.Text = "";
                checkAccountLabel.Text = "";

                string user = userNameTextBox.Text;
                string fName = firstNameTextBox.Text;
                string lName = lastNameTextBox.Text;
                string email = emailTextBox.Text;
                string address = addressTextBox.Text;

                // Input validation
                if (String.IsNullOrEmpty(user))
                {
                    checkUserLabel.Text = "This field is required";
                    return;
                }
                else if (String.IsNullOrEmpty(contactNoTextBox.Text))
                {
                    checkContactLabel.Text = "This field is required";
                    return;
                }
                else if (String.IsNullOrEmpty(email))
                {
                    checkEmailLabel.Text = "This field is required";
                    return;
                }
                else if (String.IsNullOrEmpty(accountNoTextBox.Text))
                {
                    checkAccountLabel.Text = "This field is required";
                    return;
                }

                if (System.Text.RegularExpressions.Regex.IsMatch(contactNoTextBox.Text, "[^0-9]"))
                {
                    checkContactLabel.Text = "Please enter only numbers!";
                    return;
                }

                if (contactNoTextBox.TextLength != 11)
                {
                    checkContactLabel.Text = "Enter Contact No. 11 numeric digits only!";
                    return;
                }

                if (!email.Contains("@"))
                {
                    checkEmailLabel.Text = "Please enter correct email!";
                    return;
                }

                if (System.Text.RegularExpressions.Regex.IsMatch(accountNoTextBox.Text, "[^0-9]"))
                {
                    checkAccountLabel.Text = "Please enter only numeric Account No";
                    return;
                }

                if (accountNoTextBox.TextLength != 9)
                {
                    checkAccountLabel.Text = "Enter only 9 numeric digits Account No";
                    return;
                }

                int contact = Convert.ToInt32(contactNoTextBox.Text);
                int accountNo = Convert.ToInt32(accountNoTextBox.Text);
                
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
                balances.Add(0);

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
            int amount;
            int index;

            index = IsValidAccountNumber();
            if (index < 0)
            {
                if (index == -1)
                {
                    MessageBox.Show("Account No. is not valid! \nEnter a correct Account");
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                amount = Convert.ToInt32(amountTextBox.Text);
                balances[index] += amount;
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            int amount;
            int index;

            index = IsValidAccountNumber();
            if (index < 0)
            {
                if (index == -1)
                {
                    MessageBox.Show("Account No. is not valid! \nEnter a correct Account");
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                amount = Convert.ToInt32(amountTextBox.Text);
                balances[index] -= amount;
            }
        }

        private void BalanceButton_Click(object sender, EventArgs e)
        {
            int index;
            index = IsValidAccountNumber();
            if (index < 0)
            {
                if (index == -1)
                {
                    MessageBox.Show("Account No. is not valid! \nEnter a correct Account");
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Balance is: " + balances[index]);
            }
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

        private int IsValidAccountNumber()
        {
            int accountNumber;
            int index;

            if (String.IsNullOrEmpty(accountNumberTextBox.Text))
            {
                MessageBox.Show("Enter Account Number!");
                return -2;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(accountNumberTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numeric Account No");
                return -2;
            }

            accountNumber = Convert.ToInt32(accountNumberTextBox.Text);
            index = AccountNumberToIndex(accountNumber);
            return index;
        }

        private int AccountNumberToIndex(int accountNumber)
        {
            for (int index = 0; index < accountsNo.Count; index++)
            {
                if (accountsNo[index] == accountNumber)
                {
                    return index;
                }
            }
            return -1;
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

        private bool ContactExists(int contact)
        {
            bool isExists = false;

            foreach (int contactCheck in contacts)
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

        private bool AccountNoExists(int account)
        {
            bool isExists = false;

            foreach (int accountCheck in accountsNo)
            {
                if (accountCheck == account)
                    isExists = true;
            }
            return isExists;
        }
    }
}
