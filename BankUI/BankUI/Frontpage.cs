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
    public partial class Frontpage : Form
    {
        public List<Client> client = new List<Client>();

        public int count = 0;
        public Frontpage()
        {
            InitializeComponent();
            this.Text = "Admin Login";
            this.Update();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //storing TextBox values
            string adminUser = tbUser.Text;
            string adminPass = tbPass.Text;

            string adminUserCheck = "Admin";
            string adminPassCheck = "Adminpass";
            
            bool checkAdmin = ((adminUser == adminUserCheck) && (adminPass == adminPassCheck)) ? true : false;

            if ((checkAdmin) && (count <3))
            {
                //shows that you logged in via message box
                //hides current form and loads AdminControls

                MessageBox.Show("Logged in as ADMIN");
                this.Hide();

                AdminControls form2 = new AdminControls(this.client);
                form2.ShowDialog();
            }
            else
            {
                //resets the text boxes
                count++;
                MessageBox.Show("Error with credentials");
                tbUser.Text = String.Empty;
                tbPass.Text = String.Empty;

                if(count == 3)
                {
                    MessageBox.Show("You have run out of login attemps. Please try again later.");
                    Application.Exit();
                }
            }
        }

        private void Frontpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frontpage_Load(object sender, EventArgs e)
        {
            var area = Screen.AllScreens.Length > 1 ? Screen.AllScreens[1].WorkingArea : Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point((area.Width - this.Width) / 2, (area.Height - this.Height) / 2);
        }
    }
}
