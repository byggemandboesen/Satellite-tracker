namespace Amtrack___Satellite_tracking_software
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Title = new System.Windows.Forms.Label();
            this.TLE_Files = new System.Windows.Forms.ListBox();
            this.BrowseTLE = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Sats = new System.Windows.Forms.ListBox();
            this.UpdateTLE = new System.Windows.Forms.Label();
            this.TLE_Update = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sat_Name = new System.Windows.Forms.Label();
            this.Launch_Year = new System.Windows.Forms.Label();
            this.Catalog_Number = new System.Windows.Forms.Label();
            this.Track = new System.Windows.Forms.Button();
            this.Active_sats = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CustomSatUpdate = new System.Windows.Forms.Button();
            this.CustomTLE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(584, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "Amtrack";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TLE_Files
            // 
            this.TLE_Files.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLE_Files.FormattingEnabled = true;
            this.TLE_Files.ItemHeight = 15;
            this.TLE_Files.Location = new System.Drawing.Point(15, 103);
            this.TLE_Files.Name = "TLE_Files";
            this.TLE_Files.Size = new System.Drawing.Size(125, 169);
            this.TLE_Files.TabIndex = 1;
            this.TLE_Files.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TLE_Files_MouseDoubleClick);
            // 
            // BrowseTLE
            // 
            this.BrowseTLE.BackColor = System.Drawing.Color.DarkGray;
            this.BrowseTLE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BrowseTLE.Location = new System.Drawing.Point(222, 40);
            this.BrowseTLE.Name = "BrowseTLE";
            this.BrowseTLE.Size = new System.Drawing.Size(140, 25);
            this.BrowseTLE.TabIndex = 3;
            this.BrowseTLE.Text = "Browse TLE folder";
            this.BrowseTLE.UseVisualStyleBackColor = false;
            this.BrowseTLE.Click += new System.EventHandler(this.GetTLEPath_Click);
            // 
            // Sats
            // 
            this.Sats.FormattingEnabled = true;
            this.Sats.ItemHeight = 15;
            this.Sats.Location = new System.Drawing.Point(337, 103);
            this.Sats.Name = "Sats";
            this.Sats.Size = new System.Drawing.Size(235, 169);
            this.Sats.TabIndex = 4;
            this.Sats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Sats_MouseDoubleClick);
            // 
            // UpdateTLE
            // 
            this.UpdateTLE.AutoSize = true;
            this.UpdateTLE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTLE.Location = new System.Drawing.Point(173, 85);
            this.UpdateTLE.Name = "UpdateTLE";
            this.UpdateTLE.Size = new System.Drawing.Size(129, 15);
            this.UpdateTLE.TabIndex = 5;
            this.UpdateTLE.Text = "Update/Downlaod TLE:";
            // 
            // TLE_Update
            // 
            this.TLE_Update.FormattingEnabled = true;
            this.TLE_Update.ItemHeight = 15;
            this.TLE_Update.Location = new System.Drawing.Point(176, 103);
            this.TLE_Update.Name = "TLE_Update";
            this.TLE_Update.Size = new System.Drawing.Size(125, 169);
            this.TLE_Update.TabIndex = 6;
            this.TLE_Update.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TLE_Update_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "TLE-files:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Available satellites in:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Satellite name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Year of launch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Catalog number:";
            // 
            // Sat_Name
            // 
            this.Sat_Name.AutoSize = true;
            this.Sat_Name.BackColor = System.Drawing.Color.Red;
            this.Sat_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sat_Name.Location = new System.Drawing.Point(109, 387);
            this.Sat_Name.Name = "Sat_Name";
            this.Sat_Name.Size = new System.Drawing.Size(32, 17);
            this.Sat_Name.TabIndex = 14;
            this.Sat_Name.Text = "N/A";
            // 
            // Launch_Year
            // 
            this.Launch_Year.AutoSize = true;
            this.Launch_Year.BackColor = System.Drawing.Color.Red;
            this.Launch_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Launch_Year.Location = new System.Drawing.Point(259, 387);
            this.Launch_Year.Name = "Launch_Year";
            this.Launch_Year.Size = new System.Drawing.Size(32, 17);
            this.Launch_Year.TabIndex = 15;
            this.Launch_Year.Text = "N/A";
            // 
            // Catalog_Number
            // 
            this.Catalog_Number.AutoSize = true;
            this.Catalog_Number.BackColor = System.Drawing.Color.Red;
            this.Catalog_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Catalog_Number.Location = new System.Drawing.Point(404, 387);
            this.Catalog_Number.Name = "Catalog_Number";
            this.Catalog_Number.Size = new System.Drawing.Size(32, 17);
            this.Catalog_Number.TabIndex = 16;
            this.Catalog_Number.Text = "N/A";
            // 
            // Track
            // 
            this.Track.Location = new System.Drawing.Point(135, 424);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(130, 30);
            this.Track.TabIndex = 17;
            this.Track.Text = "Track satellite";
            this.Track.UseVisualStyleBackColor = true;
            this.Track.Click += new System.EventHandler(this.Track_Click);
            // 
            // Active_sats
            // 
            this.Active_sats.Location = new System.Drawing.Point(335, 424);
            this.Active_sats.Name = "Active_sats";
            this.Active_sats.Size = new System.Drawing.Size(130, 30);
            this.Active_sats.TabIndex = 18;
            this.Active_sats.Text = "Visible sats in TLE";
            this.Active_sats.UseVisualStyleBackColor = true;
            this.Active_sats.Click += new System.EventHandler(this.Active_sats_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(261, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Custom TLE:";
            // 
            // CustomSatUpdate
            // 
            this.CustomSatUpdate.Location = new System.Drawing.Point(489, 311);
            this.CustomSatUpdate.Name = "CustomSatUpdate";
            this.CustomSatUpdate.Size = new System.Drawing.Size(75, 50);
            this.CustomSatUpdate.TabIndex = 23;
            this.CustomSatUpdate.Text = "Update satellite";
            this.CustomSatUpdate.UseVisualStyleBackColor = true;
            this.CustomSatUpdate.Click += new System.EventHandler(this.CustomSatUpdate_Click);
            // 
            // CustomTLE
            // 
            this.CustomTLE.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomTLE.Location = new System.Drawing.Point(99, 311);
            this.CustomTLE.Multiline = true;
            this.CustomTLE.Name = "CustomTLE";
            this.CustomTLE.Size = new System.Drawing.Size(384, 50);
            this.CustomTLE.TabIndex = 24;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.CustomTLE);
            this.Controls.Add(this.CustomSatUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Active_sats);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.Catalog_Number);
            this.Controls.Add(this.Launch_Year);
            this.Controls.Add(this.Sat_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TLE_Update);
            this.Controls.Add(this.UpdateTLE);
            this.Controls.Add(this.Sats);
            this.Controls.Add(this.BrowseTLE);
            this.Controls.Add(this.TLE_Files);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 550);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form";
            this.Text = "Amtrack - By Victor Boesen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox TLE_Files;
        private System.Windows.Forms.Button BrowseTLE;
        private System.Windows.Forms.ListBox Sats;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label UpdateTLE;
        private System.Windows.Forms.ListBox TLE_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Sat_Name;
        private System.Windows.Forms.Label Launch_Year;
        private System.Windows.Forms.Label Catalog_Number;
        private System.Windows.Forms.Button Track;
        private System.Windows.Forms.Button Active_sats;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CustomSatUpdate;
        private System.Windows.Forms.TextBox CustomTLE;
    }
}

