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
    public partial class AddClient : Form
    {
        Validation val = new Validation();
        List<Client> client = new List<Client>();
        string idNumProp;

        public AddClient(List<Client> client)
        {
            InitializeComponent();
            this.client = client;
            this.Text = "Add Client";
            this.Update();
        }

        private void AddClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            //we've done this enough times i think you know what it is 
            this.Hide();
            AdminControls f = new AdminControls(this.client);
            f.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            #region storing and trimming inputs
            string uName = tbName.Text;
            string uSurname = tbSurname.Text;
            string uIdNum = tbIDNum.Text;
            
            uName = uName.Trim();
            uSurname = uSurname.Trim();
            uIdNum = uIdNum.Trim();
            #endregion

            //since the function ValIDNum in Validation checks if a string has 7 integers followed by certain letters, we need to make sure that the inputs all have 7 integers before the letter
            idNumProp = val.IDCardFixing(uIdNum);

            //validating all inputs
            bool check = ((val.ValString(uName)) && (val.ValString(uSurname)) && (val.ValIDNum(idNumProp)));

            if(check)
            {
                #region checking if Client already exists -- ID Card Number
                bool idUniquie = true;
                for (int i = 0; i <= client.Count; i++)
                {
                    if (i == client.Count) // if i == list count exit with true i.e. no matching id numbers were found
                    {
                        idUniquie = true;
                        break;
                    }
                    else if (client[i].idCard.Contains(uIdNum)) // if matching id number found return false
                    {
                        idUniquie = false;
                        break;
                    }
                }
                #endregion

                if (idUniquie)    //if id card number is unique
                {
                    //adds client into a list of clients
                    client.Add(new Client(uName, uSurname, uIdNum));
                    MessageBox.Show("Client Created: " + uName + " " + uSurname + " " + uIdNum);

                    int x = client.Count;

                    //resets text boxes
                    tbName.Text = String.Empty;
                    tbSurname.Text = String.Empty;
                    tbIDNum.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Another user with the same ID Card number exists!");
                }
            }
            else
            {
                MessageBox.Show("Error with credentials!");
            }
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            var area = Screen.AllScreens.Length > 1 ? Screen.AllScreens[1].WorkingArea : Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point((area.Width - this.Width) / 2, (area.Height - this.Height) / 2);
        }
    }
}