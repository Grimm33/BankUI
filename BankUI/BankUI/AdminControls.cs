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
    public partial class AdminControls : Form
    {
        public List<Client> client = new List<Client>();

        public AdminControls(List<Client> client)
        {
            InitializeComponent();
            this.client = client;
            this.Text = "Controls";
            this.Update();
        }

        //Loading Frontpage form when current form closes 
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Frontpage loginForm = new Frontpage();
            loginForm.Show();
        }

        //Loading AddAccount when Add Account button is clicked
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddAccount f = new AddAccount(this.client);
            f.Show();
        }

        //Loading AddClient when Add User button is clicked 
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddClient f = new AddClient(this.client);
            f.Show();
        }

        private void AdminControls_Load(object sender, EventArgs e)
        {
            var area = Screen.AllScreens.Length > 1 ? Screen.AllScreens[1].WorkingArea : Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point((area.Width - this.Width) / 2, (area.Height - this.Height) / 2);
        }
    }
}
