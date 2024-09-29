using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Windows.Controls;
using System.Data;


using System.Windows.Forms;
using AnimeWatcherBusinessLayer;
using System;

namespace AnimeWatcher
{
    public partial class CurrentlyWatchingScreen : Form
    {
        private Account UserAccount;
        private DataTable _dataTable;
        
        public CurrentlyWatchingScreen(User user)
        {
            InitializeComponent();
            UserAccount = new Account( user);
            _dataTable = UserAccount.LoadData();

            ShowData();
            
        }
        // Now we can show the data of each user
        public void ShowData()
        {

            //if (_dataTable)
            //{
            //    Label l = new Label();
            //    Point point = new Point(200,200);
            //    l.Location = point;
            //    l.Text = "There's no anime try to add new ones";
            //    return;

            //}

            try
            {


                PrepareDataTable();
            this.dataGridView1.DataSource = _dataTable;
         //   _decorateTable();
              



            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public void PrepareDataTable()
        {
            _dataTable.Columns.Add("Picture", Type.GetType("System.Byte[]"));

            foreach (DataRow row in _dataTable.Rows)
            {
                row["Picture"] = File.ReadAllBytes(row["PicturePath"].ToString());

            }

            _dataTable.Columns["NumberOfEpisode"].ColumnName = "Number of episodes ";
        }
        private void _decorateTable()
        {
            //table.Columns.Add("Picture", GetType("System.Byte[]");

            ////  DataColumn PictureColumn = dataGridView1.Columns["PictureColumn"];
            //foreach (DataRow Row in dataGridView1.Rows)
            //{
            //    Row["Picture"] = File.ReadAllBytes(Row["PicturePath"].ToString());

            //}

            // Add picture to the table 


            //DataGridViewImageColumn image = (DataGridViewImageColumn)dataGridView1.Columns[dataGridView1.ColumnCount - 1];
            //image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //image.HeaderText = "Image";
            //dataGridView1.RowTemplate.Height = 100;
            //dataGridView1.RowHeadersVisible = false;
            ////dataGridView1.Columns.Remove("PicturePath");
            //dataGridView1.ClearSelection();
            //dataGridView1.MultiSelect = false;

            //DataGridViewButtonColumn AddNewEpisode = new DataGridViewButtonColumn();
            //AddNewEpisode.HeaderText = "Add New Episode";
            //AddNewEpisode.Text = "+";



            ////dataGridView1.Columns.Add(image);
            ////dataGridView1.RowTemplate.Height = 100;
            ////dataGridView1.Columns.Add(AddNewEpisode);

            //foreach (DataGridViewRow Row in dataGridView1.Rows)
            //{
            //    if (Row.Cells["Image"] != null)
            //    {
            //    //    Bitmap bmp = new Bitmap();
            //    Row.Cells["Image"].Value = File.ReadAllBytes(Row.Cells["PicturePath"].Value.ToString());

            //    }

            //}
            DataGridViewImageColumn image = (DataGridViewImageColumn)dataGridView1.Columns[dataGridView1.ColumnCount - 1];
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.RowHeadersVisible = false;
            //dataGridView1.Columns.Remove("PicturePath");
            dataGridView1.ClearSelection();
            dataGridView1.MultiSelect = false;

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _decorateTable();
        }
    }

}