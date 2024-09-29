using AnimeWatcherBusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace AnimeWatcher
{
    public partial class LoginScreen : Form
    {
        private int mouseX, mouseY;
        private bool mouseDown;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "USERNAME")
            {
                usernameTextBox.Text = "";
                usernameTextBox.ForeColor = Color.LightGray;
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "USERNAME";
                usernameTextBox.ForeColor = Color.DimGray;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "PASSWORD")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.LightGray;
                passwordTextBox.UseSystemPasswordChar = true;

            }


        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "PASSWORD";
                passwordTextBox.ForeColor = Color.DimGray;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                Point currentLocation = PointToScreen(e.Location);
                Location = new Point(currentLocation.X - mouseX, currentLocation.Y - mouseY);

                // Old one : it used to be buggy and glitching 
                //mouseX = MousePosition.X - 400; 
                //mouseY = MousePosition.Y - 20;

                // this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user1 = User.IsAuthenticated(usernameTextBox.Text, passwordTextBox.Text); //new User(usernameTextBox.Text, passwordTextBox.Text);
            if (user1 == null)
            {
                MessageBox.Show("Incorrect Email Or Password, try again");
            }
            else
            {
                Account MyAcount = new Account(user1);
                MessageBox.Show($"Hello {usernameTextBox.Text}");
                MainScreen mainScreen = new MainScreen(MyAcount);
                mainScreen.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void _KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            SignupScreen signupScreen = new SignupScreen();
            signupScreen.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }


    }
}
