namespace AnimeWatcher
{
    partial class MainScreen
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.removeButton = new FontAwesome.Sharp.IconButton();
            this.addNewButton = new FontAwesome.Sharp.IconButton();
            this.currentlyWatchingButton = new FontAwesome.Sharp.IconButton();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.menuButton = new FontAwesome.Sharp.IconButton();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.tiltleLabel = new System.Windows.Forms.Label();
            this.maximizeButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.MainScreenPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.menuPanel.Controls.Add(this.settingsButton);
            this.menuPanel.Controls.Add(this.removeButton);
            this.menuPanel.Controls.Add(this.addNewButton);
            this.menuPanel.Controls.Add(this.currentlyWatchingButton);
            this.menuPanel.Controls.Add(this.logoutButton);
            this.menuPanel.Controls.Add(this.menuButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ForeColor = System.Drawing.Color.Black;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.MaximumSize = new System.Drawing.Size(200, 450);
            this.menuPanel.MinimumSize = new System.Drawing.Size(58, 450);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 450);
            this.menuPanel.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.settingsButton.IconColor = System.Drawing.Color.Black;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 40;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 220);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 55);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Tag = "Settings";
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.removeButton.IconColor = System.Drawing.Color.Black;
            this.removeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removeButton.IconSize = 40;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(0, 165);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(200, 55);
            this.removeButton.TabIndex = 4;
            this.removeButton.Tag = "Remove";
            this.removeButton.Text = "Remove";
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNewButton.FlatAppearance.BorderSize = 0;
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addNewButton.IconColor = System.Drawing.Color.Black;
            this.addNewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addNewButton.IconSize = 40;
            this.addNewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewButton.Location = new System.Drawing.Point(0, 110);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(200, 55);
            this.addNewButton.TabIndex = 3;
            this.addNewButton.Tag = "Add new";
            this.addNewButton.Text = "Add new";
            this.addNewButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // currentlyWatchingButton
            // 
            this.currentlyWatchingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentlyWatchingButton.FlatAppearance.BorderSize = 0;
            this.currentlyWatchingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentlyWatchingButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlyWatchingButton.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.currentlyWatchingButton.IconColor = System.Drawing.Color.Black;
            this.currentlyWatchingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentlyWatchingButton.IconSize = 40;
            this.currentlyWatchingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentlyWatchingButton.Location = new System.Drawing.Point(0, 55);
            this.currentlyWatchingButton.Name = "currentlyWatchingButton";
            this.currentlyWatchingButton.Size = new System.Drawing.Size(200, 55);
            this.currentlyWatchingButton.TabIndex = 2;
            this.currentlyWatchingButton.Tag = "Currently watching";
            this.currentlyWatchingButton.Text = "Currently watching";
            this.currentlyWatchingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentlyWatchingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.currentlyWatchingButton.UseVisualStyleBackColor = true;
            this.currentlyWatchingButton.Click += new System.EventHandler(this.currentlyWatchingButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.logoutButton.IconColor = System.Drawing.Color.Black;
            this.logoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 395);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.logoutButton.Size = new System.Drawing.Size(200, 55);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Tag = "Logout";
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.menuButton.IconColor = System.Drawing.Color.Black;
            this.menuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuButton.IconSize = 40;
            this.menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.Location = new System.Drawing.Point(0, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(200, 55);
            this.menuButton.TabIndex = 7;
            this.menuButton.Tag = "Menu";
            this.menuButton.Text = "Menu";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.titlePanel.Controls.Add(this.minimizeButton);
            this.titlePanel.Controls.Add(this.tiltleLabel);
            this.titlePanel.Controls.Add(this.maximizeButton);
            this.titlePanel.Controls.Add(this.exitButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(200, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(700, 40);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 20;
            this.minimizeButton.Location = new System.Drawing.Point(625, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // tiltleLabel
            // 
            this.tiltleLabel.AutoSize = true;
            this.tiltleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiltleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tiltleLabel.Location = new System.Drawing.Point(6, 5);
            this.tiltleLabel.Name = "tiltleLabel";
            this.tiltleLabel.Size = new System.Drawing.Size(141, 25);
            this.tiltleLabel.TabIndex = 0;
            this.tiltleLabel.Text = "Anime watcher";
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.maximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizeButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.maximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeButton.IconSize = 20;
            this.maximizeButton.Location = new System.Drawing.Point(651, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(20, 20);
            this.maximizeButton.TabIndex = 0;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.exitButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 20;
            this.exitButton.Location = new System.Drawing.Point(677, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainScreenPanel
            // 
            this.MainScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainScreenPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreenPanel.Location = new System.Drawing.Point(200, 40);
            this.MainScreenPanel.Name = "MainScreenPanel";
            this.MainScreenPanel.Size = new System.Drawing.Size(700, 410);
            this.MainScreenPanel.TabIndex = 2;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.MainScreenPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anime Watcher";
            this.menuPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel MainScreenPanel;
        private FontAwesome.Sharp.IconButton addNewButton;
        private FontAwesome.Sharp.IconButton logoutButton;
        private FontAwesome.Sharp.IconButton removeButton;
        private FontAwesome.Sharp.IconButton currentlyWatchingButton;
        private FontAwesome.Sharp.IconButton settingsButton;
        private System.Windows.Forms.Label tiltleLabel;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton maximizeButton;
        private FontAwesome.Sharp.IconButton menuButton;
    }
}