using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System_ZubairZulfiqar_bsef20a504
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm login=new LoginForm();
            login.ShowDialog();

            this.Close();
            //this.Hide();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.ShowDialog();

            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
