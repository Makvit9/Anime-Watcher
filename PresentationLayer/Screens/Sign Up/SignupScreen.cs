using System;
using AnimeWatcherBusinessLayer;
using System.Windows.Forms;
using System.IO.Ports;

namespace AnimeWatcher
{
    public partial class SignupScreen : Form
    {
        private Account _myAccount;
        
        public SignupScreen()
        {
            InitializeComponent();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown = false;


        private void signUpButton_Click(object sender, EventArgs e)
        {
            
            if (!User.IsTheUserExists(usernameTextBox.Text))
            {
                User newUser = new User(usernameTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text);
                newUser.AddUser();
                _myAccount = new Account(newUser);

                MainScreen main = new MainScreen(_myAccount);
                main.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("The User already Exists, Enter another username","Invalid Username");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //moving the title bar (could be converted to user control later on)
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }
        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                System.Drawing.Point currentLocation = PointToScreen(e.Location);
                Location = new System.Drawing.Point(currentLocation.X - mouseX, currentLocation.Y - mouseY);

                // Old one : it used to be buggy and glitching 
                //mouseX = MousePosition.X - 400; 
                //mouseY = MousePosition.Y - 20;

                // this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void titlePanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
       
        
        
        private bool EmailValidation(string EmailAddress , out string errorMessage)
        {
            
            if (usernameTextBox.Text.Length == 0)
            {

                errorMessage = "Email address is required";

                return false;
            }

            if (EmailAddress.IndexOf("@") > -1)
            {
                if (EmailAddress.IndexOf(".", EmailAddress.IndexOf("@")) > EmailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "Your email should have @ and . in the correct order";
            return false;
        }


        private void enter_textBox(object sender, EventArgs e)
        {
            
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void EmailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!User.IsEmailValid(EmailTextBox.Text))
            {
                e.Cancel = true;
                EmailTextBox.Select(0, EmailTextBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(EmailTextBox, "Enter a valid email address");

            }
        }

        private void EmailTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(EmailTextBox,"");
        }

        private void usernameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (User.IsTheUserExists(usernameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(usernameTextBox, "Username already in the list");
                
            }
            else
            {
                usernameTextBox.Validated += UsernameTextBox_Validated;
            }
        }

        private void UsernameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(usernameTextBox, "");
        }

        private void PasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (PasswordTextBox.Text.Length < 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(PasswordTextBox, "Password must be more than 4 characters");
            }
            else
            {
                PasswordTextBox.Validated += PasswordTextBox_Validated;
            }

        }

        private void PasswordTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(PasswordTextBox, "");

        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            PasswordTextBox.Clear();
            PasswordTextBox.PasswordChar = '*';
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            
        }
    
    
    
    
    }
    }
