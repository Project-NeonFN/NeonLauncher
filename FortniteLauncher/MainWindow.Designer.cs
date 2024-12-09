namespace FortniteLauncher
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Guna.UI2.WinForms.Guna2PictureBox image;
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.AppExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StatsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DownloadPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.OpenFortLibrary = new Guna.UI2.WinForms.Guna2Button();
            this.LaunchButton = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.HomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.LibraryButton = new Guna.UI2.WinForms.Guna2Button();
            this.ItemShopButton = new Guna.UI2.WinForms.Guna2Button();
            this.SettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.downloadPanel1 = new FortniteLauncher.DownloadPanel();
            image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.StatsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.DownloadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(image)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.guna2Panel1.Controls.Add(this.SettingsButton);
            this.guna2Panel1.Controls.Add(this.ItemShopButton);
            this.guna2Panel1.Controls.Add(this.LibraryButton);
            this.guna2Panel1.Controls.Add(this.HomeButton);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(-2, -3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(255, 756);
            this.guna2Panel1.TabIndex = 0;
            // 
            // AppExitButton
            // 
            this.AppExitButton.BackColor = System.Drawing.Color.Transparent;
            this.AppExitButton.BorderRadius = 10;
            this.AppExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AppExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AppExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AppExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AppExitButton.FillColor = System.Drawing.Color.Transparent;
            this.AppExitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppExitButton.ForeColor = System.Drawing.Color.White;
            this.AppExitButton.HoverState.FillColor = System.Drawing.Color.Red;
            this.AppExitButton.Location = new System.Drawing.Point(1172, 12);
            this.AppExitButton.Name = "AppExitButton";
            this.AppExitButton.Size = new System.Drawing.Size(41, 45);
            this.AppExitButton.TabIndex = 2;
            this.AppExitButton.Text = "X";
            this.AppExitButton.Click += new System.EventHandler(this.AppExitButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BorderRadius = 10;
            this.MinimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(1125, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(41, 45);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "NEON";
            // 
            // StatsPanel
            // 
            this.StatsPanel.BorderColor = System.Drawing.Color.White;
            this.StatsPanel.BorderRadius = 10;
            this.StatsPanel.BorderThickness = 2;
            this.StatsPanel.Controls.Add(this.label6);
            this.StatsPanel.Controls.Add(this.label5);
            this.StatsPanel.Controls.Add(this.label4);
            this.StatsPanel.Controls.Add(this.label3);
            this.StatsPanel.Controls.Add(this.label2);
            this.StatsPanel.Controls.Add(this.guna2PictureBox1);
            this.StatsPanel.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.StatsPanel.Location = new System.Drawing.Point(259, 76);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Size = new System.Drawing.Size(954, 118);
            this.StatsPanel.TabIndex = 4;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(13, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(110, 92);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(129, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome User!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(339, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount Of Wins[0]";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(568, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(545, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "K/D Ratio[0]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(689, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount Of Elims[0]";
            // 
            // DownloadPanel
            // 
            this.DownloadPanel.BorderColor = System.Drawing.Color.White;
            this.DownloadPanel.BorderRadius = 10;
            this.DownloadPanel.BorderThickness = 2;
            this.DownloadPanel.Controls.Add(this.label7);
            this.DownloadPanel.Controls.Add(this.LaunchButton);
            this.DownloadPanel.Controls.Add(this.OpenFortLibrary);
            this.DownloadPanel.Controls.Add(image);
            this.DownloadPanel.Location = new System.Drawing.Point(259, 252);
            this.DownloadPanel.Name = "DownloadPanel";
            this.DownloadPanel.Size = new System.Drawing.Size(700, 294);
            this.DownloadPanel.TabIndex = 5;
            // 
            // image
            // 
            image.BorderRadius = 10;
            image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            image.ImageRotate = 0F;
            image.Location = new System.Drawing.Point(21, 14);
            image.Name = "image";
            image.Size = new System.Drawing.Size(354, 221);
            image.TabIndex = 0;
            image.TabStop = false;
            // 
            // OpenFortLibrary
            // 
            this.OpenFortLibrary.BackColor = System.Drawing.Color.Transparent;
            this.OpenFortLibrary.BorderColor = System.Drawing.Color.White;
            this.OpenFortLibrary.BorderRadius = 10;
            this.OpenFortLibrary.BorderThickness = 2;
            this.OpenFortLibrary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OpenFortLibrary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OpenFortLibrary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OpenFortLibrary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OpenFortLibrary.FillColor = System.Drawing.Color.Transparent;
            this.OpenFortLibrary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFortLibrary.ForeColor = System.Drawing.Color.White;
            this.OpenFortLibrary.Location = new System.Drawing.Point(21, 241);
            this.OpenFortLibrary.Name = "OpenFortLibrary";
            this.OpenFortLibrary.Size = new System.Drawing.Size(354, 45);
            this.OpenFortLibrary.TabIndex = 6;
            this.OpenFortLibrary.Text = "Download";
            this.OpenFortLibrary.Click += new System.EventHandler(this.OpenFortLibrary_Click);
            // 
            // LaunchButton
            // 
            this.LaunchButton.BackColor = System.Drawing.Color.Transparent;
            this.LaunchButton.BorderColor = System.Drawing.Color.White;
            this.LaunchButton.BorderRadius = 10;
            this.LaunchButton.BorderThickness = 2;
            this.LaunchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LaunchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LaunchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LaunchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LaunchButton.FillColor = System.Drawing.Color.Transparent;
            this.LaunchButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchButton.ForeColor = System.Drawing.Color.White;
            this.LaunchButton.Location = new System.Drawing.Point(428, 190);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(210, 45);
            this.LaunchButton.TabIndex = 7;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(381, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Expirence OG Fortnite Season 7!";
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BorderColor = System.Drawing.Color.White;
            this.HomeButton.BorderRadius = 10;
            this.HomeButton.BorderThickness = 2;
            this.HomeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeButton.FillColor = System.Drawing.Color.Transparent;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(3, 152);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(249, 45);
            this.HomeButton.TabIndex = 11;
            this.HomeButton.Text = "🏠Home";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LibraryButton
            // 
            this.LibraryButton.BackColor = System.Drawing.Color.Transparent;
            this.LibraryButton.BorderColor = System.Drawing.Color.White;
            this.LibraryButton.BorderRadius = 10;
            this.LibraryButton.BorderThickness = 2;
            this.LibraryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LibraryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LibraryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LibraryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LibraryButton.FillColor = System.Drawing.Color.Transparent;
            this.LibraryButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryButton.ForeColor = System.Drawing.Color.White;
            this.LibraryButton.Location = new System.Drawing.Point(3, 228);
            this.LibraryButton.Name = "LibraryButton";
            this.LibraryButton.Size = new System.Drawing.Size(249, 45);
            this.LibraryButton.TabIndex = 12;
            this.LibraryButton.Text = "🎮Library";
            this.LibraryButton.Click += new System.EventHandler(this.LibraryButton_Click);
            // 
            // ItemShopButton
            // 
            this.ItemShopButton.BackColor = System.Drawing.Color.Transparent;
            this.ItemShopButton.BorderColor = System.Drawing.Color.White;
            this.ItemShopButton.BorderRadius = 10;
            this.ItemShopButton.BorderThickness = 2;
            this.ItemShopButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ItemShopButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ItemShopButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ItemShopButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ItemShopButton.FillColor = System.Drawing.Color.Transparent;
            this.ItemShopButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemShopButton.ForeColor = System.Drawing.Color.White;
            this.ItemShopButton.Location = new System.Drawing.Point(3, 298);
            this.ItemShopButton.Name = "ItemShopButton";
            this.ItemShopButton.Size = new System.Drawing.Size(249, 45);
            this.ItemShopButton.TabIndex = 13;
            this.ItemShopButton.Text = "🛒Item Shop";
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BorderColor = System.Drawing.Color.White;
            this.SettingsButton.BorderRadius = 10;
            this.SettingsButton.BorderThickness = 2;
            this.SettingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SettingsButton.FillColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Location = new System.Drawing.Point(3, 699);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(249, 45);
            this.SettingsButton.TabIndex = 14;
            this.SettingsButton.Text = "⚙️Settings";
            // 
            // downloadPanel1
            // 
            this.downloadPanel1.BackColor = System.Drawing.Color.Black;
            this.downloadPanel1.Location = new System.Drawing.Point(332, 138);
            this.downloadPanel1.Name = "downloadPanel1";
            this.downloadPanel1.Size = new System.Drawing.Size(1464, 648);
            this.downloadPanel1.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1225, 753);
            this.Controls.Add(this.downloadPanel1);
            this.Controls.Add(this.DownloadPanel);
            this.Controls.Add(this.StatsPanel);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.AppExitButton);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.StatsPanel.ResumeLayout(false);
            this.StatsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.DownloadPanel.ResumeLayout(false);
            this.DownloadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button AppExitButton;
        private Guna.UI2.WinForms.Guna2Button MinimizeButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel StatsPanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel DownloadPanel;
        private Guna.UI2.WinForms.Guna2Button OpenFortLibrary;
        private Guna.UI2.WinForms.Guna2Button LaunchButton;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button HomeButton;
        private Guna.UI2.WinForms.Guna2Button LibraryButton;
        private Guna.UI2.WinForms.Guna2Button ItemShopButton;
        private Guna.UI2.WinForms.Guna2Button SettingsButton;
        private DownloadPanel downloadPanel1;
    }
}