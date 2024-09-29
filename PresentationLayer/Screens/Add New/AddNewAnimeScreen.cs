using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimeWatcherBusinessLayer;

namespace AnimeWatcher
{
    public partial class AddNewAnimeScreen : Form
    {
        Account account;
        public AddNewAnimeScreen(Account MyAccount)
        {
            InitializeComponent();
            account = MyAccount;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {



            Anime anime = new Anime(animeNameTextBox.Text);
            DataTable dt = anime.FindAnime(anime.Name);

            

            _prepareDataTable( dt);
            dataGridView1.DataSource = dt;
         //   _designGridView();
            
        }

        /*
         *  Anime anime = new Anime(animeNameTextBox.Text);
            DataTable dt = anime.FindAnime(anime.Name);

            

            _prepareDataTable( dt);
            dataGridView1.DataSource = dt;
            _designGridView();
         * */

        private void _designGridView()
        {
            DataGridViewImageColumn image = (DataGridViewImageColumn)dataGridView1.Columns[dataGridView1.ColumnCount - 1];
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.RowHeadersVisible = false;
            //dataGridView1.Columns.Remove("PicturePath");
            dataGridView1.ClearSelection();
            dataGridView1.MultiSelect = false;
        }




        private void _prepareDataTable( DataTable dt)
        {
            dt.Columns.Add("Picture", Type.GetType("System.Byte[]"));

            foreach (DataRow row in dt.Rows)
            {
                row["Picture"] = File.ReadAllBytes(row["PicturePath"].ToString());

            }

            dt.Columns["NumberOfEpisode"].ColumnName = "Number of episodes ";
            

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellMouseEventArgs e)
        {
            // string AnimeName = dataGridView1.SelectedRows[1].ToString();

            if (MessageBox.Show("Do you want to add this anime? ", "Add Anime", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //    if (!Account.FindAnime(account.AccountUser.UserName , AnimeName))
                {
                    //      account.ADD(AnimeName);
                }
            }
        }

       

       

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //string AnimeName = "";

            //if (dataGridView1.RowCount > 0 && i < dataGridView1.RowCount )
            //{
            //    AnimeName = dataGridView1.SelectedCells[1].Value.ToString();
            //    i++;
            //}
            //if (MessageBox.Show("Do you want to add this anime? ", "Add Anime", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //        if (!Account.FindAnime(account.AccountUser.UserName , AnimeName))
            //    {
            //              account.ADD(AnimeName);
            //    }
            //}

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _designGridView();
        }

        
        
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string AnimeName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if (e.Button == MouseButtons.Left)
            {

                AddButton.Visible = true;
                MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells["Picture"].Value);
                pictureBox1.Image = Image.FromStream(ms); 
              
                // pictureBox1.Image = Image.FromStream()
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            string AnimeName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if (!account.IsAnimeExists(AnimeName))
            {
                if (MessageBox.Show("do you want to add this anime? ", "Add Anime", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    account.ADD(AnimeName);
                    MessageBox.Show("Your anime was added successfully", "Added Successfully", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("The anime already exists in your list", "Already Exists", MessageBoxButtons.OK);
            }
        }
    }
}
