namespace AnimeWatcher
{
    partial class AddNewAnimeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animeNameLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.animeNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // animeNameLabel
            // 
            this.animeNameLabel.AutoSize = true;
            this.animeNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animeNameLabel.Location = new System.Drawing.Point(27, 23);
            this.animeNameLabel.Name = "animeNameLabel";
            this.animeNameLabel.Size = new System.Drawing.Size(101, 21);
            this.animeNameLabel.TabIndex = 1;
            this.animeNameLabel.Text = "Anime Name";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(197, 77);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(78, 34);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // animeNameTextBox
            // 
            this.animeNameTextBox.Location = new System.Drawing.Point(145, 23);
            this.animeNameTextBox.Name = "animeNameTextBox";
            this.animeNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.animeNameTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 206);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchPictureBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchPictureBox.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.SearchPictureBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.SearchPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SearchPictureBox.IconSize = 20;
            this.SearchPictureBox.Location = new System.Drawing.Point(332, 23);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Rotation = 90D;
            this.SearchPictureBox.Size = new System.Drawing.Size(23, 20);
            this.SearchPictureBox.TabIndex = 5;
            this.SearchPictureBox.TabStop = false;
            this.SearchPictureBox.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(440, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AddNewAnimeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchPictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.animeNameTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.animeNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewAnimeScreen";
            this.Text = "AddNewAnimeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label animeNameLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox animeNameTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconPictureBox SearchPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}