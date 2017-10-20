using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankUI
{
    public partial class AddAccount : Form
    {
        Validation val = new Validation();
        public List<Client> client = new List<Client>();
        int endCA;
        int endSA;

        public AddAccount(List<Client> client)
        {
            InitializeComponent();
            this.Text = "Add Account";
            this.client = client;
            this.Update();
        }

        private void addAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            //shows AdminControls form when current is closed 
            this.Hide();
            AdminControls f = new AdminControls(this.client);
            f.Show();
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            #region storing and trimming inputs
            string clientID = tbClientID.Text;
            string accAmt = tbAccAmt.Text;      //accAmt shows the amount of money in the account. It is saved as a string so that it can be validated with Regex.IsMatch

            clientID = clientID.Trim();
            accAmt = accAmt.Trim();
            #endregion

            string clientIDProp = val.IDCardFixing(clientID);

            bool check = (val.ValIDNum(clientIDProp) && (val.ValFloat(accAmt)));
            bool checkCB = ((comboBoxChooseAccType.Text == "Checking Account") || (comboBoxChooseAccType.Text == "Savings Account"));   //checks if text from the comboBox is one of 2 possible options

            if (check && checkCB)
            {
                clientID = clientIDProp.TrimStart('0'); //trims the extra characters we added with the function IDCardFixing()
                
                #region checking if Client exists for account
                bool clientExists = true;

                int x = client.Count;

                if(x != 0)
                {
                    for (int i = 0; i <= client.Count; i++)
                    {
                        if (i == client.Count)
                        {
                            clientExists = false;
                            break;
                        }
                        else
                        {
                            bool checkClientId = client[i].idCard.Contains(clientID);
                            if (checkClientId)
                            {
                                clientExists = true;
                                endCA = client[i].checkingList.Count;  //calculating what the last digits on the account name should be
                                endSA = client[i].savingsList.Count;   //calculating what the last digits on the account name should be
                                break;
                            }
                        }
                    }
                }
                else clientExists = false;
                    
                #endregion

                float accAmtConv = Convert.ToSingle(accAmt);
                
                if ((comboBoxChooseAccType.Text == "Checking Account") && (clientExists))
                {
                    #region makes the account name
                    char[] trimEnd = { 'M', 'A', 'L', 'G' };

                    clientIDProp = val.IDCardFixing(clientID); //puts back any extra '0' so that the int part of the id card number always has 7 numbers in the name

                    string accountName = "CA" + clientIDProp.TrimEnd(trimEnd);  //adds together 'CA' (Checking Account), the id card number, but removes the last letter from the number
                    
                    accountName += endCA;   //adds to the end a count of the amount of accounts the Client has - keeps all names unique
                    #endregion

                    MessageBox.Show("Added " + accountName);

                    #region adds checking account to the checking account list in Client
                    bool newCheck = true;
                    int count = 0;
                    do
                    {
                        if(client[count].idCard == clientID)
                        {
                            client[count].AddCheckingAccount(new CheckingAccount(accountName, accAmtConv));
                            newCheck = false;
                        }
                        count++;
                    }
                    while (newCheck);
                    #endregion
                }

                else if ((comboBoxChooseAccType.Text == "Savings Account") && (clientExists))
                {
                    #region makes the account name
                    char[] trimEnd = { 'M', 'A', 'L', 'G' };

                    clientIDProp = val.IDCardFixing(clientID); //puts back any extra '0' so that the int part of the id card number always has 7 numbers in the name

                    string accountName = "SA" + clientIDProp.TrimEnd(trimEnd);  //adds together 'SA' (Savings Account), the id card number, but removes the last letter from the number

                    accountName += endSA;   //adds to the end a count of the amount of accounts the Client has - keeps all names unique
                    #endregion 

                    MessageBox.Show("Added " + accountName);

                    #region adds savings account to the savings account list in Client
                    bool newCheck = true;
                    int count = 0;
                    do
                    {
                        if (client[count].idCard == clientID)
                        {
                            client[count].AddSavingsAccount(new SavingsAccount(accountName, accAmtConv));
                            newCheck = false;
                        }
                        count++;
                    }
                    while (newCheck);
                    #endregion
                }

                else
                {
                    //resets text boxes
                    MessageBox.Show("You tried to create an account for a Client who doesnt have an account with us. Please create the Client first and then you can add his accounts.");
                    tbClientID.Text = String.Empty;
                    tbAccAmt.Text = String.Empty;
                }
            }
            else
            {
                //resets text boxes
                MessageBox.Show("Invalid Entries!");
                tbClientID.Text = String.Empty;
                tbAccAmt.Text = String.Empty;
            }
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            var area = Screen.AllScreens.Length > 1 ? Screen.AllScreens[1].WorkingArea : Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point((area.Width - this.Width) / 2, (area.Height - this.Height) / 2);
        }
    }
}