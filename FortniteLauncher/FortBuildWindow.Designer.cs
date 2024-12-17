namespace FortniteLauncher
{
    partial class FortBuildWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FortBuildWindow));
            this.AppExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PathBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FolderBrowserEvent = new Guna.UI2.WinForms.Guna2Button();
            this.SavePathButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
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
            this.AppExitButton.Location = new System.Drawing.Point(747, 12);
            this.AppExitButton.Name = "AppExitButton";
            this.AppExitButton.Size = new System.Drawing.Size(41, 45);
            this.AppExitButton.TabIndex = 1;
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
            this.MinimizeButton.Location = new System.Drawing.Point(700, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(41, 45);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "NEON";
            // 
            // PathBox
            // 
            this.PathBox.BackColor = System.Drawing.Color.Transparent;
            this.PathBox.BorderColor = System.Drawing.Color.White;
            this.PathBox.BorderRadius = 10;
            this.PathBox.BorderThickness = 2;
            this.PathBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PathBox.DefaultText = "";
            this.PathBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PathBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PathBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathBox.FillColor = System.Drawing.Color.Transparent;
            this.PathBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PathBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathBox.ForeColor = System.Drawing.Color.White;
            this.PathBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PathBox.Location = new System.Drawing.Point(19, 172);
            this.PathBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PathBox.Name = "PathBox";
            this.PathBox.PasswordChar = '\0';
            this.PathBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.PathBox.PlaceholderText = "Enter GamePath";
            this.PathBox.SelectedText = "";
            this.PathBox.Size = new System.Drawing.Size(702, 64);
            this.PathBox.TabIndex = 4;
            // 
            // FolderBrowserEvent
            // 
            this.FolderBrowserEvent.BackColor = System.Drawing.Color.Transparent;
            this.FolderBrowserEvent.BorderColor = System.Drawing.Color.White;
            this.FolderBrowserEvent.BorderRadius = 10;
            this.FolderBrowserEvent.BorderThickness = 2;
            this.FolderBrowserEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FolderBrowserEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FolderBrowserEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FolderBrowserEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FolderBrowserEvent.FillColor = System.Drawing.Color.Transparent;
            this.FolderBrowserEvent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderBrowserEvent.ForeColor = System.Drawing.Color.White;
            this.FolderBrowserEvent.Location = new System.Drawing.Point(727, 172);
            this.FolderBrowserEvent.Name = "FolderBrowserEvent";
            this.FolderBrowserEvent.Size = new System.Drawing.Size(61, 64);
            this.FolderBrowserEvent.TabIndex = 5;
            this.FolderBrowserEvent.Text = "📁";
            this.FolderBrowserEvent.Click += new System.EventHandler(this.FolderBrowserEvent_Click);
            // 
            // SavePathButton
            // 
            this.SavePathButton.BackColor = System.Drawing.Color.Transparent;
            this.SavePathButton.BorderColor = System.Drawing.Color.White;
            this.SavePathButton.BorderRadius = 10;
            this.SavePathButton.BorderThickness = 2;
            this.SavePathButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SavePathButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SavePathButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SavePathButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SavePathButton.FillColor = System.Drawing.Color.Transparent;
            this.SavePathButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePathButton.ForeColor = System.Drawing.Color.White;
            this.SavePathButton.Location = new System.Drawing.Point(295, 274);
            this.SavePathButton.Name = "SavePathButton";
            this.SavePathButton.Size = new System.Drawing.Size(276, 45);
            this.SavePathButton.TabIndex = 6;
            this.SavePathButton.Text = "Save";
            this.SavePathButton.Click += new System.EventHandler(this.SavePathButton_Click);
            // 
            // FortBuildWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(804, 353);
            this.Controls.Add(this.SavePathButton);
            this.Controls.Add(this.FolderBrowserEvent);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.AppExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FortBuildWindow";
            this.Text = "FortBuildWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AppExitButton;
        private Guna.UI2.WinForms.Guna2Button MinimizeButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox PathBox;
        private Guna.UI2.WinForms.Guna2Button FolderBrowserEvent;
        private Guna.UI2.WinForms.Guna2Button SavePathButton;
    }
}