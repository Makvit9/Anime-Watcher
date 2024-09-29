using AnimeWatcherBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace AnimeWatcher
{
    public partial class DeleteAnimeScreen : Form
    {
        public Account Myaccount;
      
        
        public DeleteAnimeScreen(Account UserAccount)
        {
            InitializeComponent();
            Myaccount = UserAccount;
         //   comboBox1.Items.Clear();
            _fillComboBox();
       
        }

        

        

        private void _fillComboBox()
        {
            //var Filteredview = Myaccount.UserAnimes.DefaultView.ToTable(false, "Name");
            comboBox1.Items.Clear(); 
            Myaccount.UserAnimes = Myaccount.LoadData();
            foreach (DataRow row in Myaccount.UserAnimes.Rows)
            {
                comboBox1.Items.Add(row["Name"]);
            }
            comboBox1.Text = comboBox1.Tag.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? ","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Myaccount.Delete(comboBox1.Text);
                MessageBox.Show("Deleted Successfully");
                _fillComboBox();
            }
            
        }
    }
}
