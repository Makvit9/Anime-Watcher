using AnimeWatcherBusinessLayer;
using System.Drawing;
using System.Linq;



using System.Windows.Forms;

namespace AnimeWatcher
{
    public partial class MainScreen : Form
    {
        private int borderSize = 2;

        int mouseX = 0, mouseY = 0;
        bool mouseDown = false;
        Account UserAccount;


        public MainScreen(Account MyAccount)
        {

            InitializeComponent();
            
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.Black;

            menuButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            exitButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            settingsButton.IconChar = FontAwesome.Sharp.IconChar.Gear;
            collapseMenu();
            logoutButton.Padding = new Padding(borderSize);
            UserAccount = MyAccount;

        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            mouseX = e.X; 
            mouseY = e.Y;
        }


        // I think should be in a separate class 
        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                System.Drawing.Point  currentLocation = PointToScreen(e.Location);
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
       
        private void minimizeButton_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;

            }
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }


        // Buttons 
        private void menuButton_Click(object sender, System.EventArgs e)
        {
            collapseMenu();
        }
        public void prepareTheForm(Form frm)
        {
            MainScreenPanel.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            MainScreenPanel.Controls.Add(frm);
            frm.Show();
        }

        private void currentlyWatchingButton_Click(object sender, System.EventArgs e)
        {
            prepareTheForm(new CurrentlyWatchingScreen(UserAccount.AccountUser));
            //CurrentlyWatchingScreen currentlyWatchingScreen = new CurrentlyWatchingScreen(UserAccount.AccountUser);
            //currentlyWatchingScreen.TopLevel = false;
            //currentlyWatchingScreen.FormBorderStyle = FormBorderStyle.None;
            //currentlyWatchingScreen.Dock = DockStyle.Fill;

            //MainScreenPanel.Controls.Clear();
            //MainScreenPanel.Controls.Add(currentlyWatchingScreen);
            //currentlyWatchingScreen.Show();
           
           
        }

        private void menuButton_Click_1(object sender, System.EventArgs e)
        {
            collapseMenu();
        }

        private void addNewButton_Click(object sender, System.EventArgs e)
        {
            //AddNewAnimeScreen addNewAnimeScreen = new AddNewAnimeScreen(UserAccount);
            //addNewAnimeScreen .TopLevel = false;
            //addNewAnimeScreen .FormBorderStyle = FormBorderStyle.None;
            //addNewAnimeScreen.Dock = DockStyle.Fill;

            //MainScreenPanel.Controls.Clear();
            //MainScreenPanel.Controls.Add(addNewAnimeScreen);
            //addNewAnimeScreen.Show();
            prepareTheForm(new AddNewAnimeScreen(UserAccount));

        }


        private void removeButton_Click(object sender, System.EventArgs e)
        {
            prepareTheForm(new DeleteAnimeScreen(UserAccount));
           
            //DeleteAnimeScreen deleteAnimeScreen = new DeleteAnimeScreen(UserAccount);
            //deleteAnimeScreen .TopLevel = false;
            //deleteAnimeScreen.FormBorderStyle = FormBorderStyle.None;
            //deleteAnimeScreen.Dock = DockStyle.Fill;

            //MainScreenPanel.Controls.Clear();
            //MainScreenPanel.Controls.Add(deleteAnimeScreen);
            //deleteAnimeScreen.Show();

        }

        private void settingsButton_Click(object sender, System.EventArgs e)
        {
            prepareTheForm(new SettingScreen(UserAccount));
            //MainScreenPanel.Controls.Clear();

            //SettingScreen settingsScreen = new SettingScreen(UserAccount);
            //settingsScreen .TopLevel = false;
            //settingsScreen .FormBorderStyle = FormBorderStyle.None;
            //settingsScreen .Dock = DockStyle.Fill;
            //MainScreenPanel.Controls.Clear();
            //MainScreenPanel.Controls.Add(settingsScreen);
            //settingsScreen .Show();
            

        }

        private void logoutButton_Click(object sender, System.EventArgs e)
        {
          
            DialogResult result=  System.Windows.Forms.MessageBox.Show("Are you sure you want to logout?" ,"Logout" , MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                LoginScreen loginscreen= new LoginScreen();
                loginscreen.Show();
                this.Close();
            }


        }

        private void MainScreenPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        // Menu Panel


        private void collapseMenu()
        {
            if (this.menuPanel.Width > 199)
            {
                menuPanel.Width = 100;
               // menuButton.Dock = DockStyle.Top;

                foreach (Button menuPanelButton in menuPanel.Controls.OfType<Button>())
                {
                    menuPanelButton.Text = "";
                    menuPanelButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuPanelButton.Padding = new Padding(0);
                }
            }
            else
            {
                menuPanel.Width = 200;
                //menuButton.Dock = DockStyle.None;

                foreach (Button menuPanelButton in menuPanel.Controls.OfType<Button>())
                {
                    menuPanelButton.Text = "   "  + menuPanelButton.Tag.ToString();
                    menuPanelButton.ImageAlign = ContentAlignment.MiddleLeft;

                    menuPanelButton.Padding = new Padding(10,0,0,0);
                }

            }
        }


    }
}
