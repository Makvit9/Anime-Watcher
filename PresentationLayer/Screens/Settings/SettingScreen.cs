using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimeWatcherBusinessLayer;
using System.Windows.Forms;

namespace AnimeWatcher
{
    public partial class SettingScreen : Form
    {
        Account _account;
        public SettingScreen(Account UserAccount)
        {
            InitializeComponent();
            _account = UserAccount;
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == confirmPasswordTextBox.Text)
            {
                User.ChangePassword(newPasswordTextBox.Text, _account.AccountUser);
                MessageBox.Show("Password Updated Successfully");
            }
            else
            {
                MessageBox.Show("Password doesn't match");
            }

            newPasswordTextBox.Clear();
            confirmPasswordTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!User.IsEmailExists(newEmailTextBox.Text))
            {
                User.UpdateEmail(newEmailTextBox.Text , _account.AccountUser.Email);
            }
            else
            {
                MessageBox.Show("Email already exists","Choose another email",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }

            newEmailTextBox.Clear();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (!User.IsTheUserExists(newUsernameTextBox.Text))
            {
                _account.AccountUser.UpdateUsername(newUsernameTextBox.Text);
                MessageBox.Show("Username updated successfully");
            }
            else
            {
                MessageBox.Show("Username already exists", "Choose another one", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            newUsernameTextBox.Clear();
        }
    }



}
